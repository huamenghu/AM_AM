﻿//[javascript] view plaincopyprint?
/*  
 * To change this template, choose Tools | Templates 
 * and open the template in the editor. 
 */

/** 
 * Author : ____′↘夏悸 
 * Easyui KindEditor的简单扩展. 
 * 有了这个之后,你就可以像使用Easyui组件的方式使用KindEditor了 
 * 前提是你需要导入KindEditor的核心js和相关样式. 本插件也需要在Easyui.min和KindEditor之后导入. 
 * 呵呵..没做深入扩展了,简单实现了一下功能,架子已经搭好.有需要的筒子可以在这基础上扩展. 
 **/
var kindeditor;
(function ($, K) {
    if (!K)
        throw "KindEditor未定义!";

    function create(target) {
        var opts = $.data(target, 'kindeditor').options;
        //var editor = K.create(target, opts);  
        kindeditor = K.create(target, opts);
        $.data(target, 'kindeditor').options.editor = kindeditor;
    }

    $.fn.kindeditor = function (options, param) {
        if (typeof options == 'string') {
            var method = $.fn.kindeditor.methods[options];
            if (method) {
                return method(this, param);
            }
        }
        options = options || {};
        return this.each(function () {
            var state = $.data(this, 'kindeditor');
            if (state) {
                $.extend(state.options, options);
            } else {
                state = $.data(this, 'kindeditor', {
                    options: $.extend({}, $.fn.kindeditor.defaults, $.fn.kindeditor.parseOptions(this), options)
                });
            }
            create(this);
        });
    }

    $.fn.kindeditor.parseOptions = function (target) {
        return $.extend({}, $.parser.parseOptions(target, []));
    };

    $.fn.kindeditor.methods = {
        editor: function (jq) {
            return $.data(jq[0], 'kindeditor').options.editor;
        }
    };

    $.fn.kindeditor.defaults = {
        resizeType: 1,
        uploadJson: '/content/kindeditor/asp.net/upload_json.ashx',
        fileManagerJson: '/content/kindeditor/asp.net/file_manager_json.ashx',
        //items : [  
        //    'source', '|', 'undo', 'redo', '|', 'preview', 'print', 'template', 'code', 'cut', 'copy', 'paste',  
        //'plainpaste', 'wordpaste', '|', 'justifyleft', 'justifycenter', 'justifyright',  
        //'justifyfull', 'insertorderedlist', 'insertunorderedlist', 'indent', 'outdent', 'subscript',  
        //'superscript', 'clearhtml', 'quickformat', 'selectall', '|', 'fullscreen', '/',  
        //'formatblock', 'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold',  
        //'italic', 'underline', 'strikethrough', 'lineheight', 'removeformat', '|', 'image', 'multiimage',  
        //'flash', 'media', 'insertfile', 'table', 'hr', 'emoticons', 'baidumap', 'pagebreak',  
        //'anchor', 'link', 'unlink', '|', 'about'],  
        items: [
            'source', '|', 'undo', 'redo', '|', 'preview', 'print', 'template', 'code', 'cut', 'copy', 'paste',
        'plainpaste', 'wordpaste', '|', 'justifyleft', 'justifycenter', 'justifyright',
        'justifyfull', 'insertorderedlist', 'insertunorderedlist', 'indent', 'outdent', 'subscript',
        'superscript', 'clearhtml', 'quickformat', 'selectall', '/',
        'formatblock', 'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold',
        'italic', 'underline', 'strikethrough', 'lineheight', 'removeformat', '|', 'image', 'multiimage',
        'flash', 'media', 'insertfile', 'table', 'hr', 'emoticons', 'baidumap', 'pagebreak',
        'anchor', 'link', 'unlink'],
        afterChange: function () {
            this.sync();//这个是必须的,如果你要覆盖afterChange事件的话,请记得最好把这句加上.  
        }
    };
    $.parser.plugins.push("kindeditor");
})(jQuery, KindEditor);