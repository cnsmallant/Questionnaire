﻿var str = "";
var opid = "";
var cou = $("#cou");
var SubmitVote = $("#SubmitVote");
SubmitVote.click(function () {
    if (opid == "") {
        alert("请选择选项！");
    }
    else {
        var legs = opid.split(',');
        var leg = legs.length;
        var c = cou.val();

        if (leg >= c) {
            $.ajax({
                url: "/m/Home/Vote",
                type: 'POST',
                contentType: 'application/json',
                data: JSON.stringify(
                    {
                        OptionId: opid
                    }),
                dataType: "JSON",
                success: function (data) {
                    if (data == "NO") {
                        alert("提交失败");
                        return;
                    } else if (data == "OK") {
                        alert("提交成功");
                        window.location.href = location.href+"#pl";
                    } else if (data == "N") {
                        alert("活动已结束，详情请致电0631-5208177 ");
                    }
                }
            });
        } else {
            alert("所有选项必选！");
        }
    }
});
///选项
function select(id) {
    str += id + ",";
    opid = arrayReplace(str);
}
///去除重复
function arrayReplace(str) {
    var strArray = str.split(',');
    for (var i = 0, s; s = strArray[i]; i++) {
        var j = 0;
        str = str.replace(new RegExp(s, 'g'), function (a, b, c, d) {
            if (!j) {
                j++;
                return a;
            } else {
                return '';
            }
        })
    }
    return str;
}

var mask = $("#mask");
var dialogMove = $("#dialogMove");
var closebutton = $("#closebutton");
var lj = $("#lj");
mask.hide();
dialogMove.hide();
closebutton.click(function () {
    mask.hide();
    dialogMove.hide();
});
var tj = $("#tj");
tj.click(function () {
    mask.show();
    dialogMove.show();
});

var mask2 = $("#mask2");
var dialogMove2 = $("#dialogMove2");
var closebutton2 = $("#closebutton2");
var lj = $("#lj");
mask2.hide();
dialogMove2.hide();
closebutton2.click(function () {
    mask2.hide();
    dialogMove2.hide();
    window.location.reload();

});


var regphone = /^((\d{11})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)$/;
var PapersId = $("#PapersId");
var SubmitComment = $("#SubmitComment");
var CommentDepict = $("#CommentDepict");
var UserName = $("#UserName");
var UserPhone = $("#UserPhone");
SubmitComment.click(function () {
    if (CommentDepict.val() == null || CommentDepict.val() == "") {
        alert("请输入您的意见！");
    } else if (textfilter("CommentDepict")) {
        alert("您输入的内容有敏感字符！");
    } else if (CommentDepict.val().length < 20) {
        alert("您输入的内容小于20字！");
    } else if (CommentDepict.val().length > 300) {
        alert("您输入的内容大于300字！");
    } else if (UserPhone.val() == null || UserPhone.val() == "") {
        alert("请输入您的手机号码！");
    } else if (!UserPhone.val().match(regphone)) {
        alert("您输入的手机号码格式不正确");
    } else if (UserName.val() == null || UserName.val() == "") {
        alert("请输入您的真实姓名！");
    } else if (textfilter("UserName")) {
        alert("您输入的内容有敏感字符！");
    } else if (UserName.val().length < 2) {
        alert("您的姓名小于2个字");
    }
    else {
        $.ajax({
            url: "/m/Home/Comment",
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(
                {
                    CommentDepict: CommentDepict.val(),
                    UserPhone: UserPhone.val(),
                    UserName: UserName.val(),
                    PapersId: PapersId.val()
                }),
            dataType: "JSON",
            success: function (data) {
                if (data == "NO") {
                    alert("提交失败");
                    return;
                } else if (data == "YUSER") {
                    alert("您已经发表过意见了，请勿重复发表！");
                }
                else {
                    mask.hide();
                    dialogMove.hide();
                    alert("提交成功!");
                    mask2.show();
                    dialogMove2.show();
                    lj.val(data);
                }
            }
        });
    }
});

function textfilter(val) {
    var results = false;
    var obj = document.getElementById(val);
    var kw = "TG,tg,xijinping,习近平,胡锦涛,hujintao,法论功,台独,港独,藏独,东突,邪教,潜规则,测,试,管理员,admin,Admin,sys,system,共产党,政府,FUCK,fuck,艹,日,TMD,tmd,test,TEST,@@,贷,嫖,娼,福利,av,AV,妓,鸡,货,86,yp,约,炮"; //要屏蔽的关键词,多个请用英文输入法状态下的逗号
    var tempKw = kw.split(",")
    if (tempKw.length >= 1) {
        for (i = 0; i < tempKw.length; i++) {
            if (obj.value.indexOf(tempKw[i]) >= 0) {
                results = true;
                break; //退出循环
            }
        }
    }
    return results;
}

var host = document.domain;
///点赞
function Laud(id) {
    $.ajax({
        url: "/m/Home/Laud",
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(
            {
                CommentId: id,
                PapersId: PapersId.val(),
                host: host
            }),
        dataType: "JSON",
        success: function (data) {
            if (data == "N") {
                alert("点赞失败");
                return;
            } else if (data == "Y") {
                alert("您已经点赞，请勿重复点赞！");
            } else if (data == "C") {
                alert("非威海市用户点赞已经上限！");
            } else if (data == "E") {
                alert("活动已结束，详情请致电0631-5208177 ");
            } else if (data == "W") {
                alert("您的操作违法");
            }
            else {
                alert("点赞成功");
                var l = document.getElementById(id + "land");
                l.innerText = data;
            }
        }
    });
}