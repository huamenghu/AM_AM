function testmade() {
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
                                                                if ($("#people").val() == "") {
                                                                    alert("企业职工总人数不能为空");
                                                                    $("#people").focus();
                                                                } else {
                                                                    if ($("#begindate").val() == "") {
                                                                        alert("开始制造吊篮日期不能为空");
                                                                        $("#begindate").focus();
                                                                    } else {
                                                                        if ($("#modeltype").val() == "") {
                                                                            alert("申请产品规格型号不能为空");
                                                                            $("#begmodeltypeindate").focus();
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
    return isok;
}
String.prototype.trim = function () {

    return this.replace(/(^\s*)|(\s*$)/g, '');
}

function submit() {
    //var check = testmade();
    //if (check)
    //{
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
        "basket_made": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "qymc": $(objArr[0]).val(),
            "qydz": $(objArr[1]).val(),
            "yb": $(objArr[2]).val(),
            "zzjgdm": $(objArr[3]).val(),
            "lxr": $(objArr[4]).val(),
            "gddh": $(objArr[5]).val(),
            "yddh"  : $(objArr[6]).val(),
            "dzyx" : $(objArr[7]).val(),
            "cz" : $(objArr[8]).val(),
            "yyzzzch": $(objArr[9]).val(),
            "jjlx": $(objArr[10]).val(),
            "zczj": $(objArr[11]).val(),
            "gdzc" : $(objArr[12]).val(),
            "qyzgzrs": $(objArr[13]).val(),
            "kszzdlrq": $(objArr[14]).val(),
            "sqcpggxh": $(objArr[15]).val(),
            "qyjj":$(textareas[0]).val(),
            "fddbxm": $(objArr[16]).val(),
            "fddbxb":  xb0,
            "fddbzgxl": $(objArr[17]).val(),
            "fddbzw": $(objArr[18]).val(),
            "fddbzc": $(objArr[19]).val(),
            "fddbzy": $(objArr[20]).val(),
            "fddbgddh": $(objArr[21]).val(),
            "fddbyddh": $(objArr[22]).val(),
            "fddbzypx" : $(objArr[23]).val(),
            "fddbpxsj": $(objArr[24]).val(),
            "fddbzsbh": $(objArr[25]).val(),
            "jsfzrxm": $(objArr[26]).val(),
            "jsfzrxb" :xb1,
            "jsfzrzgxl" : $(objArr[27]).val(),
            "jsfzrzw": $(objArr[28]).val(),
            "jsfzrzc": $(objArr[29]).val(),
            "jsfzrzy": $(objArr[30]).val(),
            "jsfzrgddh": $(objArr[31]).val(),
            "jsfzryddh": $(objArr[32]).val(),
            "jsfzrzypx": $(objArr[33]).val(),
            "jsfzrpxsj": $(objArr[34]).val(),
            "jsfzrzsbh": $(objArr[35]).val(),
            "zlfzrxm": $(objArr[36]).val(),
            "zlfzrxb": xb2,
            "zlfzrzgxl": $(objArr[37]).val(),
            "zlfzrzw": $(objArr[38]).val(),
            "zlfzrzc" : $(objArr[39]).val(),
            "zlfzrzy": $(objArr[40]).val(),
            "zlfzrgddh": $(objArr[41]).val(),
            "zlfzryddh": $(objArr[42]).val(),
            "zlfzrzypx": $(objArr[43]).val(),
            "zlfzrpxsj": $(objArr[44]).val(),
            "zlfzrzsbh": $(objArr[45]).val(),
            "gzryxh1":$(mobjArr1[0]).val(),
            "gzryxm1":$(mobjArr1[1]).val(),
            "gzryzw1":$(mobjArr1[2]).val(),
            "gzryzc1":$(mobjArr1[3]).val(),
            "gzryfzjg1":$(mobjArr1[4]).val(),
            "gzryxl1":$(mobjArr1[5]).val(),
            "gzryzy1" :$(mobjArr1[6]).val(),
            "gzryxh2":$(mobjArr1[7]).val(),
            "gzryxm2" :$(mobjArr1[8]).val(),
            "gzryzw2" :$(mobjArr1[9]).val(),
            "gzryzc2":$(mobjArr1[10]).val(),
            "gzryfzjg2" :$(mobjArr1[11]).val(),
            "gzryxl2":$(mobjArr1[12]).val(),
            "gzryzy2":$(mobjArr1[13]).val(),
            "gzryxh3":$(mobjArr1[14]).val(),
            "gzryxm3":$(mobjArr1[15]).val(),
            "gzryzw3":$(mobjArr1[16]).val(),
            "gzryzc3" :$(mobjArr1[17]).val(),
            "gzryfzjg3":$(mobjArr1[18]).val(),
            "gzryxl3":$(mobjArr1[19]).val(),
            "gzryzy3":$(mobjArr1[20]).val(),
            "gzryxh4":$(mobjArr1[21]).val(),
            "gzryxm4":$(mobjArr1[22]).val(),
            "gzryzw4":$(mobjArr1[23]).val(),
            "gzryzc4" :$(mobjArr1[24]).val(),
            "gzryfzjg4" :$(mobjArr1[25]).val(),
            "gzryxl4":$(mobjArr1[26]).val(),
            "gzryzy4" :$(mobjArr1[27]).val(),
            "gzryxh5":$(mobjArr1[28]).val(),
            "gzryxm5":$(mobjArr1[29]).val(),
            "gzryzw5":$(mobjArr1[30]).val(),
            "gzryzc5":$(mobjArr1[31]).val(),
            "gzryfzjg5" :$(mobjArr1[32]).val(),
            "gzryxl5":$(mobjArr1[33]).val(),
            "gzryzy5":$(mobjArr1[34]).val(),
            "tzzyryxh1":$(mobjArr2[0]).val(),
            "tzzyryxm1":$(mobjArr2[1]).val(),
            "tzzyrygz1":$(mobjArr2[2]).val(),
            "tzzyryxh2":$(mobjArr2[3]).val(),
            "tzzyryxm2":$(mobjArr2[4]).val(),
            "tzzyrygz2":$(mobjArr2[5]).val(),
            "tzzyryxh3" :$(mobjArr2[6]).val(),
            "tzzyryxm3":$(mobjArr2[7]).val(),
            "tzzyrygz3":$(mobjArr2[8]).val(),
            "tzzyryxh4" :$(mobjArr2[9]).val(),
            "tzzyryxm4":$(mobjArr2[10]).val(),
            "tzzyrygz4":$(mobjArr2[11]).val(),
            "tzzyryxh5" :$(mobjArr2[12]).val(),
            "tzzyryxm5":$(mobjArr2[13]).val(),
            "tzzyrygz5":$(mobjArr2[14]).val(),
            "zgzsfzjg1":$(mobjArr3[0]).val(),
            "zgzszsbh1":$(mobjArr3[1]).val(),
            "zgzsyxq1":$(mobjArr3[2]).val(),
            "zgzsfzjg2":$(mobjArr3[3]).val(),
            "zgzszsbh2":$(mobjArr3[4]).val(),
            "zgzsyxq2":$(mobjArr3[5]).val(),
            "zgzsfzjg3":$(mobjArr3[6]).val(),
            "zgzszsbh3":$(mobjArr3[7]).val(),
            "zgzsyxq3":$(mobjArr3[8]).val(),
            "zgzsfzjg4":$(mobjArr3[9]).val(),
            "zgzszsbh4":$(mobjArr3[10]).val(),
            "zgzsyxq4":$(mobjArr3[11]).val(),
            "zgzsfzjg5":$(mobjArr3[12]).val(),
            "zgzszsbh5":$(mobjArr3[13]).val(),
            "zgzsyxq5":$(mobjArr3[14]).val(),
            "mxxh1":$(mobjArr4[0]).val(),
            "mxsbmc1":$(mobjArr4[1]).val(),
            "mxgg1":$(mobjArr4[2]).val(),
            "mxsl1" :$(mobjArr4[3]).val(),
            "mxzzs1" :$(mobjArr4[4]).val(),
            "mxxh2":$(mobjArr4[5]).val(),
            "mxsbmc2":$(mobjArr4[6]).val(),
            "mxgg2":$(mobjArr4[7]).val(),
            "mxsl2" :$(mobjArr4[8]).val(),
            "mxzzs2":$(mobjArr4[9]).val(),
            "mxxh3":$(mobjArr4[10]).val(),
            "mxsbmc3":$(mobjArr4[11]).val(),
            "mxgg3":$(mobjArr4[12]).val(),
            "mxsl3":$(mobjArr4[13]).val(),
            "mxzzs3":$(mobjArr4[14]).val(),
            "mxxh4":$(mobjArr4[15]).val(),
            "mxsbmc4":$(mobjArr4[16]).val(),
            "mxgg4":$(mobjArr4[17]).val(),
            "mxsl4":$(mobjArr4[18]).val(),
            "mxzzs4":$(mobjArr4[19]).val(),
            "mxxh5":$(mobjArr4[20]).val(),
            "mxsbmc5" :$(mobjArr4[21]).val(),
            "mxgg5":$(mobjArr4[22]).val(),
            "mxsl5" :$(mobjArr4[23]).val(),
            "mxzzs5" :$(mobjArr4[24]).val(),
            "jyylmxxh1":$(mobjArr5[0]).val(),
            "jyylmxmc1" :$(mobjArr5[1]).val(),
            "jyylmxgg1" :$(mobjArr5[2]).val(),
            "jyylmxsl1":$(mobjArr5[3]).val(),
            "jyylmxyxq1":$(mobjArr5[4]).val(),
            "jyylmxxh2":$(mobjArr5[5]).val(),
            "jyylmxmc2":$(mobjArr5[6]).val(),
            "jyylmxgg2":$(mobjArr5[7]).val(),
            "jyylmxsl2":$(mobjArr5[8]).val(),
            "jyylmxyxq2":$(mobjArr5[9]).val(),
            "jyylmxxh3":$(mobjArr5[10]).val(),
            "jyylmxmc3":$(mobjArr5[11]).val(),
            "jyylmxgg3":$(mobjArr5[12]).val(),
            "jyylmxsl3":$(mobjArr5[13]).val(),
            "jyylmxyxq3":$(mobjArr5[14]).val(),
            "jyylmxxh4" :$(mobjArr5[15]).val(),
            "jyylmxmc4":$(mobjArr5[16]).val(),
            "jyylmxgg4":$(mobjArr5[17]).val(),
            "jyylmxsl4" :$(mobjArr5[18]).val(),
            "jyylmxyxq4" :$(mobjArr5[19]).val(),
            "jyylmxxh5":$(mobjArr5[20]).val(),
            "jyylmxmc5":$(mobjArr5[21]).val(),
            "jyylmxgg5":$(mobjArr5[22]).val(),
            "jyylmxsl5" :$(mobjArr5[23]).val(),
            "jyylmxyxq5":$(mobjArr5[24]).val(),
            "yjylnd1":$(mobjArr6[0]).val(),
            "yjylggxh1":$(mobjArr6[1]).val(),
            "yjylcl1":$(mobjArr6[2]).val(),
            "yjylxssr1":$(mobjArr6[3]).val(),
            "yjylbz1":$(mobjArr6[4]).val(),
            "yjylnd2":$(mobjArr6[5]).val(),
            "yjylggxh2":$(mobjArr6[6]).val(),
            "yjylcl2":$(mobjArr6[7]).val(),
            "yjylxssr2":$(mobjArr6[8]).val(),
            "yjylbz2":$(mobjArr6[9]).val(),
            "yjylnd3" :$(mobjArr6[10]).val(),
            "yjylggxh3" :$(mobjArr6[11]).val(),
            "yjylcl3" :$(mobjArr6[12]).val(),
            "yjylxssr3":$(mobjArr6[13]).val(),
            "yjylbz3" :$(mobjArr6[14]).val(),
            "yjylnd4":$(mobjArr6[15]).val(),
            "yjylggxh4" :$(mobjArr6[16]).val(),
            "yjylcl4":$(mobjArr6[17]).val(),
            "yjylxssr4":$(mobjArr6[18]).val(),
            "yjylbz4" :$(mobjArr6[19]).val(),
            "yjylnd5":$(mobjArr6[20]).val(),
            "yjylggxh5":$(mobjArr6[21]).val(),
            "yjylcl5" :$(mobjArr6[22]).val(),
            "yjylxssr5":$(mobjArr6[23]).val(),
            "yjylbz5": $(mobjArr6[24]).val()
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addbasket_made",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");

        }
    })
   
    //}
}