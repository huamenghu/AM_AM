function test() {
    var isok = false;
    if ($("#wtcompany").val() == "") {
        alert("委托单位不能为空");
        $("#wtcompany").focus();
    } else {
        if ($("#ypname").val() == "") {
            alert("样品名称不能为空");
            $("#ypname").focus();
        } else {
            if ($("#scstore").val() == "") {
                alert("制造厂商不能为空");
                $("#scstore").focus();
            } else {
                if ($("#type").val() == "") {
                    alert("型号/规格不能为空");
                    $("#type").focus();
                } else {
                    if ($("#cccode").val() == "") {
                        alert("出厂编号不能为空");
                        $("#cccode").focus();
                    } else {
                        if ($("#jydate").val() == "") {
                            alert("接样日期不能为空");
                            $("#jydate").focus();
                        } else {
                            if ($("#checkyj").val() == "") {
                                alert("检验依据不能为空");
                                $("#checkyj").focus();
                            } else {
                                if ($("#checkend").val() == "") {
                                    alert("检验结论不能为空");
                                    $("#checkend").focus();
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
    var textareas = $("textarea");
    
    var json = {
        "safe_lock": [{
            "Guid": "",
            "CreateDate": "",
            "userid": userid,
            "WTDW": $(objArr[0]).val(),
            "YPMC": $(objArr[1]).val(),
            "ZZCS": $(objArr[2]).val(),
            "XHGG": $(objArr[3]).val(),
            "CCBH": $(objArr[4]).val(),
            "JYRQ": $(objArr[5]).val(),
            "JYYJ": $(textareas[0]).val(),
            "JYJL": $(textareas[1]).val()
        }]
    };
    $.ajax({
        type: "post",
        url: "/AppM/addsafe_lock",
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
    }
}