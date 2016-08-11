function test() {
    if ($("#tes1").val() == "") {
        $("#tes1")[0].focus();
        alert("姓名不能为空");
    } else {
        if ($("#tes2").val() == "") {
            $("#tes2")[0].focus();
            alert("文化程度不能为空");
        } else {
            if ($("#tes3").val() == "") {
                $("#tes3")[0].focus();
                alert("联系电话不能为空");
            } else {
                if ($("#tes4").val() == "") {
                    $("#tes4")[0].focus();
                    alert("专业工龄不能为空");
                } else {
                    if ($("#tes5").val() == "") {
                        $("#tes5")[0].focus();
                        alert("身体状况不能为空");
                    } else {
                        if ($("#tes6").val() == "") {
                            $("#tes6")[0].focus();
                            alert("身份证号不能为空");
                        } else {
                            if ($("#tes7").val() == "") {
                                $("#tes7")[0].focus();
                                alert("工作单位不能为空");
                            } else {
                                if ($("#tes8").val() == "") {
                                    $("#tes8")[0].focus();
                                    alert("邮编不能为空");
                                } else {
                                    if ($("#tes9").val() == "") {
                                        $("#tes9")[0].focus();
                                        alert("邮箱不能为空");
                                    } else {
                                        if ($("#tes10").val() == "") {
                                            $("#tes10")[0].focus();
                                            alert("本人签字不能为空");
                                        } else {
                                            var obj = document.getElementsByName("checkbox_name");//根据自己的多选框名称修改下
                                            var b = false;
                                            for (var i = 0; i < obj.length; i++) {
                                                if (obj[i].checked) {
                                                    b = true;
                                                }
                                            }
                                            if (b == false) {
                                                alert("选择培训点至少选择一个");//提示信息自己修改
                                            }
                                            return b;
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
    //var check = test();
    //if (check)
    //{
    var userid = $("#userid").val();
    var objArr = $("input[type=text]")
    debugger;
    var checkitem = $("input[name=checkbox_name]:checked");
    var radios = $("input[name=sex]:checked");
    var xb = $(radios[0]).next("label").text();
    var textareas = $("textarea");
    var pxd = "";
    for (var i = 0; i < checkitem.length; i++) {
        
        pxd += $(checkitem[i]).parent("label").text().trim();
        if (i < checkitem.length) {
            pxd += ","
        }
    }
    var json = {
        "basket_train": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "xm": $(objArr[0]).val(),
            "xb": xb,
            "whcd": $(objArr[1]).val(),
            "lxdh": $(objArr[2]).val(),
            "zygl": $(objArr[3]).val(),
            "stzk": $(objArr[4]).val(),
            "sfzh": $(objArr[5]).val(),
            "gzdw": $(objArr[6]).val(),
            "yb": $(objArr[7]).val(),
            "yx": $(objArr[8]).val(),
            "brqz": $(objArr[9]).val(),
            "pxd": pxd,
            "gzjl": $(textareas[0]).val(),
            "szdwyj": $(textareas[1]).val()
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addbasket_train",
        data: { obj: JSON.stringify(json) },
        success: function (data) {
            layer.msg("提交成功");
            //alert("哈哈" + data);
            //debugger;
            //data = eval('(' + data + ')');

        }
    })
    //$.ajax({
    //    type: "POST",     
    //    contentType: "application/json; charset=utf-8",  
    //    dataType: "json",   
    //    url: "/AppM/addbasket_train",   
    //    data: "RID:" + json,
    //    success: function (data) {
    //        alert(data.b);       
    //    },
    //    error: function (err) { //如果执行不成功，那么执行此方法
    //        alert("err:" + err);
    //    }
    //});
    //}
}