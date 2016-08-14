function test() {
    var isok = false;
    if ($("#qm").val() == "") {
        alert("委托单位名称不能为空");
        $("#qm").focus();
    } else {
        if ($("#qd").val() == "") {
            alert("委托单位地址不能为空");
            $("#qd").focus();
        } else {
            if ($("#lxr").val() == "") {
                alert("联系人不能为空");
                $("#lxr").focus();
            } else {
                if ($("#tel").val() == "") {
                    alert("联系电话不能为空");
                    $("#tel").focus();
                } else {
                    if ($("#gcname").val() == "") {
                        alert("工程名称不能为空");
                        $("#gcname").focus();
                    } else {
                        if ($("#gcaddress").val() == "") {
                            alert("工程地址不能为空");
                            $("#gcaddress").focus();
                        } else {
                            if ($("#sgcompany").val() == "") {
                                alert("施工单位不能为空");
                                $("#sgcompany").focus();
                            } else {
                                if ($("#sgaddress").val() == "") {
                                    alert("施工地址不能为空");
                                    $("#sgaddress").focus();
                                } else {
                                    if ($("#checknumber").val() == "") {
                                        alert("检验数量不能为空");
                                        $("#checknumber").focus();
                                    } else {
                                        var obj = document.getElementsByName("checkbox_name");
                                        var b = false;
                                        for (var i = 0; i < obj.length; i++) {
                                            if (obj[i].checked) {
                                                b = true;
                                            }
                                        }
                                        if (b == false) {
                                            alert("检验内容至少选择一个");//提示信息自己修改
                                        } else
                                            isok = true;
                                        return b;
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
    //var check = test();
    //if (check)
    //{
    var userid = $("#userid").val();
    var objArr = $("input[type=text]")
    var checkitem1 = $("input[name=checkbox_name]:checked");
    var checkitem2 = $("input[name=checkbox_name2]:checked");
    var checkitem3 = $("input[name=checkbox_name3]:checked");
    var pxd1 = "";
    for (var i = 0; i < checkitem1.length; i++) {
        
        pxd1 += $(checkitem1[i]).parent("label").text().trim();
        if (i < checkitem1.length) {
            pxd1 += ","
        }
    }
    var pxd2 = "";
    for (var i = 0; i < checkitem2.length; i++) {

        pxd2 += $(checkitem2[i]).parent("label").text().trim();
        if (i < checkitem2.length) {
            pxd2 += ","
        }
    }
    pxd2 += $(objArr[objArr.length - 2]).val();
    var pxd3 = "";
    for (var i = 0; i < checkitem3.length; i++) {

        pxd3 += $(checkitem3[i]).parent("label").text().trim();
        if (i < checkitem3.length) {
            pxd3 += ","
        }
    }
    pxd3 += $(objArr[objArr.length-1]).val();
    var json = {
        "wt_check": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "WTDWMC": $(objArr[0]).val(),
            "WTDWDZ": $(objArr[1]).val(),
            "LXR": $(objArr[2]).val(),
            "LXDH": $(objArr[3]).val(),
            "GCMC": $(objArr[4]).val(),
            "GCDZ": $(objArr[5]).val(),
            "SGDW": $(objArr[6]).val(),
            "SGDZ": $(objArr[7]).val(),
            "JYNR": pxd1,
            "JYSL": $(objArr[8]).val(),
            "SCCJ": $(objArr[9]).val(),
            "SBBH": $(objArr[10]).val(),
            "SBXH": $(objArr[11]).val(),
            "AZGD": $(objArr[12]).val(),
            "QT": $(objArr[13]).val(),
            "QBGFS": pxd2,
            "BGTD": pxd3
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addwt_check",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");
        }
    })
    
    //}
}