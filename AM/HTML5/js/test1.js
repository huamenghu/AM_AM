function test(){
	if($("#tes1").val()==""){
			$("#tes1")[0].focus();
			alert("姓名不能为空");
	}else{
		if($("#tes2").val()==""){
			$("#tes2")[0].focus();
			alert("文化程度不能为空");
		}else{
			if($("#tes3").val()==""){
				$("#tes3")[0].focus();
				alert("联系电话不能为空");
			}else{
				if($("#tes4").val()==""){
					$("#tes4")[0].focus();
					alert("专业工龄不能为空");
				}else{
					if($("#tes5").val()==""){
						$("#tes5")[0].focus();
						alert("身体状况不能为空");
					}else{
						if($("#tes6").val()==""){
							$("#tes6")[0].focus();
							alert("身份证号不能为空");
						}else{
							if($("#tes7").val()==""){
								$("#tes7")[0].focus();
								alert("工作单位不能为空");
							}else{
								if($("#tes8").val()==""){
									$("#tes8")[0].focus();
									alert("邮编不能为空");
								}else{
									if($("#tes9").val()==""){
										$("#tes9")[0].focus();
										alert("邮箱不能为空");
									}else{
										if($("#tes10").val()==""){
											$("#tes10")[0].focus();
											alert("本人签字不能为空");
										}else{
											var obj=document.getElementsByName("checkbox_name");//根据自己的多选框名称修改下
											var b =false;
											for(var i=0;i< obj.length;i++){
												if(obj[i].checked){
													b = true;
												}
											}
											if(b==false){
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

