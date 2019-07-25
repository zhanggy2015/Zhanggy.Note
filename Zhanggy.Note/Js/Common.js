
//移入移除
var initTip = function (dataText, selector) {
    $(selector).focus(function () {
        $(this).removeClass("gray");
        if ($(this).val() == dataText) {
            $(this).val("");
        }
    }).blur(function () {
        if ($(this).val() == "") {
            $(this).val(dataText);
        }
        if ($(this).val() == dataText) {
            $(this).addClass("gray");
        } else {
            $(this).removeClass("gray");
        }
    });
}

//延迟n秒执行某函数
var delay = function (fn, n) {
    var openTimer = null;
    openTimer = setTimeout(function () {
        clearTimeout(openTimer);
        fn();
    }, n);
}