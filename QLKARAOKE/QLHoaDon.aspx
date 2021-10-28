<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="QLHoaDon.aspx.cs" Inherits="QLKARAOKE.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="/css/main.css">
    <div>
            <h4 class="tieude">Hóa đơn bán hàng</h4>
            <table style="width:40%" class="table">
                <tr>
                    <td class="auto-style1">Mã hóa đơn</td>
                    <td>
                        <asp:TextBox ID="txtMaDon" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1">Mã khách hàng</td>
                    <td>
                        <asp:TextBox ID="txtMaKhachHang" runat="server"></asp:TextBox></td>
                </tr>
                
                    <tr>
                    <td class="auto-style1">Mã Phòng</td>
                    <td><asp:TextBox ID="txtMaPhong" runat="server"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td class="auto-style1">Tổng tiền</td>
                    <td>
                        <asp:TextBox ID="txtGia" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td class="auto-style1">Thời gian sử dụng</td>
                    
                    <td><asp:TextBox ID="txtThoiGianDung" runat="server"></asp:TextBox></td>                  
                </tr>
            </table>

            <div class="btnGiaoDienNgoai">

            <asp:Button class="button" ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
            <asp:Button class="button" ID="btnSua" runat="server" Text="Sửa" />
            
            </div>
            <h3 class="tieude">Danh sách hóa đơn</h3>
            <div class="Gridview">
            <asp:GridView ID="GridHD" runat="server" OnSelectedIndexChanged="GridHD_SelectedIndexChanged" OnRowDeleting="GridHD_RowDeleting" AutoGenerateColumns="False" class="mydatagrid">
                <Columns>
                    <asp:BoundField DataField="MaDon" HeaderText="Mã hóa đơn" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="MaKH" HeaderText="Mã khách hàng" ReadOnly="true" >
                        <ItemStyle Width="10%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="MaPhong" HeaderText="Mã Phòng" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="GiaPhong" HeaderText="Tổng tiền" ReadOnly="true" >
                        <ItemStyle Width="40%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ThoiGianDung" HeaderText="Thời gian sử dụng" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:CommandField ButtonType="Link" SelectText="Chọn" ShowSelectButton="true" />
                    <asp:CommandField ButtonType="Link" DeleteText="Xóa" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>    
    </div>
</asp:Content>
