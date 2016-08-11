var urlCS;
var grid;
var dlg_Edit;
var dlg_Edit_form;
var searchWin;
var searchForm;
$(function () {
    grid = $('#grid').datagrid({
        title: title,
        iconCls: icon,
        url: virpath + "/" + table + "/LoadData/" + urlCS,
        sortName: sortName,
        sortOrder: sortOrder,
        idField: idField,
        pageSize: pageSize,
        striped: true,
        frozenColumns: [[
                    { field: 'ck', checkbox: true }
        ]],
        columns: columns,
        fit: true,
        pagination: true,
        rownumbers: true,
        fitColumns: true,
        singleSelect: false,
        toolbar: toolbar,
        nowrap: false,
        onDblClickRow: function (rowIndex, rowData) {  //双击事件             
            myedit(rowData[idField], rowData);
        },
        onHeaderContextMenu: function (e, field) {
            e.preventDefault();
            if (!$('#tmenu').length) {
                createColumnMenu();
            }
            $('#tmenu').menu('show', {
                left: e.pageX,
                top: e.pageY
            });
        }
    });

    dlg_Edit = $('#Dlg-Edit').dialog({
        closed: true,
        maximizable: true,
        minimizable: true,
        modal: true
    });
    dlg_Edit_form = dlg_Edit.find('form');

    $('#btn-search,#btn-search-cancel').linkbutton();
    searchWin = $('#search-window').window({
        iconCls: 'icon-search',
        closed: true,
        modal: true
    });
    searchForm = searchWin.find('form');
    $('body').layout();
    //dateinput = $("#"+updateTitleField).datebox();
});

function createColumnMenu() {
    var tmenu = $('<div id="tmenu" style="width:100px;"></div>').appendTo('body');
    var fields = grid.datagrid('getColumnFields');
    for (var i = 0; i < fields.length; i++) {
        $('<div iconCls="icon-ok"/>').html(fields[i]).appendTo(tmenu);
    }
    tmenu.menu({
        onClick: function (item) {
            if (item.iconCls == 'icon-ok') {
                grid.datagrid('hideColumn', item.text);
                tmenu.menu('setIcon', {
                    target: item.target,
                    iconCls: 'icon-empty'
                });
            } else {
                grid.datagrid('showColumn', item.text);
                tmenu.menu('setIcon', {
                    target: item.target,
                    iconCls: 'icon-ok'
                });
            }
        }
    });
}

function add() {
    dlg_Edit_form.form('clear');
    //var myDate = new Date();
    //var today = myDate.getFullYear().toString() + "\-" + ((myDate.getMonth() + 1) > 9 ? (myDate.getMonth() + 1).toString() : "0" + (myDate.getMonth() + 1).toString()) + "\-" + (myDate.getDate() > 9 ? myDate.getDate().toString() : "0" + myDate.getDate().toString());
    //dateinput.datebox('setValue', today);//设置日期为当前日期
    dlg_Edit.dialog('open');
    dlg_Edit.dialog('setTitle', addTitle);
    dlg_Edit_form.url = virpath + "/" + table + "/Add/" + urlCS;
}

function edit() {
    var rows = grid.datagrid('getSelections');
    var num = rows.length;
    if (num == 0) {
        msgShow('请选择一条记录进行操作!');
        return;
    }
    else if (num > 1) {
        msgFade('您选择了多条记录,只能选择一条记录进行修改!'); //$.messager.alert('提示', '您选择了多条记录,只能选择一条记录进行修改!', 'info');
        return;
    }
    myedit(rows[0][idField], rows[0]);
}
function myedit(id, row) {
    dlg_Edit_form.form('clear');
    dlg_Edit.dialog('open');
    dlg_Edit.dialog('setTitle', '您正在修改:' + row[updateTitleField]);
    $.post(virpath + "/" + table + "/FillForm/", { 'id': row[idField] }, function (result) {
        dlg_Edit_form.form('load', result);
    });
    $.post(virpath + "/AppendProperty/FillPage/", { 'id': row[idField] }, function (result) {
        result = eval('(' + result + ')');
        if (result.length > 0) {
            dlg_Edit_form.form('load', result[0]);
        }
    });
    dlg_Edit_form.url = virpath + "/" + table + "/update/" + id;
}
function del() {
    var arr = getSelectedArr(grid, idField);
    if (arr.length > 0) {
        $.messager.confirm('提示信息', '您确认要删除选中的所有记录吗?', function (data) {
            if (data) {
                $.ajax({
                    url: virpath + "/" + table + "/delete/" + arr.join(','),
                    type: 'post',
                    error: function () {
                        msgAlert('错误', '删除失败!', 'error');
                        grid.datagrid('clearSelections');
                    },
                    success: function (Result) {
                        var data = eval('(' + Result + ')');
                        if (data.IsSuccess) {
                            msgFade(arr.length + "条记录成功删除!"); //提示消息
                            grid.datagrid('reload');
                            grid.datagrid('clearSelections');
                        } else {
                            msgShow('删除失败：' + data.ResultDescription.replace('\'', ''));
                        }
                    }
                });
            }
        });
    } else {
        msgShow('请先选择要删除的记录。');
    }
}

function saveData() {
    dlg_Edit_form.form('submit', {
        url: dlg_Edit_form.url,
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (data) {
            try {
                var result = eval('(' + data + ')'); //处理Json
                var desc = filterDesc(result.ResultDescription);
                if (result.IsSuccess) {
                    msgFade("操作成功：" + desc);
                    grid.datagrid('reload'); //grid变量要与其他文件中的一致
                    dlg_Edit.dialog('close');
                } else {
                    msgShow('操作失败，' + "请重试或重新登录");
                }
            } catch (err) {
                msgShow('操作失败！' + "请重试或重新登录");
            }
        }
    });
}

function showAll() {
    grid.datagrid({ url: virpath + "/" + table + "/LoadData/" + urlCS });
}

function openSearchWin() {
    searchWin.window('open');
    //searchForm.form('clear');
}

function closeSearchWin() {
    searchWin.window('close');
}