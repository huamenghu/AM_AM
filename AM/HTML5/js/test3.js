function add(){
//	添加 企业工程技术和专业管理人员名单


									var divElement=document.createElement("div");
									
									var labelElement1=document.createElement("span")
									var inputElement1=document.createElement("span")
									var inputElement11=document.createElement("br")
									var inputElement111=document.createElement("br")
									
									var labelElement2=document.createElement("span")
									var inputElement2=document.createElement("span")
									var inputElement22=document.createElement("br")
									var inputElement222=document.createElement("br")
									
									var labelElement3=document.createElement("span")
									var inputElement3=document.createElement("span")
									var inputElement33=document.createElement("br")
									var inputElement333=document.createElement("br")
									
									var labelElement4=document.createElement("span")
									var inputElement4=document.createElement("span")
									var inputElement44=document.createElement("br")
									var inputElement444=document.createElement("br")
									
									var labelElement5=document.createElement("span")
									var inputElement5=document.createElement("span")
									var inputElement55=document.createElement("br")
									var inputElement555=document.createElement("br")
									
									var labelElement6=document.createElement("span")
									var inputElement6=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var labelElement7=document.createElement("span")
									var inputElement7=document.createElement("span")
									var inputElement77=document.createElement("br")
									var inputElement777=document.createElement("br")
									
									inputElement1.innerHTML+="<style>input{width:100%;min-height:34px;font-size:14px; padding-left:15px;color:#999999; padding-top:0px;padding-bottom:0px;margin-bottom:0;border-radius:5px;outline:none;border:1px solid #cccccc;}input:focus{border:1px solid #66AFE9;box-shadow: 0 0 10px #66AFE9}</style><input mtype='1' type='text' id='t1'  placeholder='序号' onclick='ob()'>";
									inputElement11.innerHTML="<br/>";
									labelElement1.innerHTML="<label>序号</label>";
									inputElement111.innerHTML="<br/>";
									
									inputElement2.innerHTML = "<input  mtype='1'  type='text' placeholder='姓名'>";
									inputElement22.innerHTML="<br/>";
									labelElement2.innerHTML="<label>姓名</label>";
									inputElement222.innerHTML="<br/>";
									
									inputElement3.innerHTML = "<input mtype='1'  type='text'  placeholder='职务'>"
									inputElement33.innerHTML="<br/>";
									labelElement3.innerHTML="<label>职务</label>";
									inputElement333.innerHTML="<br/>";
									
									inputElement4.innerHTML = "<input mtype='1'  type='text'  placeholder='职称'>"
									inputElement44.innerHTML="<br/>";
									labelElement4.innerHTML="<label>职称</label>";
									inputElement444.innerHTML="<br/>";
									
									inputElement6.innerHTML = "<input mtype='1'  type='text'  placeholder='学历'>"
									inputElement66.innerHTML="<br/>";
									labelElement6.innerHTML="<label>学历</label>";
									inputElement666.innerHTML="<br/>";
									
									inputElement7.innerHTML = "<input mtype='1'  type='text' placeholder='专业'>"
									inputElement77.innerHTML="<br/>";
									labelElement7.innerHTML="<label>专业</label>";
									inputElement777.innerHTML="<br/>";
									
									inputElement5.innerHTML = "<input mtype='1'  type='text'  placeholder='身份证号'>"
									inputElement55.innerHTML="<br/>";
									labelElement5.innerHTML="<label>身份证号</label>";
									inputElement555.innerHTML="<br/>";
								
								divElement.appendChild(labelElement1);
								divElement.appendChild(inputElement11);
								divElement.appendChild(inputElement1);
								divElement.appendChild(inputElement111);
								
								divElement.appendChild(labelElement2);
								divElement.appendChild(inputElement222);
								divElement.appendChild(inputElement2);
								divElement.appendChild(inputElement22);
								
								divElement.appendChild(labelElement3);
								divElement.appendChild(inputElement333);
								divElement.appendChild(inputElement3);
								divElement.appendChild(inputElement33);
								
								divElement.appendChild(labelElement4);
								divElement.appendChild(inputElement444);
								divElement.appendChild(inputElement4);
								divElement.appendChild(inputElement44);
								
								divElement.appendChild(labelElement6);
								divElement.appendChild(inputElement666);
								divElement.appendChild(inputElement6);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(labelElement7);
								divElement.appendChild(inputElement777);
								divElement.appendChild(inputElement7);
								divElement.appendChild(inputElement77);
								
								divElement.appendChild(labelElement5);
								divElement.appendChild(inputElement555);
								divElement.appendChild(inputElement5);
								divElement.appendChild(inputElement55);
								
									var a=document.getElementById("addafter");
									a.appendChild(divElement);
	window.event.returnValue=false;
	return false;
}
function add2(){
	//	添加专业技术工人名单
	var divElement=document.createElement("div");
									var xuhaolabel=document.createElement("span")
									var xuhaoinput=document.createElement("span")
									var inputElement11=document.createElement("br")
									var inputElement111=document.createElement("br")
									
									var namelabel=document.createElement("span")
									var nameinput=document.createElement("span")
									var inputElement22=document.createElement("br")
									var inputElement222=document.createElement("br")
//									
									var gongzhonglabel=document.createElement("span")
									var gongzhonginput=document.createElement("span")
									var inputElement33=document.createElement("br")
									var inputElement333=document.createElement("br")
//									
									xuhaoinput.innerHTML += "<style>input{width:100%;min-height:34px;font-size:14px; padding-left:15px;color:#999999; padding-top:0px;padding-bottom:0px;margin-bottom:0;border-radius:5px;outline:none;border:1px solid #cccccc;}input:focus{border:1px solid #66AFE9;box-shadow: 0 0 10px #66AFE9}</style><input mtype='2'  type='text' id='t1'  placeholder='序号' onclick='ob()'>";
									inputElement11.innerHTML="<br/>";
									xuhaolabel.innerHTML="<label>序号</label>";
									inputElement111.innerHTML="<br/>";
									
									nameinput.innerHTML = "<input mtype='2'  type='text'placeholder='姓名'>";
									inputElement22.innerHTML="<br/>";
									namelabel.innerHTML="<label>姓名</label>";
									inputElement222.innerHTML="<br/>";

									gongzhonginput.innerHTML = "<input mtype='2'  type='text'placeholder='工种'>"
									inputElement33.innerHTML="<br/>";
									gongzhonglabel.innerHTML="<label>工种</label>";
									inputElement333.innerHTML="<br/>";
									
								divElement.appendChild(xuhaolabel);
								divElement.appendChild(inputElement11);
								divElement.appendChild(xuhaoinput);
								divElement.appendChild(inputElement111);
								
								divElement.appendChild(namelabel);
								divElement.appendChild(inputElement222);
								divElement.appendChild(nameinput);
								divElement.appendChild(inputElement22);

								divElement.appendChild(gongzhonglabel);
								divElement.appendChild(inputElement333);
								divElement.appendChild(gongzhonginput);
								divElement.appendChild(inputElement33);
									
									var a=document.getElementById("addafter2");
									a.appendChild(divElement);
	window.event.returnValue=false;
	return false;

}
function add3(){
	//	添加资格证书
	var divElement=document.createElement("div");
	
									var jglabel=document.createElement("span")
									var jginput=document.createElement("span")
									var inputElement44=document.createElement("br")
									var inputElement444=document.createElement("br")
									
									var bhlabel=document.createElement("span")
									var bhinput=document.createElement("span")
									var inputElement55=document.createElement("br")
									var inputElement555=document.createElement("br")
									
									var yxqlabel=document.createElement("span")
									var yxqinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									jginput.innerHTML = "<style>input{width:100%;min-height:34px;font-size:14px; padding-left:15px;color:#999999; padding-top:0px;padding-bottom:0px;margin-bottom:0;border-radius:5px;outline:none;border:1px solid #cccccc;}input:focus{border:1px solid #66AFE9;box-shadow: 0 0 10px #66AFE9}</style><input mtype='3'  type='text'placeholder='发证机构'>"
									inputElement44.innerHTML="<br/>";
									jglabel.innerHTML="<label>发证机构</label>";
									inputElement444.innerHTML="<br/>";
									
									bhinput.innerHTML = "<input mtype='3'  type='text'placeholder='证书编号'>"
									inputElement55.innerHTML="<br/>";
									bhlabel.innerHTML="<label>证书编号</label>";
									inputElement555.innerHTML="<br/>";
									
									yxqinput.innerHTML = "<input mtype='3'  type='text' placeholder='有效期'>"
									inputElement66.innerHTML="<br/>";
									yxqlabel.innerHTML="<label>有效期</label>";
									inputElement666.innerHTML="<br/>";
									
								divElement.appendChild(jglabel);
								divElement.appendChild(inputElement444);
								divElement.appendChild(jginput);
								divElement.appendChild(inputElement44);
								
								divElement.appendChild(bhlabel);
								divElement.appendChild(inputElement555);
								divElement.appendChild(bhinput);
								divElement.appendChild(inputElement55);
								
								divElement.appendChild(yxqlabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(yxqinput);
								divElement.appendChild(inputElement66);
								
								var a=document.getElementById("addafter3");
									a.appendChild(divElement);
	window.event.returnValue=false;
	return false;
}
function add4(){
	//	添加吊篮维修与检测用仪器设备
	var divElement=document.createElement("div");
	
									var xhlabel=document.createElement("span")
									var xhinput=document.createElement("span")
									var inputElement44=document.createElement("br")
									var inputElement444=document.createElement("br")
									
									var sbnamelabel=document.createElement("span")
									var sbnameinput=document.createElement("span")
									var inputElement55=document.createElement("br")
									var inputElement555=document.createElement("br")
									
									var gglabel=document.createElement("span")
									var gginput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var numberlabel=document.createElement("span")
									var numberinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var bzlabel=document.createElement("span")
									var bzinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									xhinput.innerHTML = "<style>input{width:100%;min-height:34px;font-size:14px; padding-left:15px;color:#999999; padding-top:0px;padding-bottom:0px;margin-bottom:0;border-radius:5px;outline:none;border:1px solid #cccccc;}input:focus{border:1px solid #66AFE9;box-shadow: 0 0 10px #66AFE9}</style><input mtype='4'  type='text'placeholder='序号'>"
									inputElement44.innerHTML="<br/>";
									xhlabel.innerHTML="<label>序号</label>";
									inputElement444.innerHTML="<br/>";
									
									sbnameinput.innerHTML = "<input mtype='4'  type='text'placeholder='仪器设备名称'>"
									inputElement55.innerHTML="<br/>";
									sbnamelabel.innerHTML="<label>仪器设备名称</label>";
									inputElement555.innerHTML="<br/>";
									
									gginput.innerHTML = "<input mtype='4'  type='text' placeholder='型号/规格'>"
									inputElement66.innerHTML="<br/>";
									gglabel.innerHTML="<label>型号/规格</label>";
									inputElement666.innerHTML="<br/>";
									
									numberinput.innerHTML = "<input mtype='4'  type='text' placeholder='数量（台）'>"
									inputElement66.innerHTML="<br/>";
									numberlabel.innerHTML="<label>数量（台）</label>";
									inputElement666.innerHTML="<br/>";
									
									bzinput.innerHTML = "<input mtype='4'  type='text' placeholder='备注'>"
									inputElement66.innerHTML="<br/>";
									bzlabel.innerHTML="<label>备注</label>";
									inputElement666.innerHTML="<br/>";
									
								divElement.appendChild(xhlabel);
								divElement.appendChild(inputElement444);
								divElement.appendChild(xhinput);
								divElement.appendChild(inputElement44);
								
								divElement.appendChild(sbnamelabel);
								divElement.appendChild(inputElement555);
								divElement.appendChild(sbnameinput);
								divElement.appendChild(inputElement55);
								
								divElement.appendChild(gglabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(gginput);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(numberlabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(numberinput);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(bzlabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(bzinput);
								divElement.appendChild(inputElement66);
								
								var a=document.getElementById("addafter4");
									a.appendChild(divElement);
	window.event.returnValue=false;
	return false;
}
function add5(){
	//	添加主要工程业绩一览表
	var divElement=document.createElement("div");
	
									var xhlabel=document.createElement("span")
									var xhinput=document.createElement("span")
									var inputElement44=document.createElement("br")
									var inputElement444=document.createElement("br")
									
									var gcnamelabel=document.createElement("span")
									var gcnameinput=document.createElement("span")
									var inputElement55=document.createElement("br")
									var inputElement555=document.createElement("br")
									
									var numberlabel=document.createElement("span")
									var numberinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var moneylabel=document.createElement("span")
									var moneyinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var timelabel=document.createElement("span")
									var timeinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var bzlabel=document.createElement("span")
									var bzinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									xhinput.innerHTML = "<style>input{width:100%;min-height:34px;font-size:14px; padding-left:15px;color:#999999; padding-top:0px;padding-bottom:0px;margin-bottom:0;border-radius:5px;outline:none;border:1px solid #cccccc;}input:focus{border:1px solid #66AFE9;box-shadow: 0 0 10px #66AFE9}</style><input mtype='5'  type='text' placeholder='序号'>"
									inputElement44.innerHTML="<br/>";
									xhlabel.innerHTML="<label>序号</label>";
									inputElement444.innerHTML="<br/>";
									
									gcnameinput.innerHTML = "<input mtype='5'  type='text' placeholder='工程项目名称'>"
									inputElement55.innerHTML="<br/>";
									gcnamelabel.innerHTML="<label>工程项目名称</label>";
									inputElement555.innerHTML="<br/>";
									
									numberinput.innerHTML = "<input mtype='5'  type='text' placeholder='租赁吊篮台数'>"
									inputElement66.innerHTML="<br/>";
									numberlabel.innerHTML="<label>租赁吊篮台数</label>";
									inputElement666.innerHTML="<br/>";
									
									moneyinput.innerHTML = "<input mtype='5'  type='text' placeholder='租金总额（万元）'>"
									inputElement66.innerHTML="<br/>";
									moneylabel.innerHTML="<label>租金总额（万元）</label>";
									inputElement666.innerHTML="<br/>";
									
									timeinput.innerHTML = "<input mtype='5'  type='text' placeholder='开竣/工时间'>"
									inputElement66.innerHTML="<br/>";
									timelabel.innerHTML="<label>开竣/工时间</label>";
									inputElement666.innerHTML="<br/>";
									
									bzinput.innerHTML = "<input mtype='5'  type='text' placeholder='备注'>"
									inputElement66.innerHTML="<br/>";
									bzlabel.innerHTML="<label>备注</label>";
									inputElement666.innerHTML="<br/>";
									
								divElement.appendChild(xhlabel);
								divElement.appendChild(inputElement444);
								divElement.appendChild(xhinput);
								divElement.appendChild(inputElement44);
								
								divElement.appendChild(gcnamelabel);
								divElement.appendChild(inputElement555);
								divElement.appendChild(gcnameinput);
								divElement.appendChild(inputElement55);
								
								divElement.appendChild(numberlabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(numberinput);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(moneylabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(moneyinput);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(timelabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(timeinput);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(bzlabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(bzinput);
								divElement.appendChild(inputElement66);
								
								var a=document.getElementById("addafter5");
									a.appendChild(divElement);
	window.event.returnValue=false;
	return false;
}
function add6(){
	//	添加出租用高处作业吊篮一览表
	var divElement=document.createElement("div");
	
									var xhlabel=document.createElement("span")
									var xhinput=document.createElement("span")
									var inputElement44=document.createElement("br")
									var inputElement444=document.createElement("br")
									
									var gglabel=document.createElement("span")
									var gginput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var namelabel=document.createElement("span")
									var nameinput=document.createElement("span")
									var inputElement55=document.createElement("br")
									var inputElement555=document.createElement("br")
									
									var datelabel=document.createElement("span")
									var dateinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var cjlabel=document.createElement("span")
									var cjinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									var numberlabel=document.createElement("span")
									var numberinput=document.createElement("span")
									var inputElement66=document.createElement("br")
									var inputElement666=document.createElement("br")
									
									xhinput.innerHTML = "<style>input{width:100%;min-height:34px;font-size:14px; padding-left:15px;color:#999999; padding-top:0px;padding-bottom:0px;margin-bottom:0;border-radius:5px;outline:none;border:1px solid #cccccc;}input:focus{border:1px solid #66AFE9;box-shadow: 0 0 10px #66AFE9}</style><input  mtype='6'  type='text' placeholder='序号'>"
									inputElement44.innerHTML="<br/>";
									xhlabel.innerHTML="<label>序号</label>";
									inputElement444.innerHTML="<br/>";
									
									gginput.innerHTML = "<input mtype='6'  type='text' placeholder='型号'>"
									inputElement66.innerHTML="<br/>";
									gglabel.innerHTML="<label>型号</label>";
									inputElement666.innerHTML="<br/>";
									
									nameinput.innerHTML = "<input mtype='6'  type='text'  placeholder='名称'>"
									inputElement55.innerHTML="<br/>";
									namelabel.innerHTML="<label>名称</label>";
									inputElement555.innerHTML="<br/>";
									
									dateinput.innerHTML = "<input mtype='6'  type='text' placeholder='出厂日期'>"
									inputElement66.innerHTML="<br/>";
									datelabel.innerHTML="<label>出厂日期</label>";
									inputElement666.innerHTML="<br/>";
									
									cjinput.innerHTML = "<input mtype='6'  type='text' placeholder='吊篮制造厂家'>"
									inputElement66.innerHTML="<br/>";
									cjlabel.innerHTML="<label>吊篮制造厂家</label  >";
									inputElement666.innerHTML="<br/>";
									
									numberinput.innerHTML = "<input mtype='6'  type='text'  placeholder='数量'>"
									inputElement66.innerHTML="<br/>";
									numberlabel.innerHTML="<label>数量</label>";
									inputElement666.innerHTML="<br/>";
									
								divElement.appendChild(xhlabel);
								divElement.appendChild(inputElement444);
								divElement.appendChild(xhinput);
								divElement.appendChild(inputElement44);
								
								divElement.appendChild(gglabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(gginput);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(namelabel);
								divElement.appendChild(inputElement555);
								divElement.appendChild(nameinput);
								divElement.appendChild(inputElement55);
								
								divElement.appendChild(datelabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(dateinput);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(cjlabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(cjinput);
								divElement.appendChild(inputElement66);
								
								divElement.appendChild(numberlabel);
								divElement.appendChild(inputElement666);
								divElement.appendChild(numberinput);
								divElement.appendChild(inputElement66);
								
								var a=document.getElementById("addafter6");
									a.appendChild(divElement);
	window.event.returnValue=false;
	return false;
}
function test(){
	if($("#qm").val()==""){
		alert("企业名称不能为空");
		$("#qm").focus();
	}else{
		if($("#qd").val()==""){
			alert("企业地址不能为空");
			$("#qd").focus();
		}else{
			if($("#yb").val()==""){
				alert("邮编不能为空");
				$("#yb").focus();
			}else{
				if($("#zzjgdm").val()==""){
					alert("组织机构代码不能为空");
					$("#zzjgdm").focus();
				}else{
					if($("#lxr").val()==""){
						alert("联系人不能为空");
						$("#lxr").focus();
					}else{
						if($("#tel").val()==""){
							alert("固定电话不能为空");
							$("#tel").focus();
						}else{
							if($("#mobile").val()==""){
								alert("移动电话不能为空");
								$("#mobile").focus();
							}else{
								if($("#email").val()==""){
									alert("电子邮箱不能为空");
									$("#email").focus();
								}else{
									if($("#fax").val()==""){
										alert("传真不能为空");
										$("#fax").focus();
									}else{
										if($("#license").val()==""){
											alert("营业执照注册号不能为空");
											$("#license").focus();
										}else{
											if($("#date").val()==""){
												alert("注册日期不能为空");
												$("#date").focus();
											}else{
												if($("#organ").val()==""){
													alert("营业执照登记机构不能为空");
													$("#organ").focus();
												}else{
													if($("#type").val()==""){
														alert("经济类型不能为空");
														$("#type").focus();
													}else{
														if($("#money").val()==""){
															alert("注册资金不能为空");
															$("#money").focus();
														}else{
															if($("#fa").val()==""){
																alert("固定资产不能为空");
																$("#fa").focus();
															}else{
																if($("#dlpeople").val()==""){
																	alert("从事吊篮业务人数不能为空");
																	$("#dlpeople").focus();
																}else{
																	if($("#people").val()==""){
																	alert("企业职工总人数不能为空");
																	$("#people").focus();
																	}else{
																		if($("#dlnumber").val()==""){
																			alert("出租用吊篮数量不能为空");
																			$("#dlnumber").focus();
																		}else{
																			if($("#dldate").val()==""){
																				alert("开始从事吊篮业务日期不能为空");
																				$("#dldate").focus();
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

