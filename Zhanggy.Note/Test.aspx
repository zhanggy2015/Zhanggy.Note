<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Zhanggy.Note.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
<script type="text/javascript">
    function click() {
        if (event.button == 2) {
            alert('禁止右键！');
        }
        if (event.button == 1) {
            alert('你好');
            setTimeout("MyClose();", 120000);
        }
    }
    document.onmousedown = click;
    function MyClose() {
        window.close();
    }
</script>
<script type="text/javascript">
    function click() {
        if (event.button == 2) {
            alert('禁止右键！');
        }
        if (event.button == 1) {
            alert('你好');
            setTimeout("MyClose();", 120000);
        }
    }
    document.onmousedown = click;
    function MyClose() {
        window.close();
    }
</script>


<form id="form" name="form">
    <input type="text" id="txt1" name="txt1" />
</form>

<script type="text/javascript">
function checkText() {
    var text = document.form1.txt1.value;
    if (text.length == 0) {
        alert("不能为空！");
        return false;
    }
    for (var i = 0; i < text.length; i++) {
        if (!(asc(text[i]) >= 48 && asc(text[i]) <= 57)) {
            alert("必须为数字！");
            return false;
        }
    }
    return true;
}

function myfunction(arg1, arg2) {
    var r;
    var n = 5;
    r = arg1 * arg2;
    return (n);
}

</script>



