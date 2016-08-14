function test() {
    var isok = false;
    if ($("#type").val() == "") {
        alert("设备型号不能为空");
        $("#type").focus();
    } else {
        if ($("#azcompany").val() == "") {
            alert("安装单位不能为空");
            $("#azcompany").focus();
        } else {
            if ($("#scstore").val() == "") {
                alert("生产厂家不能为空");
                $("#scstore").focus();
            } else {
                if ($("#tsjcode").val() == "") {
                    alert("提升机编号不能为空");
                    $("#tsjcode").focus();
                } else {
                    if ($("#ioscode").val() == "") {
                        alert("安全生产许可证编号不能为空");
                        $("#ioscode").focus();
                    } else {
                        if ($("#aqscode").val() == "") {
                            alert("安全锁编号不能为空");
                            $("#aqscode").focus();
                        } else {
                            if ($("#ccdate").val() == "") {
                                alert("设备编号/出厂日期不能为空");
                                $("#ccdate").focus();
                            } else {
                                if ($("#ysnumber").val() == "") {
                                    alert("验收数量不能为空");
                                    $("#ysnumber").focus();
                                } else
                                    isok = true;
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
        "basket_keep": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "sbxh":$(objArr[0]).val(),
            "azdw":$(objArr[1]).val(),
            "sccj":$(objArr[2]).val(),
            "tsjbh":$(objArr[3]).val(),
            "aqscxkzbh":$(objArr[4]).val(),
            "aqsbh":$(objArr[5]).val(),
            "ccrq":$(objArr[6]).val(),
            "yssl":$(objArr[7]).val(),
            "cpcchgzjyjg":$(objArr[8]).val(),
            "cpcchgzjl":$(objArr[9]).val(),
            "cpcchgznz":$(objArr[10]).val(),
            "cqdjzjyjg":$(objArr[11]).val(),
            "cqdjzjl":$(objArr[12]).val(),
            "cqdjzbz":$(objArr[13]).val(),
            "aqsbdzsjyjg":$(objArr[14]).val(),
            "aqsbdzsjl":$(objArr[15]).val(),
            "aqsbdzsbz":$(objArr[16]).val(),
            "sysmsjyjg":$(objArr[17]).val(),
            "sysmsjl":$(objArr[18]).val(),
            "sysmsbz":$(objArr[19]).val(),
            "gsscsbgjyjg":$(objArr[20]).val(),
            "gsscsbgjl":$(objArr[21]).val(),
            "gsscsbgbz":$(objArr[22]).val(),
            "aqscsbgjyjg":$(objArr[23]).val(),
            "aqscsbgjl":$(objArr[24]).val(),
            "aqscsbgbz":$(objArr[25]).val(),
            "zyslgjczzmjyjg":$(objArr[26]).val(),
            "zyslgjczzmjl":$(objArr[27]).val(),
            "zyslgjczzmbz":$(objArr[28]).val(),
            "dlzcbyjljyjg":$(objArr[29]).val(),
            "dlzcbyjljl":$(objArr[30]).val(),
            "dlzcbyjlbz":$(objArr[31]).val(),
            "xxlwjyjg":$(objArr[32]).val(),
            "xxlwjl":$(objArr[33]).val(),
            "xxlwbz":$(objArr[34]).val(),
            "zyslgjyfhcjsjyqjyjg":$(objArr[35]).val(),
            "zyslgjyfhcjsjyqjl":$(objArr[36]).val(),
            "zyslgjyfhcjsjyqbz":$(objArr[37]).val(),
            "jgjyjg":$(objArr[38]).val(),
            "jgjl":$(objArr[39]).val(),
            "jgbz":$(objArr[40]).val(),
            "jgjgljlsyqqjyjg":$(objArr[41]).val(),
            "jgjgljlsyqqjl":$(objArr[42]).val(),
            "jgjgljlsyqqbz":$(objArr[43]).val(),
            "gwwwjyjg":$(objArr[44]).val(),
            "gwwwjl":$(objArr[45]).val(),
            "gwwwbz":$(objArr[46]).val(),
            "ywjyjg":$(objArr[47]).val(),
            "ywjl":$(objArr[48]).val(),
            "ywbz":$(objArr[49]).val(),
            "jyjg41":$(objArr[50]).val(),
            "jl41":$(objArr[51]).val(),
            "bz41":$(objArr[52]).val(),
            "jyjg42":$(objArr[53]).val(),
            "jl42":$(objArr[54]).val(),
            "bz42":$(objArr[55]).val(),
            "jyjg43":$(objArr[56]).val(),
            "jl43":$(objArr[57]).val(),
            "bz43":$(objArr[58]).val(),
            "jyjg51":$(objArr[59]).val(),
            "jl51":$(objArr[60]).val(),
            "bz51":$(objArr[61]).val(),
            "jyjg52":$(objArr[62]).val(),
            "jl52":$(objArr[63]).val(),
            "bz52":$(objArr[64]).val(),
            "jyjg6":$(objArr[65]).val(),
            "jl6":$(objArr[66]).val(),
            "bz6":$(objArr[67]).val(),
            "jyjg71":$(objArr[68]).val(),
            "jl71":$(objArr[69]).val(),
            "bz71":$(objArr[70]).val(),
            "jyjg72":$(objArr[71]).val(),
            "jl72":$(objArr[72]).val(),
            "bz72":$(objArr[73]).val(),
            "jyjg73" :$(objArr[74]).val(),
            "jl73":$(objArr[75]).val(),
            "bz73":$(objArr[76]).val(),
            "jyjg8":$(objArr[77]).val(),
            "jl8":$(objArr[78]).val(),
            "bz8":$(objArr[79]).val(),
            "jyjg91":$(objArr[80]).val(),
            "jl91":$(objArr[81]).val(),
            "bz91":$(objArr[82]).val(),
            "jyjg92":$(objArr[83]).val(),
            "jl92":$(objArr[84]).val(),
            "bz92":$(objArr[85]).val(),
            "jyjg93":$(objArr[86]).val(),
            "jl93":$(objArr[87]).val(),
            "bz93": $(objArr[88]).val(),
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addbasket_keep",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");

        }
    })
   
    }
}