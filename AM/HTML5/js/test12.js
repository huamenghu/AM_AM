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
									if($("#azdate").val()==""){
										alert("安装告知日期不能为空");
										$("#azdate").focus();
									}else{
										if($("#cccode").val()==""){
											alert("出厂编号不能为空");
											$("#cccode").focus();
										}else{
											if($("#xkzcode").val()==""){
												alert("制造许可证编号不能为空");
												$("#xkzcode").focus();
											}else{
												if($("#ccdate").val()==""){
													alert("出厂日期不能为空");
													$("#ccdate").focus();
												}else{
													if($("#bacode").val()==""){
														alert("备案编号不能为空");
														$("#bacode").focus();
													}else{
														if($("#maxweight").val()==""){
															alert("最大额定起重量不能为空");
															$("#maxweight").focus();
														}else{
															if($("#edlj").val()==""){
																alert("额定力矩不能为空");
																$("#edlj").focus();
															}else{
																if($("#maxspeed").val()==""){
																	alert("小车最大变幅速度不能为空");
																	$("#maxspeed").focus();
																}else{
																	if($("#stnumber").val()==""){
																		alert("标准节规格/数量不能为空");
																		$("#stnumber").focus();
																	}else{
																		if($("#checkheight").val()==""){
																			alert("检验时安装高度不能为空");
																			$("#checkheight").focus();
																		}else{
																			if($("#maxrange").val()==""){
																				alert("最大幅度/安装幅度不能为空");
																				$("#maxrange").focus();
																			}else{
																				if($("#yxheight").val()==""){
																					alert("允许独立高度/允许自由端高度不能为空");
																					$("#yxheight").focus();
																				}else{
																					if($("#checkspace").val()==""){
																						alert("检验时安装附着道数/间距不能为空");
																						$("#checkspace").focus();
																					}else{
																						if($("#wallheight").val()==""){
																							alert("第一道附墙高度不能为空");
																							$("#wallheight").focus();
																						}else{
																							if($("#checktype").val()==""){
																								alert("检验类别不能为空");
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
function add(){
	//	添加主要检验仪器设备
	var divElement=document.createElement("div");
									var namelabel=document.createElement("span")
									var nameinput=document.createElement("span")
									var inputElement11=document.createElement("br")
									var inputElement111=document.createElement("br")
									
									var typelabel=document.createElement("span")
									var typeinput=document.createElement("span")
									var inputElement22=document.createElement("br")
									var inputElement222=document.createElement("br")
//									
									var codelabel=document.createElement("span")
									var codeinput=document.createElement("span")
									var inputElement33=document.createElement("br")
									var inputElement333=document.createElement("br")
									
									var statelabel=document.createElement("span")
									var stateinput=document.createElement("span")
									var inputElement33=document.createElement("br")
									var inputElement333=document.createElement("br")
//									
									nameinput.innerHTML+="<style>input{width:100%;min-height:34px;font-size:14px; padding-left:15px;color:#999999; padding-top:0px;padding-bottom:0px;margin-bottom:0;border-radius:5px;outline:none;border:1px solid #cccccc;}input:focus{border:1px solid #66AFE9;box-shadow: 0 0 10px #66AFE9}</style><input type='text' id='t1'  placeholder='仪器（工具）名称' onclick='ob()'>";
									inputElement11.innerHTML="<br/>";
									namelabel.innerHTML="<label>仪器（工具）名称</label>";
									inputElement111.innerHTML="<br/>";
									
									typeinput.innerHTML="<input type='text' placeholder='型号'>";
									inputElement22.innerHTML="<br/>";
									typelabel.innerHTML="<label>型号</label>";
									inputElement222.innerHTML="<br/>";

									codeinput.innerHTML="<input type='text' placeholder='编号'>"
									inputElement33.innerHTML="<br/>";
									codelabel.innerHTML="<label>编号</label>";
									inputElement333.innerHTML="<br/>";
									
									stateinput.innerHTML="<input type='text' placeholder='状态'>"
									inputElement33.innerHTML="<br/>";
									statelabel.innerHTML="<label>状态</label>";
									inputElement333.innerHTML="<br/>";
									
								divElement.appendChild(namelabel);
								divElement.appendChild(inputElement11);
								divElement.appendChild(nameinput);
								divElement.appendChild(inputElement111);
								
								divElement.appendChild(typelabel);
								divElement.appendChild(inputElement222);
								divElement.appendChild(typeinput);
								divElement.appendChild(inputElement22);

								divElement.appendChild(codelabel);
								divElement.appendChild(inputElement333);
								divElement.appendChild(codeinput);
								divElement.appendChild(inputElement33);
								
								divElement.appendChild(statelabel);
								divElement.appendChild(inputElement333);
								divElement.appendChild(stateinput);
								divElement.appendChild(inputElement33);
									
									var a=document.getElementById("addafter");
									a.appendChild(divElement);
	window.event.returnValue=false;
	return false;
}
