<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="QLKARAOKE.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>
    <style>
        *{
    padding: 0px;
    margin: 0px;
    font-family: sans-serif;
    box-sizing: border-box;
}
header{
    background-color: #cccccc;
    min-height: 70px;
    padding: 15px;
}
main{
    background-color: #dddddd;
    min-height: 300px;
    padding: 7.5px 15px;
}
footer{
    background-color: #cccccc;
    min-height: 70px;
    padding: 15px;
}
.container{
    width: 100%;
    max-width: 1200px;
    margin-left: auto;
    margin-right: auto;
}
.login-form{
    width: 100%;
    max-width: 400px;
    margin: 20px auto;
    background-color: #ffffff;
    padding: 15px;
    border: 2px dotted #cccccc;
    border-radius: 10px;
}
h1{
    color: #009999;
    font-size: 30px;
    margin-bottom: 30px;
}
.input-box{
    margin-bottom: 10px;
}
.input-box input{
    padding: 7.5px 15px;
    width: 100%;
    border: 1px solid #cccccc;
    outline: none;
}

.btn-box{
    background-color: #009999;
    border: none;
    color: white;
    padding: 7.5px 15px;
    text-align: right;
    margin-right:0 auto;
    border-radius: 2px;
    display: inline-block;
    font-size: 20px;
    font-family: Arial;
    font-weight: bold;
    cursor: pointer;
}
    </style>
</head>
 <body>
 
       
            <div class="container" style="width:40%" >
            <div class="login-form">
                <form id="form1" runat="server">
                    <h1>Đăng nhập</h1>
                    <div class="input-box">
                        <i ></i>
                        <asp:TextBox CssClass="input-box" ID="txtTentaikhoan" runat="server" placeholder="Tài khoản"></asp:TextBox>
                    </div>
                    <div class="input-box">
                        <i ></i>
                       <asp:TextBox CssClass="input-box" ID="txtPassword" TextMode="Password" placeholder="Mật khẩu" runat="server"  ></asp:TextBox>
                    </div>
                    <div class="btn-box">
                        <asp:Button class="btn-box" ID="btDangnhap" runat="server" OnClick="btDangnhap_Click" Text="Đăng nhập"  />
                    </div>
                </form>
            </div>
            </div>

    </body>
</html>
