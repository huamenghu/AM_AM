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
                                        if ($("#aqscode").val() == "") {
                                            alert("安全锁编号不能为空");
                                            $("#aqscode").focus();
                                        } else {
                                            if ($("#xkz").val() == "") {
                                                alert("特种设备生产制造许可证不能为空");
                                                $("#xkz").focus();
                                            } else {
                                                if ($("#cqcode").val() == "") {
                                                    alert("产权编号不能为空");
                                                    $("#cqcode").focus();
                                                } else {
                                                    if ($("#ccdate").val() == "") {
                                                        alert("出厂日期不能为空");
                                                        $("#ccdate").focus();
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
        "basket_install": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "gcmc":$(objArr[0]).val(),
            "sgdd":$(objArr[1]).val(),
            "sydw":$(objArr[2]).val(),
            "jldw":$(objArr[3]).val(),
            "sbmc":$(objArr[4]).val(),
            "azdw":$(objArr[5]).val(),
            "sbxh":$(objArr[6]).val(),
            "sbbh":$(objArr[7]).val(),
            "sccj":$(objArr[8]).val(),
            "aqsbh":$(objArr[9]).val(),
            "tzsbsczzxkz":$(objArr[10]).val(),
            "cqbh":$(objArr[11]).val(),
            "ccrq":$(objArr[12]).val(),
            "jygd":$(objArr[13]).val(),
            "szzobbh":$(objArr[14]).val(),
            "szzobyqzk":$(objArr[15]).val(),
            "wsdjbh":$(objArr[16]).val(),
            "wsdjyqzk":$(objArr[17]).val(),
            "szwybbh":$(objArr[18]).val(),
            "szwybyqzk":$(objArr[19]).val(),
            "scbh":$(objArr[20]).val(),
            "scyqzk":$(objArr[21]).val(),
            "gzcbh":$(objArr[22]).val(),
            "gzcyqzk":$(objArr[23]).val(),
            "szjdcbh":$(objArr[24]).val(),
            "szjdcyqzk":$(objArr[25]).val(),
            "fsybh":$(objArr[26]).val(),
            "fsyyqzk":$(objArr[27]).val(),
            "ybkcbh":$(objArr[28]).val(),
            "ybkcyqzk":$(objArr[29]).val(),
            "gjc30mbh":$(objArr[30]).val(),
            "gjc30mzxkz":$(objArr[31]).val(),
            "gjc5mbh":$(objArr[32]).val(),
            "gjc5mzxkz":$(objArr[33]).val(),
            "bzxmbhgs":$(objArr[34]).val(),
            "ybxmbhgs": $(objArr[35]).val(),
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addbasket_install",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");

        }
    })
    
    //}
}