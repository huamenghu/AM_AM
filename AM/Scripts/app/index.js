var datagrid;
var dlg_App;
var dlg_App_Form;
var rolegrid;


var toolbar = [{
    text: '修改',
    iconCls: 'icon-edit',
    handler: edit
}
];

$(function () {
    var queryParams = returnQueryParams();
    datagrid = $("#datagrid").datagrid({
        title: "",
        iconCls: 'icon-sum',
        method: 'post',
        sortName: 'description',
        sortOrder: 'asc',
        idField: 'userid',
        pageSize: 100,
        striped: true,
        pageList: [10, 20, 50, 100, 200],
        autoRowHeight: false,
        url: "/app/GetData",
        queryParams: queryParams,
        toolbar: toolbar,
        loadMsg: '正在加载数据，请稍等…',
        frozenColumns: [[
                    {
                        field: 'IsCheck', checkbox: true, width: 80
                    }
        ]],
        columns: [[

                        //{ field: 'userid', title: 'userid', width: 120 },
                        { field: 'appid', title: 'appid', width: 120 },
                        { field: 'content', title: 'content', width: 100 },
                        { field: 'description', title: '描述', width: 250 }

        ]],
        fit: true,
        pagination: true,
        rownumbers: true,
        fitColumns: true,
        singleSelect: false

    });
    $(".datagrid-toolbar").append($("#tb"));

    dlg_App = $('#Dlg-App').dialog({
        closed: true,      //窗体右上方的关闭图标是正常显示的
        modal: true        //窗体显示的模式
    });
    dlg_App_Form = dlg_App.find("form");

});

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
    dlg_App_Form.form('clear');
    dlg_App.dialog('open');
    dlg_App.dialog('setTitle', '您正在修改app:' + rows[0]['appid']);

    $.post("/app/FillForm/", { id: rows[0]['appid'] }, function (result) {
        dlg_App_Form.form('load', result);
    });
    dlg_App_Form.url = "/app/update/" + rows[0]['appid'];
}

function saveDataApp() {
    var content = UE.getEditor('editor').getContent();

    $.post("/client/postlinkme", { pwd: content },

    function (data, textStatus) {


        if (data.code == 0) {
            msgFade("操作失败：" + data.message);
        } else {
            msgFade("操作成功");
        }

    }, "json");
}
function findData() {
    queryParams = returnQueryParams();
    datagrid.datagrid('reload', queryParams);
}

function returnQueryParams() {
    var obj = {
        //Searchtypename: $("#Searchtypename").val(),
        //Searchtypeid: $("#Searchtypeid").val(),
        //SearchIsshow: $("#SearchIsshow").combobox("getValue")
    }
    return obj;
}
