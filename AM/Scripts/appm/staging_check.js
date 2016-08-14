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
                if ($("#jlcompany").val() == "") {
                    alert("监理单位不能为空");
                    $("#jlcompany").focus();
                } else {
                    if ($("#sbname").val() == "") {
                        alert("设备名称不能为空");
                        $("#sbname").focus();
                    } else {
                        if ($("#azcompany").val() == "") {
                            alert("安装单位不能为空");
                            $("#azcompany").focus();
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
                                            if ($("#xkz").val() == "") {
                                                alert("特种设备生产制造许可证不能为空");
                                                $("#xkz").focus();
                                            } else {
                                                if ($("#checkheight").val() == "") {
                                                    alert("检验高度不能为空");
                                                    $("#checkheight").focus();
                                                } else {
                                                    if ($("#checkheight").val() == "") {
                                                        alert("检验高度不能为空");
                                                        $("#checkheight").focus();
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
    var objArr = $("input[type=text]");
   
    var json = {
        "staging_check": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "GCMC": $(objArr[0]).val(),
            "SGDD" : $(objArr[1]).val(),
            "SYDW": $(objArr[2]).val(),
            "JLDW": $(objArr[3]).val(),
            "SBMC": $(objArr[4]).val(),
            "AZDW": $(objArr[5]).val(),
            "SBXH": $(objArr[6]).val(),
            "SBBH": $(objArr[7]).val(),
            "SCCJ": $(objArr[8]).val(),
            "CCRQ": $(objArr[9]).val(),
            "ZZXKZ": $(objArr[10]).val(),
            "JYGD": $(objArr[11]).val(),
            "GXJWYBH": $(objArr[12]).val(),
            "GXJWYZK": $(objArr[13]).val(),
            "NJBSBH": $(objArr[14]).val(),
            "NJBSZK": $(objArr[15]).val(),
            "SZZOBBH": $(objArr[16]).val(),
            "SZZOBZK": $(objArr[17]).val(),
            "WSDJBH": $(objArr[18]).val(),
            "WSDJZK": $(objArr[19]).val(),
            "FSYBH": $(objArr[20]).val(),
            "FSYZK": $(objArr[21]).val(),
            "YBKCBH": $(objArr[22]).val(),
            "YBKCZK": $(objArr[23]).val(),
            "GJC30BH": $(objArr[24]).val(),
            "GJC30ZK": $(objArr[25]).val(),
            "GJC5BH": $(objArr[26]).val(),
            "GJC5ZK": $(objArr[27]).val(),
            "GZC1BH": $(objArr[28]).val(),
            "GZC1ZK": $(objArr[29]).val(),
            "GZC2BH": $(objArr[30]).val(),
            "GZC2ZK": $(objArr[31]).val(),
            "SCBH": $(objArr[32]).val(),
            "SCZK": $(objArr[33]).val(),
            "JYJG": $(objArr[34]).val()
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addstaging_check",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");
            
        }
    })
   
    }
}