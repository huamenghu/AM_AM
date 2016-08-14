function testtc() {
    var isok = false;
    if ($("#gcname").val() == "") {
        alert("工程名称不能为空");
        $("#gcname").focus();
    } else {
        if ($("#sycompany").val() == "") {
            alert("使用单位不能为空");
            $("#sycompany").focus();
        } else {
            if ($("#sgaddress").val() == "") {
                alert("施工地点不能为空");
                $("#sgaddress").focus();
            } else {
                if ($("#jlcompany").val() == "") {
                    alert("监理单位不能为空");
                    $("#jlcompany").focus();
                } else {
                    if ($("#azcompany").val() == "") {
                        alert("安装单位不能为空");
                        $("#azcompany").focus();
                    } else {
                        if ($("#azpeople").val() == "") {
                            alert("安装负责人不能为空");
                            $("#azpeople").focus();
                        } else {
                            if ($("#sbname").val() == "") {
                                alert("设备名称不能为空");
                                $("#sbname").focus();
                            } else {
                                if ($("#type").val() == "") {
                                    alert("设备型号不能为空");
                                    $("#type").focus();
                                } else {
                                    if ($("#zzcompany").val() == "") {
                                        alert("制造单位不能为空");
                                        $("#zzcompany").focus();
                                    } else {
                                        if ($("#azdate").val() == "") {
                                            alert("安装告知日期不能为空");
                                            $("#azdate").focus();
                                        } else {
                                            if ($("#cccode").val() == "") {
                                                alert("出厂编号不能为空");
                                                $("#cccode").focus();
                                            } else {
                                                if ($("#xkzcode").val() == "") {
                                                    alert("制造许可证编号不能为空");
                                                    $("#xkzcode").focus();
                                                } else {
                                                    if ($("#ccdate").val() == "") {
                                                        alert("出厂日期不能为空");
                                                        $("#ccdate").focus();
                                                    } else {
                                                        if ($("#bacode").val() == "") {
                                                            alert("备案编号不能为空");
                                                            $("#bacode").focus();
                                                        } else {
                                                            if ($("#maxweight").val() == "") {
                                                                alert("最大额定起重量不能为空");
                                                                $("#maxweight").focus();
                                                            } else {
                                                                if ($("#edlj").val() == "") {
                                                                    alert("额定力矩不能为空");
                                                                    $("#edlj").focus();
                                                                } else {
                                                                    if ($("#maxspeed").val() == "") {
                                                                        alert("小车最大变幅速度不能为空");
                                                                        $("#maxspeed").focus();
                                                                    } else {
                                                                        if ($("#stnumber").val() == "") {
                                                                            alert("标准节规格/数量不能为空");
                                                                            $("#stnumber").focus();
                                                                        } else {
                                                                            if ($("#checkheight").val() == "") {
                                                                                alert("检验时安装高度不能为空");
                                                                                $("#checkheight").focus();
                                                                            } else {
                                                                                if ($("#maxrange").val() == "") {
                                                                                    alert("最大幅度/安装幅度不能为空");
                                                                                    $("#maxrange").focus();
                                                                                } else {
                                                                                    if ($("#yxheight").val() == "") {
                                                                                        alert("允许独立高度/允许自由端高度不能为空");
                                                                                        $("#yxheight").focus();
                                                                                    } else {
                                                                                        if ($("#checkspace").val() == "") {
                                                                                            alert("检验时安装附着道数/间距不能为空");
                                                                                            $("#checkspace").focus();
                                                                                        } else {
                                                                                            if ($("#wallheight").val() == "") {
                                                                                                alert("第一道附墙高度不能为空");
                                                                                                $("#wallheight").focus();
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
    var check = testtc();
    if (check)
    {
    var userid = $("#userid").val();
    var objArr = $("input[type=text]")
    var mobjArr1 = $("input[mtype=1]");
    var json = {
        "tower_crane": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "GCMC": $(objArr[1]).val(),
            "SYDW": $(objArr[2]).val(),
            "SGDD": $(objArr[3]).val(),
            "JLDW": $(objArr[4]).val(),
            "AZDW": $(objArr[5]).val(),
            "AZFZR": $(objArr[6]).val(),
            "SBMC" : $(objArr[7]).val(),
            "SBXH": $(objArr[8]).val(),
            "ZZDW": $(objArr[9]).val(),
            "AZGZRQ": $(objArr[10]).val(),
            "CCBH": $(objArr[11]).val(),
            "ZZXKZBH": $(objArr[12]).val(),
            "CCRQ": $(objArr[13]).val(),
            "BABH": $(objArr[14]).val(),
            "ZDEDQZL": $(objArr[15]).val(),
            "EDLJ": $(objArr[16]).val(),
            "XCZDBFSD": $(objArr[17]).val(),
            "BZJGGSL": $(objArr[18]).val(),
            "JYSAZGD": $(objArr[19]).val(),
            "ZDFD": $(objArr[20]).val(),
            "YXDLGD": $(objArr[21]).val(),
            "AZFZDS": $(objArr[22]).val(),
            "DYDFQGD": $(objArr[23]).val(),
            "JYLB": $(objArr[24]).val(),
            "ZYSBMC1": $(mobjArr1[0]).val(),
            "ZYSBXH1": $(mobjArr1[1]).val(),
            "ZYSBBH1": $(mobjArr1[2]).val(),
            "ZYSBZT1": $(mobjArr1[3]).val(),
            "ZYSBMC2": $(mobjArr1[4]).val(),
            "ZYSBXH2": $(mobjArr1[5]).val(),
            "ZYSBBH2": $(mobjArr1[6]).val(),
            "ZYSBZT2": $(mobjArr1[7]).val(),
            "ZYSBMC3": $(mobjArr1[8]).val(),
            "ZYSBXH3": $(mobjArr1[9]).val(),
            "ZYSBBH3": $(mobjArr1[10]).val(),
            "ZYSBZT3": $(mobjArr1[11]).val(),
            "ZYSBMC4": $(mobjArr1[12]).val(),
            "ZYSBXH4": $(mobjArr1[13]).val(),
            "ZYSBBH4": $(mobjArr1[14]).val(),
            "ZYSBZT4": $(mobjArr1[15]).val(),
            "ZYSBMC5": $(mobjArr1[16]).val(),
            "ZYSBXH5" : $(mobjArr1[17]).val(),
            "ZYSBBH5": $(mobjArr1[18]).val(),
            "ZYSBZT5": $(mobjArr1[19]).val(),
            "BZXMBHGS": $(objArr[objArr.length-2]).val(),
            "YBXMBHGS": $(objArr[objArr.length - 1]).val(),
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addtower_crane",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");
        }
    })
 
    }
}