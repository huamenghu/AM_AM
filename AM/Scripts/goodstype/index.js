var datagrid;
var dlg_Add;
var dlg_Add_Form;
var dlg_Test;
var dlg_Test_Form;
//var dlg_Edit;
//var dlg_Edit_form;
//var dlg_Edit_RemoveType;
//var dlg_Edit_RemoveType_Form;
//var dlg_Edit_Check;
//var dlg_Edit_Check_Form;
//var dlg_Edit_Title;
//var dlg_Edit_Title_Form;
var rolegrid;
var tempPName;

var toolbar = [
{
    text: '添加',
    iconCls: 'icon-add',
    handler: add
}, '-', {
    text: '修改',
    iconCls: 'icon-edit',
    handler: edit
}, '-', {
    text: '删除',
    iconCls: 'icon-remove',
    handler: del
}, '-', {
    text: '测试',
    iconCls: 'icon-remove',
    handler: test
}
];

$(function () {
    var queryParams = returnQueryParams();
    datagrid = $("#datagrid").datagrid({
        title: "",
        iconCls: 'icon-sum',
        method: 'post',
        sortName: 'typename',
        sortOrder: 'asc',
        idField: 'typeid',
        pageSize: 100,
        striped: true,
        pageList: [10, 20, 50, 100, 200],
        autoRowHeight: false,
        url: "/GoodsType/GetData",
        queryParams: queryParams,
        toolbar: toolbar,
        loadMsg: '正在加载数据，请稍等…',
        frozenColumns: [[
                    {
                        field: 'IsCheck', checkbox: true, width: 80
                    }
        ]],
        columns: [[

                        { field: 'typeid', title: '分类id', width: 120 },
                        { field: 'typename', title: '分类名称', width: 120 },
                        { field: 'typelogo', title: '分类logo', width: 100 },
                        {
                            field: 'Isshow', title: '是否显示', width: 60
                        ,
                            formatter: function (value, row, index) {
                                if (row.Isshow == true) {
                                    return '显示';
                                }
                                if (row.IsShow == false) {
                                    return '不显示';
                                }
                            },
                            styler: function (value, row, index) {
                                if (row.Isshow == true) {
                                    return 'background-color:green;';
                                }
                                if (row.IsShow == false) {
                                    return 'background-color:red;';
                                }
                            }
                        },
                        { field: 'description', title: '描述', width: 250 }

        ]],
        fit: true,
        pagination: true,
        rownumbers: true,
        fitColumns: true,
        singleSelect: false

    });
    $(".datagrid-toolbar").append($("#tb"));

    dlg_Add = $('#Dlg-Add').dialog({
        closed: true,      //窗体右上方的关闭图标是正常显示的
        modal: true        //窗体显示的模式
    });
    dlg_Add_Form = dlg_Add.find("form");
    dlg_Test = $('#Dlg-Test').dialog({
        closed: true,      //窗体右上方的关闭图标是正常显示的
        modal: true        //窗体显示的模式
    });
    dlg_Test_Form = dlg_Test.find("form");
});

function add() {
    $("#tr1").show();
    var PName = dlg_Add_Form.find('#PName');
    PName.combobox({
        url: '/GoodsType/GetFirstOrSecondGoodstype',
        valueField: 'typeid',
        textField: 'typename',
        editable: false
    });
    dlg_Add_Form.form('clear');
    dlg_Add.dialog('open');
    dlg_Add_Form.url = "/GoodsType/Add/";
    if (tempPName != null) {
        PName.combobox('setValue', tempPName);
    }
}
function test() {
    dlg_Test_Form.form('clear');
    dlg_Test.dialog('open');
    dlg_Add_Form.url = "/GoodsType/Test/";
}


function saveDataAdd() {
    $.messager.progress();
    var PName = dlg_Add_Form.find('#PName');
    tempPName = PName.combobox("getValue");
    dlg_Add_Form.form('submit', {
        url: dlg_Add_Form.url,
        onSubmit: function () {
            var isValid = $(this).form('validate');
            if (!isValid) {

            }
            return isValid;
        },
        success: function (data) {
            var data = eval('(' + data + ')'); //处理Json
            var desc = filterDesc(data.ResultDescription);
            if (data.IsSuccess) {

                if (desc) {
                    msgFade("操作成功：" + desc);
                } else {
                    msgFade("操作成功");
                }
                dlg_Add.dialog('close');
                datagrid.datagrid('reload');
            } else {
                if (data.ResultNo == -10) {
                    location.href = '/home/Index';
                } else {
                    if (desc) {
                        msgShow('操作失败:' + desc);
                    } else {
                        msgShow('操作失败');
                    }
                }
            }
        }
    });
    $.messager.progress('close');
}

function saveDataTest() {

    var content = UE.getEditor('editor').getContent();

    $.post("/client/postlogin", { phone: "12345", pwd: content },

    function (data, textStatus) {


        if (data.code == 0) {
            msgFade("操作失败：" + data.message);
        } else {
            msgFade("操作成功");
        }

    }, "json");
}

function edit() {
    var rows = datagrid.datagrid('getSelections');
    var num = rows.length;
    if (num == 0) {
        msgShow('请选择一条记录进行操作!');
        return;
    }
    else if (num > 1) {
        msgShow('您选择了多条记录,只能选择一条记录进行修改!');
        return;
    }

    dlg_Add_Form.form('clear');
    dlg_Add.dialog('open');
    dlg_Add.dialog('setTitle', '您正在修改商品类别:' + rows[0]['typename']);


    $.post("/GoodsType/FillForm/", { id: rows[0]['typeid'] }, function (result) {
        dlg_Add_Form.form('load', result);
    });
    $("#tr1").hide();
    dlg_Add_Form.url = "/GoodsType/Update/" + rows[0]['typeid'];
}

function del() {
    tempPName = "";
    var arr = getSelectedArr(datagrid, 'typeid');
    var aa = arr.join(',')
    var obj = { ids: aa };
    if (arr.length > 0) {
        $.messager.confirm('提示信息', '您确认要删除选中的所有记录吗?', function (data) {
            if (data) {
                $.ajax({
                    url: "/GoodsType/Delete?id=" + arr.join(','),
                    type: 'post',
                    data: obj,
                    error: function () {
                        if (result.desc) {
                            msgShow('操作失败:' + desc);
                        } else {
                            msgShow('操作失败');
                        }
                        datagrid.datagrid('clearSelections');
                    },
                    success: function (data) {
                        var data = eval('(' + data + ')'); //处理Json
                        var desc = filterDesc(data.ResultDescription);
                        if (data.IsSuccess) {
                            if (desc) {
                                msgFade("操作成功：" + desc);
                            } else {
                                msgFade("操作成功");
                            }
                            datagrid.datagrid('reload');
                            datagrid.datagrid('clearSelections');
                        } else {
                            if (data.ResultNo == -10) {
                                location.href = '/home/Index';
                            } else {
                                if (desc) {
                                    msgShow('操作失败:' + desc);
                                } else {
                                    msgShow('操作失败');
                                }
                            }
                        }
                    }
                });
            }
        });
    } else {
        msgShow('请先选择要删除的记录。');
    };

}

function findData() {
    var queryParams = returnQueryParams();
    datagrid.datagrid('reload', queryParams);
}

function returnQueryParams() {
    var obj = {
        Searchtypename: $("#Searchtypename").val(),
        Searchtypeid: $("#Searchtypeid").val(),
        SearchIsshow: $("#SearchIsshow").combobox("getValue")
    }
    return obj;
}
