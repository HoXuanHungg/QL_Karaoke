<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="QLKhachHang.aspx.cs" Inherits="QLKARAOKE.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="/css/main.css">
    <div>
            <h4 class="tieude">Khách hàng</h4>
            <table style="width:40%" class="table">
                <tr>
                    <td>Mã khách hàng</td>
                    <td>
                        <asp:TextBox ID="txtMaKH" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Họ Tên</td>
                    <td>
                        <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>CMND</td>
                    <td><asp:TextBox ID="txtCMND" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>SDT</td>
                    <td><asp:TextBox ID="txtSDT" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <div>
            <asp:Button class="button" ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />

            <asp:Button class="button" ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
            </div>
            <h3 class="tieude">Danh sách khách hàng</h3>
            <div class="Gridview">
            <asp:GridView ID="GridKH"  class="mydatagrid" runat="server" OnSelectedIndexChanged="GridKH_SelectedIndexChanged" OnRowDeleting="GridKH_RowDeleting" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="MaKH" HeaderText="Mã khách" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CMND" HeaderText="CMND" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="SDT" HeaderText="SDT">
                        <ItemStyle Width="35%" />
                    </asp:BoundField>
                    <asp:CommandField ButtonType="Link" SelectText="Chọn" ShowSelectButton="true" />
                    <asp:CommandField ButtonType="Link" DeleteText="Xóa" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
        </div>
</asp:Content>
