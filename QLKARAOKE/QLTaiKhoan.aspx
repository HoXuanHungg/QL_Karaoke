<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="QLTaiKhoan.aspx.cs" Inherits="QLKARAOKE.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="/css/main.css">
    <div>
 <h4 class="tieude">Tài khoản</h4>
            <table style="width:40%" class="table">
                <tr>
                    <td>Tên tài khoản</td>
                    <td>
                        <asp:TextBox ID="txtTenTK" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mật khẩu</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox></td>
                </tr>
                
            </table>
            <div class="div">
            <asp:Button class="button" ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
            <asp:Button class="button" ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
            </div>
            <h3 class="tieude">Danh sách tài khoản</h3>
            <div class="Gridview">
            <asp:GridView ID="GridTK" runat="server" class="mydatagrid table" AutoGenerateColumns="False" OnRowDeleting="GridTK_RowDeleting" OnSelectedIndexChanged="GridTK_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="TENTK" HeaderText="Tên tài khoản" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="MATKHAU" HeaderText="Password" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>                   
                    <asp:CommandField ButtonType="Link" SelectText="Chọn" ShowSelectButton="true" />
                    <asp:CommandField ButtonType="Link" DeleteText="Xóa" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
        </div> 
</asp:Content>
