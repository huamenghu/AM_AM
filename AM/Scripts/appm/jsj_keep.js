function test() {
    var isok = false;
    if ($("#gcname").val() == "") {
        alert("工程名称不能为空");
        $("#gcname").focus();
    } else {
        if ($("#projectaddress").val() == "") {
            alert("项目地址不能为空");
            $("#projectaddress").focus();
        } else {
            if ($("#cqcompany").val() == "") {
                alert("设备产权单位不能为空");
                $("#cqcompany").focus();
            } else {
                if ($("#fzrtel").val() == "") {
                    alert("产权单位负责人及电话不能为空");
                    $("#fzrtel").focus();
                } else {
                    if ($("#azcompany").val() == "") {
                        alert("安装单位不能为空");
                        $("#azcompany").focus();
                    } else {
                        if ($("#zzcompany").val() == "") {
                            alert("设备制造单位不能为空");
                            $("#zzcompany").focus();
                        } else {
                            if ($("#dj").val() == "") {
                                alert("等级不能为空");
                                $("#dj").focus();
                            } else {
                                if ($("#code").val() == "") {
                                    alert("编号不能为空");
                                    $("#code").focus();
                                } else {
                                    if ($("#type").val() == "") {
                                        alert("型号不能为空");
                                        $("#type").focus();
                                    } else {
                                        if ($("#jjcode").val() == "") {
                                            alert("建鉴号不能为空");
                                            $("#jjcode").focus();
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
        "jsj_keep": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "GCMC": $(objArr[0]).val(),
            "XMDZ": $(objArr[1]).val(),
            "SBCQDW": $(objArr[2]).val(),
            "CQDWFZRJDH": $(objArr[3]).val(),
            "AZDW": $(objArr[4]).val(),
            "SBZZDW": $(objArr[5]).val(),
            "ZZDJ": $(objArr[6]).val(),
            "ZZBH": $(objArr[7]).val(),
            "SBXH": $(objArr[8]).val(),
            "SBJJH": $(objArr[9]).val(),
            "ZMWJJYJG": $(objArr[10]).val(),
            "ZMWJJL": $(objArr[11]).val(),
            "ZMWJBZ": $(objArr[12]).val(),
            "CQZMJYJG": $(objArr[13]).val(),
            "CQZMJL": $(objArr[14]).val(),
            "CQZMBZ": $(objArr[15]).val(),
            "ZZZSJYJG": $(objArr[16]).val(),
            "ZZZSJL": $(objArr[17]).val(),
            "ZZZSBZ": $(objArr[18]).val(),
            "SYSMSJYJG": $(objArr[19]).val(),
            "SYSMSJL": $(objArr[20]).val(),
            "SYSMSBZ": $(objArr[21]).val(),
            "GQDBZJZBSJYJG": $(objArr[22]).val(),
            "GQDBZJZBSJL": $(objArr[23]).val(),
            "GQDBZJZBSBZ": $(objArr[24]).val(),
            "ZYSLGJCZZMJYJG": $(objArr[25]).val(),
            "ZYSLGJCZZMJL": $(objArr[26]).val(),
            "ZYSLGJCZZMBZ": $(objArr[27]).val(),
            "ZCBYJLJYJG": $(objArr[28]).val(),
            "ZCBYJLJL": $(objArr[29]).val(),
            "ZCBYJLBZ": $(objArr[30]).val(),
            "ZYJGJJYJG": $(objArr[31]).val(),
            "ZYJGJJL": $(objArr[32]).val(),
            "ZYJGJBZ": $(objArr[33]).val(),
            "ZYSLGJJYJG": $(objArr[34]).val(),
            "ZYSLGJJL": $(objArr[35]).val(),
            "ZYSLGJBZ": $(objArr[36]).val(),
            "ZJSXXJYJG": $(objArr[37]).val(),
            "ZJSXXJL": $(objArr[38]).val(),
            "ZJSXXBZ": $(objArr[39]).val(),
            "FGSXXJYJG": $(objArr[40]).val(),
            "FGSXXJL": $(objArr[41]).val(),
            "FGSXXBZ": $(objArr[42]).val(),
            "DGPZZXDJYJG": $(objArr[43]).val(),
            "DGPZZXDJL": $(objArr[44]).val(),
            "DGPZZXDBZ": $(objArr[45]).val(),
            "DGBMWHJYJG": $(objArr[46]).val(),
            "DGBMWHJL": $(objArr[47]).val(),
            "DGBMWHBZ": $(objArr[48]).val(),
            "FQZZDXJGJYJG": $(objArr[49]).val(),
            "FQZZDXJGJL": $(objArr[50]).val(),
            "FQZZDXJGBZ": $(objArr[51]).val(),
            "FQZZSFQJGJYJG": $(objArr[52]).val(),
            "FQZZSFQJGJL": $(objArr[53]).val(),
            "FQZZSFQJGBZ": $(objArr[54]).val(),
            "FQZZFZLJGJYJG": $(objArr[55]).val(),
            "FQZZFZLJGJL": $(objArr[56]).val(),
            "FQZZFZLJGBZ": $(objArr[57]).val(),
            "FZLZZLMKKJYJG": $(objArr[58]).val(),
            "FZLZZLMKKJL": $(objArr[59]).val(),
            "FZLZZLMKKBZ": $(objArr[60]).val(),
            "FZLZZDLGDJYJG": $(objArr[61]).val(),
            "FZLZZDLGDJL": $(objArr[62]).val(),
            "FZLZZDLGDBZ": $(objArr[63]).val(),
            "FCFWRJYJG": $(objArr[64]).val(),
            "FCFWRJL": $(objArr[65]).val(),
            "FCFWRBZ": $(objArr[66]).val(),
            "GDGSFZLZZJYJG": $(objArr[67]).val(),
            "GDGSFZLZZJL": $(objArr[68]).val(),
            "GDGSFZLZZBZ": $(objArr[69]).val(),
            "FQFZZBKDGJYJG": $(objArr[70]).val(),
            "FQFZZBKDGJL": $(objArr[71]).val(),
            "FQFZZBKDGBZ": $(objArr[72]).val(),
            "SZFQDGJYJG": $(objArr[73]).val(),
            "SZFQDGJL": $(objArr[74]).val(),
            "SZFQDGBZ": $(objArr[75]).val(),
            "FZSXZKJQXJYJG": $(objArr[76]).val(),
            "FZSXZKJQXJL": $(objArr[77]).val(),
            "FZSXZKJQXBZ": $(objArr[78]).val(),
            "SJSBMPJYJG": $(objArr[79]).val(),
            "SJSBMPJL": $(objArr[80]).val(),
            "SJSBMPBZ": $(objArr[81]).val(),
            "DDHLJJYJG": $(objArr[82]).val(),
            "DDHLJJL": $(objArr[83]).val(),
            "DDHLJBZ": $(objArr[84]).val(),
            "LTWHJYJG": $(objArr[85]).val(),
            "LTWHJL": $(objArr[86]).val(),
            "LTWHBZ": $(objArr[87]).val(),
            "CQLSZJCDJYJG": $(objArr[88]).val(),
            "CQLSZJCDJL": $(objArr[89]).val(),
            "CQLSZJCDBZ": $(objArr[90]).val(),
            "DBCCJYJG": $(objArr[91]).val(),
            "DBCCJL": $(objArr[92]).val(),
            "DBCCBZ": $(objArr[93]).val(),
            "XZHZZKXTJYJG": $(objArr[94]).val(),
            "XZHZZKXTJL": $(objArr[95]).val(),
            "XZHZZKXTBZ": $(objArr[96]).val(),
            "CZSZBJTJJYJG": $(objArr[97]).val(),
            "CZSZBJTJJL": $(objArr[98]).val(),
            "CZSZBJTJBZ": $(objArr[99]).val(),
            "XSJYCCJYJG": $(objArr[100]).val(),
            "XSJYCCJL": $(objArr[101]).val(),
            "XSJYCCBZ": $(objArr[102]).val(),
            "MMSAQLWJYJG": $(objArr[103]).val(),
            "MMSAQLWJL": $(objArr[104]).val(),
            "MMSAQLWBZ": $(objArr[105]).val(),
            "FHLGGDJYJG": $(objArr[106]).val(),
            "FHLGGDJL": $(objArr[107]).val(),
            "FHLGGDBZ": $(objArr[108]).val(),
            "DJBGDJYJG": $(objArr[109]).val(),
            "DJBGDJL": $(objArr[110]).val(),
            "DJBGDBZ": $(objArr[111]).val()
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addjsj_keep",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");
        }
    })
   
    }
}