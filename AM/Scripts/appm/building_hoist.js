function testbh() {
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
    var check = testbh();
    if (check)
    {
    var userid = $("#userid").val();
    var objArr = $("input[type=text]");
    var mobjArr1 = $("input[mtype=1]");
    //var checkitem = $("input[name=checkbox_name]:checked");
    //var radios = $("input[name=sex]:checked");
    //var xb = $(radios[0]).next("label").text();
    //var textareas = $("textarea");
    //var pxd = "";
    //for (var i = 0; i < checkitem.length; i++) {
        
    //    pxd += $(checkitem[i]).parent("label").text().trim();
    //    if (i < checkitem.length) {
    //        pxd += ","
    //    }
    //}
    var json = {
        "building_hoist": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "GCMC": $(objArr[0]).val(),
            "SYDW": $(objArr[1]).val(),
            "SGDD": $(objArr[2]).val(),
            "JLDW": $(objArr[3]).val(),
            "AZDW": $(objArr[4]).val(),
            "AZFZR" : $(objArr[5]).val(),
            "SBMC": $(objArr[6]).val(),
            "SBXH": $(objArr[7]).val(),
            "ZZDW": $(objArr[8]).val(),
            "ZZXKZH": $(objArr[9]).val(),
            "CCBH": $(objArr[10]).val(),
            "AZGZRQ": $(objArr[11]).val(),
            "BABH": $(objArr[12]).val(),
            "EDZZL": $(objArr[13]).val(),
            "DLZL": $(objArr[14]).val(),
            "EDTSSD": $(objArr[15]).val(),
            "FZAQQXS": $(objArr[16]).val(),
            "DZZL": $(objArr[17]).val(),
            "TYSAZGD": $(objArr[18]).val(),
            "ZYDGD": $(objArr[19]).val(),
            "FQDS": $(objArr[20]).val(),
            "DYFQGD": $(objArr[21]).val(),
            "BZJGG": $(objArr[22]).val(),
            "JYLX": $(objArr[23]).val(),
            "YQMC1": $(mobjArr1[0]).val(),
            "XH1": $(mobjArr1[1]).val(),
            "BH1": $(mobjArr1[2]).val(),
            "ZT1": $(mobjArr1[3]).val(),
            "YQMC2": $(mobjArr1[4]).val(),
            "XH2": $(mobjArr1[5]).val(),
            "BH2": $(mobjArr1[6]).val(),
            "ZT2": $(mobjArr1[7]).val(),
            "YQMC3": $(mobjArr1[8]).val(),
            "XH3": $(mobjArr1[9]).val(),
            "BH3" : $(mobjArr1[10]).val(),
            "ZT3" : $(mobjArr1[11]).val(),
            "YQMC4" : $(mobjArr1[12]).val(),
            "XH4": $(mobjArr1[13]).val(),
            "BH4": $(mobjArr1[14]).val(),
            "ZT4": $(mobjArr1[15]).val(),
            "YQMC5": $(mobjArr1[16]).val(),
            "XH5": $(mobjArr1[17]).val(),
            "BH5": $(mobjArr1[18]).val(),
            "ZT5": $(mobjArr1[19]).val(),
            "BZXMBHGS": $(objArr[objArr.length-2]).val(),
            "YBXMBHGS": $(objArr[objArr.length-1]).val(),
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addbuilding_hoist",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");

        }
    })

    }
}