function test(){
	if($("#gcname").val()==""){
		alert("工程名称不能为空");
		$("#gcname").focus();
	}else{
		if($("#sycompany").val()==""){
			alert("使用单位不能为空");
			$("#sycompany").focus();
		}else{
			if($("#sgaddress").val()==""){
				alert("施工地点不能为空");
				$("#sgaddress").focus();
			}else{
				if($("#jlcompany").val()==""){
					alert("监理单位不能为空");
					$("#jlcompany").focus();
				}else{
					if($("#azcompany").val()==""){
						alert("安装单位不能为空");
						$("#azcompany").focus();
					}else{
						if($("#azpeople").val()==""){
							alert("安装负责人不能为空");
							$("#azpeople").focus();
						}else{
							if($("#sbname").val()==""){
								alert("设备名称不能为空");
								$("#sbname").focus();
							}else{
								if($("#type").val()==""){
								alert("设备型号不能为空");
								$("#type").focus();
							}else{
								if($("#zzcompany").val()==""){
									alert("制造单位不能为空");
									$("#zzcompany").focus();
								}else{
									if($("#xkzcode").val()==""){
										alert("制造许可证号不能为空");
										$("#xkzcode").focus();
									}else{
										if($("#cccode").val()==""){
											alert("出厂编号不能为空");
											$("#cccode").focus();
										}else{
											if($("#azdate").val()==""){
												alert("安装告知日期不能为空");
												$("#azdate").focus();
											}else{
												if($("#ccdate").val()==""){
													alert("出厂日期不能为空");
													$("#ccdate").focus();
												}else{
													if($("#bacode").val()==""){
														alert("备案编号不能为空");
														$("#bacode").focus();
													}else{
														if($("#edweigth").val()==""){
															alert("额定载重量不能为空");
															$("#edweigth").focus();
														}else{
															if($("#dlquality").val()==""){
																alert("吊笼质量不能为空");
																$("#dlquality").focus();
															}else{
																if($("#edspeed").val()==""){
																	alert("额定提升速度不能为空");
																	$("#edspeed").focus();
																}else{
																	if($("#aqqtype").val()==""){
																		alert("防坠安全器型式不能为空");
																		$("#aqqtype").focus();
																	}else{
																		if($("#dzquality").val()==""){
																			alert("对重质量不能为空");
																			$("#dzquality").focus();
																		}else{
																			if($("#checkheight").val()==""){
																				alert("检验时安装高度不能为空");
																				$("#checkheight").focus();
																			}else{
																				if($("#zydheight").val()==""){
																					alert("自由端高度不能为空");
																					$("#zydheight").focus();
																				}else{
																					if($("#wallspace").val()==""){
																						alert("附墙道数/间距不能为空");
																						$("#wallspace").focus();
																					}else{
																						if($("#wallheight").val()==""){
																							alert("第一道附墙高度不能为空");
																							$("#wallheight").focus();
																						}else{
																							if($("#stnumber").val()==""){
																								alert("标准节规格/数量不能为空");
																								$("#stnumber").focus();
																							}else{
																								if($("#stnumber").val()==""){
																									alert("标准节规格/数量不能为空");
																									$("#stnumber").focus();
																								}else{
																									if($("#checktype").val()==""){
																										alert("检验类型不能为空");
																										$("#checktype").focus();
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
					}
				}
			}
		}
	}
}