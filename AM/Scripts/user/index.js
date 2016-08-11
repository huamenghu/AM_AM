var datagrid;
var dlg_Edit;
var dlg_Edit_form;

var toolbar = [{
    text: '新增',
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
}


//, '-',
//{
//    text: '关键字',
//}
//,
//{
//    text: ' <input id="kword" name="kword" type="text" class="easyui-searchbox" style="width: 150px"></input>'
//    //'<input class="easyui-searchbox"/>',
//}
//, '-', {
//    text: '搜索',
//    iconCls: 'icon-search',
//    handler: search
//}
];
var queryParams = returnQueryParams();
$(function () {

    datagrid = $("#datagrid");

    dlg_Edit = $('#Dlg-Edit').dialog({
        closed: true,
        modal: true
    });
    dlg_Edit_form = dlg_Edit.find("form");
    //$(".datagrid-toolbar table tbody tr").append($("#tb"));
    $(".datagrid-toolbar").append($("#tb"));


});

function add() {
    dlg_Edit_form.form('clear');
    dlg_Edit.dialog('open');
    dlg_Edit.dialog('setTitle', '添加用户');
    dlg_Edit_form.url = "/user/Add/";
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
    dlg_Edit_form.form('clear');
    dlg_Edit.dialog('open');
    dlg_Edit.dialog('setTitle', '您正在修改用户:' + rows[0]['UserName']);

    $.post("/user/FillForm/", { id: rows[0]['GUID'] }, function (result) {
        dlg_Edit_form.form('load', result);
    });
    dlg_Edit_form.url = "/user/update/" + rows[0]['GUID'];
}
function del() {
    var arr = getSelectedArr(datagrid, 'GUID');
    if (arr.length > 0) {
        $.messager.confirm('提示信息', '您确认要删除选中的所有记录吗?', function (data) {
            if (data) {
                $.ajax({
                    url: "/user/delete?id=" + arr.join(','),
                    type: 'post',
                    error: function () {
                        msgAlert('错误', '删除失败!', 'error');
                        datagrid.datagrid('clearSelections');
                    },
                    success: function (data) {
                        var data = eval('(' + data + ')'); //处理Json
                        var desc = filterDesc(data.ResultDescription);
                        if (data.IsSuccess) {
                            msgFade(arr.length + "条记录成功删除!"); //提示消息
                            datagrid.datagrid('reload');
                            datagrid.datagrid('clearSelections');
                        } else {
                            if (data.ResultNo == -10) {
                                location.href = '/Admin/Login';
                            } else {
                                msgShow('删除失败：' + desc.replace("'", ''));
                            }
                        }
                    }
                });
            }
        });
    } else {
        msgShow('请先选择要删除的记录。');
    }
}
function search() {

}
function saveData() {
    dlg_Edit_form.form('submit', {
        url: dlg_Edit_form.url,
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (result) {
            var result = eval('(' + result + ')'); //处理Json
            var desc = filterDesc(result.ResultDescription);
            if (result.IsSuccess) {
                msgFade("操作成功：" + desc);
                datagrid.datagrid('reload'); //grid变量要与其他文件中的一致
                dlg_Edit.dialog('close');
            } else {
                if (result.ResultNo == -10) {
                    location.href = '/Admin/Login';
                } else {
                    msgShow('操作失败:' + desc);
                }

            }
        }
    });
}
function findData() {
    queryParams = returnQueryParams();
    datagrid.datagrid('reload', queryParams);
}

function returnQueryParams() {

    var obj = {
        SearchName: $("#SearchName").val(),
        SearchType: $("#SearchType").val(),

        //$('#SearchType').combobox('getValue'),
        //$('#SearchType').combobox('getValue'),
        // class="easyui-combobox"
        //$("#SearchType").val(),
        SearchRemark: $("#SearchRemark").val()
    }
    return obj;
}
