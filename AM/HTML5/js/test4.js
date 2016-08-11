function test(){
	if($("#qm").val()==""){
		alert("委托单位名称不能为空");
		$("#qm").focus();
	}else{
		if($("#qd").val()==""){
			alert("委托单位地址不能为空");
			$("#qd").focus();
		}else{
			if($("#lxr").val()==""){
				alert("联系人不能为空");
				$("#lxr").focus();
			}else{
				if($("#tel").val()==""){
					alert("联系电话不能为空");
					$("#tel").focus();
				}else{
					if($("#gcname").val()==""){
						alert("工程名称不能为空");
						$("#gcname").focus();
					}else{
						if($("#gcaddress").val()==""){
							alert("工程地址不能为空");
							$("#gcaddress").focus();
						}else{
							if($("#sgcompany").val()==""){
								alert("施工单位不能为空");
								$("#sgcompany").focus();
							}else{
								if($("#sgaddress").val()==""){
									alert("施工地址不能为空");
									$("#sgaddress").focus();
								}else{
									if($("#checknumber").val()==""){
										alert("检验数量不能为空");
										$("#checknumber").focus();
									}else{
										var obj=document.getElementsByName("checkbox_name");
										var b =false;
										for(var i=0;i< obj.length;i++){
											if(obj[i].checked){
												b = true;
											}
										}
										if(b==false){
											alert("检验内容至少选择一个");//提示信息自己修改
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