function test() {
    var isok = false;
    if ($("#gcname").val() == "") {
        alert("工程名称不能为空");
        $("#gcname").focus();
    } else {
        if ($("#sgaddress").val() == "") {
            alert("施工地点不能为空");
            $("#sgaddress").focus();
        } else {
            if ($("#sycompany").val() == "") {
                alert("使用单位不能为空");
                $("#sycompany").focus();
            } else {
                if ($("#azcompany").val() == "") {
                    alert("安装单位不能为空");
                    $("#azcompany").focus();
                } else {
                    if ($("#sbname").val() == "") {
                        alert("设备名称不能为空");
                        $("#sbname").focus();
                    } else {
                        if ($("#azpeople").val() == "") {
                            alert("安装负责人不能为空");
                            $("#azpeople").focus();
                        } else {
                            if ($("#type").val() == "") {
                                alert("设备型号不能为空");
                                $("#type").focus();
                            } else {
                                if ($("#sbcode").val() == "") {
                                    alert("设备编号不能为空");
                                    $("#sbcode").focus();
                                } else {
                                    if ($("#scstore").val() == "") {
                                        alert("生产厂家不能为空");
                                        $("#scstore").focus();
                                    } else {
                                        if ($("#ccdate").val() == "") {
                                            alert("出厂日期不能为空");
                                            $("#ccdate").focus();
                                        } else {
                                            if ($("#checkheight").val() == "") {
                                                alert("检验高度不能为空");
                                                $("#checkheight").focus();
                                            } else {
                                                if ($("#checktype").val() == "") {
                                                    alert("检验类别不能为空");
                                                    $("#checktype").focus();
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
   
    var json = {
        "winow_check": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "GCMC": $(objArr[0]).val(),
            "SGDD": $(objArr[1]).val(),
            "SYDW": $(objArr[2]).val(),
            "AZDW": $(objArr[3]).val(),
            "SBMC": $(objArr[4]).val(),
            "AZFZR": $(objArr[5]).val(),
            "SBXH": $(objArr[6]).val(),
            "SBBH": $(objArr[7]).val(),
            "SCCJ": $(objArr[8]).val(),
            "CCRQ": $(objArr[9]).val(),
            "JYGD" : $(objArr[10]).val(),
            "JYLB": $(objArr[11]).val(),
            "DZCSYBH": $(objArr[12]).val(),
            "DZCSYZK": $(objArr[13]).val(),
            "SZZOBBH": $(objArr[14]).val(),
            "SZZOBZK": $(objArr[15]).val(),
            "JMSJJBH": $(objArr[16]).val(),
            "JMSJJZK": $(objArr[17]).val(),
            "SZWYBBH": $(objArr[18]).val(),
            "SZWYBZK": $(objArr[19]).val(),
            "DZMBBH": $(objArr[20]).val(),
            "DZMBZK": $(objArr[21]).val(),
            "FSJBH": $(objArr[22]).val(),
            "FSJZK": $(objArr[23]).val(),
            "WSDJBH": $(objArr[24]).val(),
            "WSDJZK": $(objArr[25]).val(),
            "YBKCBH": $(objArr[26]).val(),
            "YBKCZK": $(objArr[27]).val(),
            "GJC30BH": $(objArr[28]).val(),
            "GJC30ZK": $(objArr[29]).val(),
            "GJC5BH": $(objArr[30]).val(),
            "GJC5ZK": $(objArr[31]).val(),
            "JYJG": $(objArr[32]).val()
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addwinow_check",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");
        }
    })

    }
}