 function mTabs(thisObj, Num) {
            if (thisObj.className == "tab-1 over") return;
            var tabList = document.getElementById("myTab").getElementsByTagName("p");
            for (i = 0; i < tabList.length; i++) {//点击之后，其他tab变成灰色，内容隐藏，只有点击的tab和内容有属性
                if (i == Num) {
                    thisObj.className = "tab-1 over";
                    document.getElementById("myTab_Content" + i).style.display = "block";
                } else {
                    tabList[i].className = "tab-1";
                    document.getElementById("myTab_Content" + i).style.display = "none";
                }
            }
        }
		
		
		
function nTabs(thisObj, Num) {
            if (thisObj.className == "tab-2 over2") return;
            var tabList = document.getElementById("myTab2").getElementsByTagName("p");
            for (i = 0; i < tabList.length; i++) {//点击之后，其他tab变成灰色，内容隐藏，只有点击的tab和内容有属性
                if (i == Num) {
                    thisObj.className = "tab-2 over2";
                    document.getElementById("myTab2_Content" + i).style.display = "block";
                } else {
                    tabList[i].className = "tab-2";
                    document.getElementById("myTab2_Content" + i).style.display = "none";
                }
            }
        }
		
	 