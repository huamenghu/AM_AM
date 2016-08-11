/*购物车弹出*/
 jQuery('.share_btn').click(function(event) {
        jQuery('.guide_mask').fadeIn('fast',function(){
            jQuery(this).click(function(event) {
                jQuery(this).fadeOut('fast');
				jQuery('.share_btn_show').stop().animate({bottom: '-1000px'}, "slow");
            });
        });
		jQuery(this).parents('.share_parent').siblings('.share_btn_show').stop().animate({bottom: '-0px'}, "slow");
    });
	
	/*分享弹出*/
	
	 jQuery('.share_btn2').click(function(event) {
        jQuery('.guide_mask').fadeIn('fast',function(){
            jQuery(this).click(function(event) {
                jQuery(this).fadeOut('fast');
				jQuery('.share_btn_show2').stop().animate({bottom: '-80px'}, "slow");
            });
        });
		jQuery(this).parents('.share_parent2').siblings('.share_btn_show2').stop().animate({bottom: '0px'}, "slow");
    });
		
		
/*性别*/
	
	 jQuery('.share_btn3').click(function(event) {
        jQuery('.guide_mask').fadeIn('fast',function(){
            jQuery(this).click(function(event) {
                jQuery(this).fadeOut('fast');
				jQuery('.share_btn_show3').stop().animate({bottom: '-80px'}, "slow");
            });
        });
		jQuery(this).parents('.share_parent3').siblings('.share_btn_show3').stop().animate({bottom: '0px'}, "slow");
    });		 