function test() {
    var isok = false;
    if ($("#cpname").val() == "") {
        alert("产品名称不能为空");
        $("#cpname").focus();
    } else {
        if ($("#type").val() == "") {
            alert("规格型号不能为空");
            $("#type").focus();
        } else {
            if ($("#wtcompany").val() == "") {
                alert("委托单位不能为空");
                $("#wtcompany").focus();
            } else {
                if ($("#lxr").val() == "") {
                    alert("联系人不能为空");
                    $("#lxr").focus();
                } else {
                    if ($("#sccompany").val() == "") {
                        alert("生产单位不能为空");
                        $("#sccompany").focus();
                    } else {
                        if ($("#tel").val() == "") {
                            alert("联系电话不能为空");
                            $("#tel").focus();
                        } else {
                            if ($("#cpcode").val() == "") {
                                alert("产品编号不能为空");
                                $("#cpcode").focus();
                            } else {
                                if ($("#wtdate").val() == "") {
                                    alert("委托日期不能为空");
                                    $("#wtdate").focus();
                                } else {
                                    if ($("#address").val() == "") {
                                        alert("单位地址不能为空");
                                        $("#address").focus();
                                    } else {
                                        if ($("#wtcheck").val() == "") {
                                            alert("委托检验要求不能为空");
                                            $("#wtcheck").focus();
                                        } else {
                                            if ($("#checkyj").val() == "") {
                                                alert("检验依据不能为空");
                                                $("#checkyj").focus();
                                            } else {
                                                if ($("#checkmoney").val() == "") {
                                                    alert("检验费用不能为空");
                                                    $("#checkmoney").focus();
                                                } else {
                                                    if ($("#wcdate").val() == "") {
                                                        alert("要求完成日期不能为空");
                                                        $("#wcdate").focus();
                                                    } else {
                                                        if ($("#phproject").val() == "") {
                                                            alert("需委托单位配合完成的项目不能为空");
                                                            $("#phproject").focus();
                                                        } else
                                                            isok = true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    return isok;
}

String.prototype.trim = function () {

    return this.replace(/(^\s*)|(\s*$)/g, '');
}

function submit() {
    var check = test();
    if (check)
    {
    var userid = $("#userid").val();
    var objArr = $("input[type=text]")
    var textareas = $("textarea");
  
    var json = {
        "xsweit_check": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "CPMC": $(objArr[0]).val(),
            "GGXH": $(objArr[1]).val(),
            "WTDW": $(objArr[2]).val(),
            "LXR": $(objArr[3]).val(),
            "SCDW": $(objArr[4]).val(),
            "LXDH": $(objArr[5]).val(),
            "CPBH": $(objArr[6]).val(),
            "WTRQ": $(objArr[7]).val(),
            "DWDZ": $(objArr[8]).val(),
            "WTJYYQ": $(textareas[0]).val(),
            "JYYJ": $(textareas[1]).val(),
            "JYFY": $(objArr[9]).val(),
            "YQWCRQ": $(objArr[10]).val(),
            "PHWCXM": $(textareas[2]).val()
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addxsweit_check",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");
        }
    })
    
    }
}