function test(){
	if($("#gcname").val()==""){
		alert("工程名称不能为空");
		$("#gcname").focus();
	}else{
		if($("#projectaddress").val()==""){
			alert("项目地址不能为空");
			$("#projectaddress").focus();
		}else{
			if($("#cqcompany").val()==""){
				alert("设备产权单位不能为空");
				$("#cqcompany").focus();
			}else{
				if($("#fzrtel").val()==""){
					alert("产权单位负责人及电话不能为空");
					$("#fzrtel").focus();
				}else{
					if($("#azcompany").val()==""){
						alert("安装单位不能为空");
						$("#azcompany").focus();
					}else{
						if($("#zzcompany").val()==""){
							alert("设备制造单位不能为空");
							$("#zzcompany").focus();
						}else{
							if($("#dj").val()==""){
								alert("等级不能为空");
								$("#dj").focus();
							}else{
								if($("#code").val()==""){
									alert("编号不能为空");
									$("#code").focus();
								}else{
									if($("#type").val()==""){
										alert("型号不能为空");
										$("#type").focus();
									}else{
										if($("#jjcode").val()==""){
											alert("建鉴号不能为空");
											$("#jjcode").focus();
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


