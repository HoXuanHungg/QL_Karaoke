<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="QLPhong.aspx.cs" Inherits="QLKARAOKE.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/css/main.css">
    <div>
            <h4 class="tieude">Phòng</h4>
            <table style="width:40%" class="table">
                <tr>
                    <td>Mã Phòng</td>
                    <td>
                        <asp:TextBox ID="txtMaPhong" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tên Phòng</td>
                    <td>
                        <asp:TextBox ID="txtTenPhong" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Giá phòng</td>
                    <td>
                   <asp:TextBox ID="txtGiaPhong" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Trạng thái</td>
                    <td>
                        <asp:RadioButtonList ID="rbnTrangThai" runat="server">
                            <asp:ListItem Text="Còn trống" Value="Còn trống"></asp:ListItem>
                            <asp:ListItem Text="Đang sử dụng" Value="Đang sử dụng"></asp:ListItem>
                        </asp:RadioButtonList>
                     </td>
                </tr>
                
            </table>
            <div class="table">
            <asp:Button class="button" ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
            <asp:Button class="button" ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
            
            </div>
            <h3 class="tieude">Danh sách phòng</h3>
            <div class="Gridview">
            <asp:GridView ID="GridP" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridP_RowDeleting" OnSelectedIndexChanged="GridP_SelectedIndexChanged" class="mydatagrid">
                <Columns>
                    <asp:BoundField DataField="MaPhong" HeaderText="Mã phòng">
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TenPhong" HeaderText="Tên phòng">
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="GiaPhong" HeaderText="Giá phòng" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="tinhTrang" HeaderText="Trạng thái">
                        <ItemStyle Width="30%" />
                    </asp:BoundField>                    
                    <asp:CommandField ButtonType="Link" SelectText="Chọn" ShowSelectButton="true" />
                    <asp:CommandField ButtonType="Link" DeleteText="Xóa" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
        </div> 
</asp:Content>
