function testrent() {
    var isok = false;
    if ($("#qm").val() == "") {
        alert("企业名称不能为空");
        $("#qm").focus();
    } else {
        if ($("#qd").val() == "") {
            alert("企业地址不能为空");
            $("#qd").focus();
        } else {
            if ($("#yb").val() == "") {
                alert("邮编不能为空");
                $("#yb").focus();
            } else {
                if ($("#zzjgdm").val() == "") {
                    alert("组织机构代码不能为空");
                    $("#zzjgdm").focus();
                } else {
                    if ($("#lxr").val() == "") {
                        alert("联系人不能为空");
                        $("#lxr").focus();
                    } else {
                        if ($("#tel").val() == "") {
                            alert("固定电话不能为空");
                            $("#tel").focus();
                        } else {
                            if ($("#mobile").val() == "") {
                                alert("移动电话不能为空");
                                $("#mobile").focus();
                            } else {
                                if ($("#email").val() == "") {
                                    alert("电子邮箱不能为空");
                                    $("#email").focus();
                                } else {
                                    if ($("#fax").val() == "") {
                                        alert("传真不能为空");
                                        $("#fax").focus();
                                    } else {
                                        if ($("#license").val() == "") {
                                            alert("营业执照注册号不能为空");
                                            $("#license").focus();
                                        } else {
                                            if ($("#date").val() == "") {
                                                alert("注册日期不能为空");
                                                $("#date").focus();
                                            } else {
                                                if ($("#organ").val() == "") {
                                                    alert("营业执照登记机构不能为空");
                                                    $("#organ").focus();
                                                } else {
                                                    if ($("#type").val() == "") {
                                                        alert("经济类型不能为空");
                                                        $("#type").focus();
                                                    } else {
                                                        if ($("#money").val() == "") {
                                                            alert("注册资金不能为空");
                                                            $("#money").focus();
                                                        } else {
                                                            if ($("#fa").val() == "") {
                                                                alert("固定资产不能为空");
                                                                $("#fa").focus();
                                                            } else {
                                                                if ($("#dlpeople").val() == "") {
                                                                    alert("从事吊篮业务人数不能为空");
                                                                    $("#dlpeople").focus();
                                                                } else {
                                                                    if ($("#people").val() == "") {
                                                                        alert("企业职工总人数不能为空");
                                                                        $("#people").focus();
                                                                    } else {
                                                                        if ($("#dlnumber").val() == "") {
                                                                            alert("出租用吊篮数量不能为空");
                                                                            $("#dlnumber").focus();
                                                                        } else {
                                                                            if ($("#dldate").val() == "") {
                                                                                alert("开始从事吊篮业务日期不能为空");
                                                                                $("#dldate").focus();
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
String.prototype.trim = function () {

    return this.replace(/(^\s*)|(\s*$)/g, '');
}

function submit() {
    var check = testrent();
    if (check)
    {
    var userid = $("#userid").val();
    var objArr = $("input[type=text]");
    var mobjArr1 = $("input[mtype=1]");
    var mobjArr2 = $("input[mtype=2]");
    var mobjArr3 = $("input[mtype=3]");
    var mobjArr4 = $("input[mtype=4]");
    var mobjArr5 = $("input[mtype=5]");
    var mobjArr6 = $("input[mtype=6]");
    //var checkitem = $("input[name=checkbox_name]:checked");
    var radios = $("input[type=radio]:checked");
    var xb0 = $(radios[0]).next("label").text();
    var xb1 = $(radios[1]).next("label").text();
    var xb2 = $(radios[2]).next("label").text();
    var textareas = $("textarea");
    var pxd = "";
    //for (var i = 0; i < checkitem.length; i++) {

    //    pxd += $(checkitem[i]).parent("label").text().trim();
    //    if (i < checkitem.length) {
    //        pxd += ","
    //    }
    //}
    var json = {
        "basket_rent": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "QYQYMC": $(objArr[0]).val(),
            "QYQYDZ": $(objArr[1]).val(),
            "QYYB": $(objArr[2]).val(),
            "QYZZJGDM" : $(objArr[3]).val(),
            "QYLXR": $(objArr[4]).val(),
            "QYGDDH" : $(objArr[5]).val(),
            "QYYDDH": $(objArr[6]).val(),
            "QYDZYX": $(objArr[7]).val(),
            "QYCZ": $(objArr[8]).val(),
            "QYYYZZZCH": $(objArr[9]).val(),
            "QYZCRQ": $(objArr[10]).val(),
            "QYYYZZDJJG": $(objArr[11]).val(),
            "QYJJLX": $(objArr[12]).val(),
            "QYZCZJ": $(objArr[13]).val(),
            "QYGDZC" : $(objArr[14]).val(),
            "QYCSDLYWRS": $(objArr[15]).val(),
            "QYQYZGZRS": $(objArr[16]).val(),
            "QYCZYDLSL": $(objArr[17]).val(),
            "QYKSCSDLYWRQ": $(objArr[18]).val(),
            "QYQYJJ": $(textareas[0]).val(),
            "QYFRXM": $(objArr[19]).val(),
            "QYFRXB":xb0,
            "QYFRZGXL": $(objArr[20]).val(),
            "QYFRZW": $(objArr[21]).val(),
            "QYFRZC": $(objArr[22]).val(),
            "QYFRZY": $(objArr[23]).val(),
            "QYFRGDDH": $(objArr[24]).val(),
            "QYFRYDDH": $(objArr[25]).val(),
            "QYFRPX": $(objArr[26]).val(),
            "QYFRPXSJ": $(objArr[27]).val(),
            "QYFRPXHGZSBH": $(objArr[28]).val(),
            "QYJLXM": $(objArr[29]).val(),
            "QYJLXB":xb1,
            "QYJLZGXL": $(objArr[30]).val(),
            "QYJLZW": $(objArr[31]).val(),
            "QYJLZC": $(objArr[32]).val(),
            "QYJLZY": $(objArr[33]).val(),
            "QYJLGDDH": $(objArr[34]).val(),
            "QYJLYDDH": $(objArr[35]).val(),
            "QYJLPX": $(objArr[36]).val(),
            "QYJLPXSJ": $(objArr[37]).val(),
            "QYJLPXHGZSBH": $(objArr[38]).val(),
            "QYJSXM": $(objArr[39]).val(),
            "QYJSXB":xb2,
            "QYJSZGXL": $(objArr[40]).val(),
            "QYJSZW": $(objArr[41]).val(),
            "QYJSZC": $(objArr[42]).val(),
            "QYJSZY": $(objArr[43]).val(),
            "QYJSGDDH": $(objArr[44]).val(),
            "QYJSYDDH": $(objArr[45]).val(),
            "QYJSPX": $(objArr[46]).val(),
            "QYJSPXSJ": $(objArr[47]).val(),
            "QYJSPXHGZSBH": $(objArr[48]).val(),
            "GLRYXH1": $(mobjArr1[0]).val(),
            "GLRYXM1": $(mobjArr1[1]).val(),
            "GLRYZW1": $(mobjArr1[2]).val(),
            "GLRYZC1": $(mobjArr1[3]).val(),
            "GLRYXL1": $(mobjArr1[4]).val(),
            "GLRYZY1" : $(mobjArr1[5]).val(),
            "GLRYSFZHM1" : $(mobjArr1[6]).val(),
            "GLRYXH2": $(mobjArr1[7]).val(),
            "GLRYXM2": $(mobjArr1[8]).val(),
            "GLRYZW2" : $(mobjArr1[9]).val(),
            "GLRYZC2": $(mobjArr1[10]).val(),
            "GLRYXL2": $(mobjArr1[11]).val(),
            "GLRYZY2": $(mobjArr1[12]).val(),
            "GLRYSFZHM2": $(mobjArr1[13]).val(),
            "GLRYXH3": $(mobjArr1[14]).val(),
            "GLRYXM3": $(mobjArr1[15]).val(),
            "GLRYZW3": $(mobjArr1[16]).val(),
            "GLRYZC3": $(mobjArr1[17]).val(),
            "GLRYXL3": $(mobjArr1[18]).val(),
            "GLRYZY3": $(mobjArr1[19]).val(),
            "GLRYSFZHM3": $(mobjArr1[20]).val(),
            "GLRYXH4": $(mobjArr1[21]).val(),
            "GLRYXM4": $(mobjArr1[22]).val(),
            "GLRYZW4": $(mobjArr1[23]).val(),
            "GLRYZC4": $(mobjArr1[24]).val(),
            "GLRYXL4": $(mobjArr1[25]).val(),
            "GLRYZY4": $(mobjArr1[26]).val(),
            "GLRYSFZHM4": $(mobjArr1[27]).val(),
            "GLRYXH5": $(mobjArr1[28]).val(),
            "GLRYXM5": $(mobjArr1[29]).val(),
            "GLRYZW5": $(mobjArr1[30]).val(),
            "GLRYZC5": $(mobjArr1[31]).val(),
            "GLRYXL5" : $(mobjArr1[32]).val(),
            "GLRYZY5": $(mobjArr1[33]).val(),
            "GLRYSFZHM5": $(mobjArr1[34]).val(),
            "JSGRXH1": $(mobjArr2[0]).val(),
            "JSGRXM1": $(mobjArr2[1]).val(),
            "JSGRGZ1": $(mobjArr2[2]).val(),
            "JSGRXH2": $(mobjArr2[3]).val(),
            "JSGRXM2": $(mobjArr2[4]).val(),
            "JSGRGZ2": $(mobjArr2[5]).val(),
            "JSGRXH3": $(mobjArr2[6]).val(),
            "JSGRXM3": $(mobjArr2[7]).val(),
            "JSGRGZ3": $(mobjArr2[8]).val(),
            "JSGRXH4": $(mobjArr2[9]).val(),
            "JSGRXM4": $(mobjArr2[10]).val(),
            "JSGRGZ4": $(mobjArr2[11]).val(),
            "JSGRXH5": $(mobjArr2[12]).val(),
            "JSGRXM5": $(mobjArr2[13]).val(),
            "JSGRGZ5": $(mobjArr2[14]).val(),
            "ZGZSFZJG1": $(mobjArr3[0]).val(),
            "ZGZSZSBH1": $(mobjArr3[1]).val(),
            "ZGZSYXQ1": $(mobjArr3[2]).val(),
            "ZGZSFZJG2": $(mobjArr3[3]).val(),
            "ZGZSZSBH2": $(mobjArr3[4]).val(),
            "ZGZSYXQ2": $(mobjArr3[5]).val(),
            "ZGZSFZJG3": $(mobjArr3[6]).val(),
            "ZGZSZSBH3": $(mobjArr3[7]).val(),
            "ZGZSYXQ3": $(mobjArr3[8]).val(),
            "ZGZSFZJG4": $(mobjArr3[9]).val(),
            "ZGZSZSBH4": $(mobjArr3[10]).val(),
            "ZGZSYXQ4": $(mobjArr3[11]).val(),
            "ZGZSFZJG5": $(mobjArr3[12]).val(),
            "ZGZSZSBH5": $(mobjArr3[13]).val(),
            "ZGZSYXQ5": $(mobjArr3[14]).val(),
            "WXJCSBXUH1": $(mobjArr4[0]).val(),
            "WXJCSBMC1": $(mobjArr4[1]).val(),
            "WXJCSBXH1": $(mobjArr4[2]).val(),
            "WXJCSBSL1": $(mobjArr4[3]).val(),
            "WXJCSBBZ1": $(mobjArr4[4]).val(),
            "WXJCSBXUH2": $(mobjArr4[5]).val(),
            "WXJCSBMC2" : $(mobjArr4[6]).val(),
            "WXJCSBXH2": $(mobjArr4[7]).val(),
            "WXJCSBSL2": $(mobjArr4[8]).val(),
            "WXJCSBBZ2": $(mobjArr4[9]).val(),
            "WXJCSBXUH3": $(mobjArr4[10]).val(),
            "WXJCSBMC3": $(mobjArr4[11]).val(),
            "WXJCSBXH3": $(mobjArr4[12]).val(),
            "WXJCSBSL3": $(mobjArr4[13]).val(),
            "WXJCSBBZ3": $(mobjArr4[14]).val(),
            "WXJCSBXUH4": $(mobjArr4[15]).val(),
            "WXJCSBMC4": $(mobjArr4[16]).val(),
            "WXJCSBXH4": $(mobjArr4[17]).val(),
            "WXJCSBSL4": $(mobjArr4[18]).val(),
            "WXJCSBBZ4": $(mobjArr4[19]).val(),
            "WXJCSBXUH5": $(mobjArr4[20]).val(),
            "WXJCSBMC5": $(mobjArr4[21]).val(),
            "WXJCSBXH5": $(mobjArr4[22]).val(),
            "WXJCSBSL5": $(mobjArr4[23]).val(),
            "WXJCSBBZ5": $(mobjArr4[24]).val(),
            "GCYJXH1": $(mobjArr5[0]).val(),
            "GCYJGCXMMC1": $(mobjArr5[1]).val(),
            "GCYJZLDLTS1" : $(mobjArr5[2]).val(),
            "GCYJZJZE1": $(mobjArr5[3]).val(),
            "GCYJKJGSJ1": $(mobjArr5[4]).val(),
            "GCYJBZ1": $(mobjArr5[5]).val(),
            "GCYJXH2": $(mobjArr5[6]).val(),
            "GCYJGCXMMC2": $(mobjArr5[7]).val(),
            "GCYJZLDLTS2": $(mobjArr5[8]).val(),
            "GCYJZJZE2": $(mobjArr5[9]).val(),
            "GCYJKJGSJ2": $(mobjArr5[10]).val(),
            "GCYJBZ2": $(mobjArr5[11]).val(),
            "GCYJXH3": $(mobjArr5[12]).val(),
            "GCYJGCXMMC3" : $(mobjArr5[13]).val(),
            "GCYJZLDLTS3": $(mobjArr5[14]).val(),
            "GCYJZJZE3": $(mobjArr5[15]).val(),
            "GCYJKJGSJ3": $(mobjArr5[16]).val(),
            "GCYJBZ3": $(mobjArr5[17]).val(),
            "GCYJXH4": $(mobjArr5[18]).val(),
            "GCYJGCXMMC4": $(mobjArr5[19]).val(),
            "GCYJZLDLTS4": $(mobjArr5[20]).val(),
            "GCYJZJZE4": $(mobjArr5[21]).val(),
            "GCYJKJGSJ4": $(mobjArr5[22]).val(),
            "GCYJBZ4": $(mobjArr5[23]).val(),
            "GCYJXH5": $(mobjArr5[24]).val(),
            "GCYJGCXMMC5": $(mobjArr5[25]).val(),
            "GCYJZLDLTS5": $(mobjArr5[26]).val(),
            "GCYJZJZE5": $(mobjArr5[27]).val(),
            "GCYJKJGSJ5": $(mobjArr5[28]).val(),
            "GCYJBZ5": $(mobjArr5[29]).val(),
            "CZDLXUH1": $(mobjArr6[0]).val(),
            "CZDLXH1": $(mobjArr6[1]).val(),
            "CZDLMC1": $(mobjArr6[2]).val(),
            "CZDLCCRQ1": $(mobjArr6[3]).val(),
            "CZDLDLZZCJ1" : $(mobjArr6[4]).val(),
            "CZDLSL1": $(mobjArr6[5]).val(),
            "CZDLXUH2": $(mobjArr6[6]).val(),
            "CZDLXH2": $(mobjArr6[7]).val(),
            "CZDLMC2": $(mobjArr6[8]).val(),
            "CZDLCCRQ2": $(mobjArr6[9]).val(),
            "CZDLDLZZCJ2": $(mobjArr6[10]).val(),
            "CZDLSL2": $(mobjArr6[11]).val(),
            "CZDLXUH3": $(mobjArr6[12]).val(),
            "CZDLXH3": $(mobjArr6[13]).val(),
            "CZDLMC3": $(mobjArr6[14]).val(),
            "CZDLCCRQ3": $(mobjArr6[15]).val(),
            "CZDLDLZZCJ3": $(mobjArr6[16]).val(),
            "CZDLSL3": $(mobjArr6[17]).val(),
            "CZDLXUH4": $(mobjArr6[18]).val(),
            "CZDLXH4": $(mobjArr6[19]).val(),
            "CZDLMC4": $(mobjArr6[20]).val(),
            "CZDLCCRQ4": $(mobjArr6[21]).val(),
            "CZDLDLZZCJ4": $(mobjArr6[22]).val(),
            "CZDLSL4": $(mobjArr6[23]).val(),
            "CZDLXUH5": $(mobjArr6[24]).val(),
            "CZDLXH5": $(mobjArr6[25]).val(),
            "CZDLMC5": $(mobjArr6[26]).val(),
            "CZDLCCRQ5" : $(mobjArr6[27]).val(),
            "CZDLDLZZCJ5": $(mobjArr6[28]).val(),
            "CZDLSL5": $(mobjArr6[29]).val()
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addbasket_rent",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");
        }
    })
   
    }
}