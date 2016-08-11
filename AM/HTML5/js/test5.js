function test(){
	if($("#wtcompany").val()==""){
		alert("委托单位不能为空");
		$("#wtcompany").focus();
	}else{
		if($("#wtdate").val()==""){
			alert("委托日期不能为空");
			$("#wtdate").focus();
		}else{
			if($("#sycompany").val()==""){
				alert("使用单位不能为空");
				$("#sycompany").focus();
			}else{
				if($("#wttel").val()==""){
					alert("委托联系人/电话不能为空");
					$("#wttel").focus();
				}else{
					if($("#gcname").val()==""){
						alert("工程名称不能为空");
						$("#gcname").focus();
					}else{
						if($("#aztel").val()==""){
							alert("安装负责人/电话不能为空");
							$("#aztel").focus();
						}else{
							if($("#sgaddress").val()==""){
								alert("施工地点不能为空");
								$("#sgaddress").focus();
							}else{
								if($("#azdate").val()==""){
									alert("安装日期不能为空");
									$("#azdate").focus();
								}else{
									if($("#azcompany").val()==""){
										alert("安装单位不能为空");
										$("#azcompany").focus();
									}else{
										if($("#bacode").val()==""){
											alert("备案编号不能为空");
											$("#bacode").focus();
										}else{
											if($("#scstore").val()==""){
												alert("生产厂家不能为空");
												$("#scstore").focus();
											}else{
												if($("#type").val()==""){
													alert("规格型号不能为空");
													$("#type").focus();
												}else{
													if($("#sbname").val()==""){
														alert("设备名称不能为空");
														$("#sbname").focus();
													}else{
														if($("#cccode").val()==""){
															alert("出厂编号不能为空");
															$("#cccode").focus();
														}else{
															if($("#jlcompany").val()==""){
																alert("监理单位不能为空");
																$("#jlcompany").focus();
															}else{
																if($("#ctnumber").val()==""){
																	alert("检验时附着道数不能为空");
																	$("#ctnumber").focus();
																}else{
																	if($("#checkheight").val()==""){
																		alert("检验时安装高度不能为空");
																		$("#checkheight").focus();
																	}else{
																		if($("#checknumber").val()==""){
																			alert("检验数量不能为空");
																			$("#checknumber").focus();
																		}else{
																			if($("#date").val()==""){
																				alert("年 月 日不能为空");
																				$("#date").focus();
																			}else{
																				if($("#checkmoney").val()==""){
																					alert("检测费用不能为空");
																					$("#checkmoney").focus();
																				}else{
																					var obj=document.getElementsByName("checkbox_name");//根据自己的多选框名称修改下
																					var obj2=document.getElementsByName("checkbox_name2");
																					var obj3=document.getElementsByName("checkbox_name3");
																					var b =false;
																					var b2 =false;
																					var b3 =false;
																					for(var i=0;i< obj.length;i++){
																						if(obj[i].checked){
																							b = true;
																						}
																					}
																					for(var i=0;i< obj2.length;i++){
																						if(obj2[i].checked){
																							b2 = true;
																						}
																					}
																					for(var i=0;i< obj3.length;i++){
																						if(obj3[i].checked){
																							b3 = true;
																						}
																					}
																					if(b==false){
																						alert("检验类别至少选择一个");//提示信息自己修改
																					}
																					if(b2==false){
																						alert("检验依据至少选择一个");//提示信息自己修改
																					}if(b3==false){
																						alert("委托单位提交技术资料至少选择一个");//提示信息自己修改
																					}
//																					return b;
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
	}
}
