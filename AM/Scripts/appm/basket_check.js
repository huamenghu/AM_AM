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
            if ($("#ypcode").val() == "") {
                alert("样品编号不能为空");
                $("#ypcode").focus();
            } else {
                if ($("#ypnumber").val() == "") {
                    alert("样品数量不能为空");
                    $("#ypnumber").focus();
                } else {
                    if ($("#scdate").val() == "") {
                        alert("生产日期不能为空");
                        $("#scdate").focus();
                    } else {
                        if ($("#checktype").val() == "") {
                            alert("检验类别不能为空");
                            $("#checktype").focus();
                        } else {
                            if ($("#wtcompany").val() == "") {
                                alert("委托单位不能为空");
                                $("#wtcompany").focus();
                            } else {
                                if ($("#sccompany").val() == "") {
                                    alert("生产单位不能为空");
                                    $("#sccompany").focus();
                                } else {
                                    if ($("#checkaddress").val() == "") {
                                        alert("检验地点不能为空");
                                        $("#checkaddress").focus();
                                    } else {
                                        if ($("#checktime").val() == "") {
                                            alert("检验时间不能为空");
                                            $("#checktime").focus();
                                        } else {
                                            if ($("#checkyj").val() == "") {
                                                alert("检验依据不能为空");
                                                $("#checkyj").focus();
                                            } else {
                                                if ($("#checkend").val() == "") {
                                                    alert("检验结论不能为空");
                                                    $("#checkend").focus();
                                                }
                                                else {
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
    return isok;
}

String.prototype.trim = function () {

    return this.replace(/(^\s*)|(\s*$)/g, '');
}

function submit() {
    var check = test();
    if (check) {
        var userid = $("#userid").val();
        var objArr = $("input[type=text]")
        //var checkitem = $("input[name=checkbox_name]:checked");
        //var radios = $("input[name=sex]:checked");
        //var xb = $(radios[0]).next("label").text();
        var textareas = $("textarea");
        //var pxd = "";
        //for (var i = 0; i < checkitem.length; i++) {

        //    pxd += $(checkitem[i]).parent("label").text().trim();
        //    if (i < checkitem.length) {
        //        pxd += ","
        //    }
        //}
        var json = {
            "basket_check": [{
                "Guid": "",
                "CreateDate": "",
                "userid": userid,
                "cpmc": $(objArr[0]).val(),
                "ggxh": $(objArr[1]).val(),
                "ypbh": $(objArr[2]).val(),
                "ypsl": $(objArr[3]).val(),
                "scrq": $(objArr[4]).val(),
                "jylx": $(objArr[5]).val(),
                "wtdw": $(objArr[6]).val(),
                "scdw": $(objArr[7]).val(),
                "jydd": $(objArr[8]).val(),
                "jysj": $(objArr[9]).val(),
                "jyyj": $(textareas[0]).val(),
                "jyjl": $(textareas[1]).val(),
                "bz": $(textareas[2]).val()
            }]
        };
        $.ajax({
            type: "post",
            url: "/AppM/addbasket_check",
            data: { obj: JSON.stringify(json) },
            success: function (data) {
                layer.msg("提交成功");
            }
        })
    }
}