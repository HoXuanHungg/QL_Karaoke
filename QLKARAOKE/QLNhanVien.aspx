<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="QLNhanVien.aspx.cs" Inherits="QLKARAOKE.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/css/main.css">
    <div style="width:auto" >
            <h4 class="tieude">Nhân viên</h4>
            <table style="width:40%" class="table">
                <tr>
                    <td>Mã nhân viên</td>
                    <td>
                        <asp:TextBox ID="txtMaNV" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Họ Tên</td>
                    <td>
                        <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Giới tính</td>
                    <td>
                        <asp:RadioButtonList ID="rbnGioiTinh" runat="server">
                            <asp:ListItem Text="Nam" Value="Nam"></asp:ListItem>
                            <asp:ListItem Text="Nữ" Value="Nữ"></asp:ListItem>
                        </asp:RadioButtonList>
                     </td>
                </tr>
                <tr>
                    <td>Địa chỉ</td>
                    <td><asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox></td>
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
            <div class="btnGiaoDienNgoai">
            <asp:Button CssClass="button" ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
            <asp:Button CssClass="button" ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
            
            </div>
            <h3 class="tieude">Danh sách nhân viên</h3>
            <div class="Gridview">
                <asp:GridView ID="GridNV" runat="server"  Width="70%" 
                    AutoGenerateColumns="False" 
                    OnRowDeleting="GridNV_RowDeleting" 
                    OnSelectedIndexChanged="GridNV_SelectedIndexChanged"
                    class="mydatagrid">
                    <Columns>
                        <asp:BoundField DataField="MaNV" HeaderText="Mã nhân viên" >                        
                    </asp:BoundField>
                        <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" >                        
                    </asp:BoundField>
                        <asp:BoundField DataField="Gioitinh" HeaderText="Giới tính"> 
                            </asp:BoundField>
                    <asp:BoundField DataField="Diachi" HeaderText="Địa chỉ">                        
                    </asp:BoundField>
                    <asp:BoundField DataField="CMND" HeaderText="CMND" >                        
                    </asp:BoundField>
                    <asp:BoundField DataField="SDT" HeaderText="SDT">                       
                    </asp:BoundField>
                    <asp:CommandField ButtonType="Link" SelectText="Chọn" ShowSelectButton="true" />
                    <asp:CommandField ButtonType="Link" DeleteText="Xóa" ShowDeleteButton="true" />
                    </Columns>
                </asp:GridView>
         </div>
        </div>
</asp:Content>
