var uname = $("#uname");
var upwd = $("#upwd");
var submit = $("#submit");
submit.click(function () {
    if (uname.val() == null || uname.val() == "") {
        alert("请输入登录名称");
    } else if (upwd.val() == null || upwd.val() == "") {
        alert("请输入登录密码");
        flg = false;
    } else {
        $.ajax({
            url: "/Admin/login/UserLogin",
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(
                {
                    uname: uname.val(),
                    upwd: upwd.val()
                }),
            dataType: "JSON",
            success: function (data) {
                if (data == "NO") {
                    alert("登录失败");
                    return;
                } else if (data == "OK") {
                    window.location.href = "/Admin/Home/";
                }
            }
        });
    }
});