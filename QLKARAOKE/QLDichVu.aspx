<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="QLDichVu.aspx.cs" Inherits="QLKARAOKE.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="/css/main.css">
    <div>
            <h4 class="tieude">Dịch Vụ</h4>
            <table style="width:40%" class="table">
                <tr>
                    <td>Mã dịch vụ</td>
                    <td>
                        <asp:TextBox ID="txtMaDV" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tên dịch vụ</td>
                    <td>
                        <asp:TextBox ID="txtTenDichVu" runat="server"></asp:TextBox></td>
                </tr>
               
                <tr>
                    <td>Đơn giá</td>
                    <td>
                        <asp:TextBox ID="txtDonGia" runat="server"></asp:TextBox></td>
                </tr>
                
            </table>
            <div class="btnGiaoDienNgoai">
            <asp:Button class="button" ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
            <asp:Button class="button" ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
            
            </div>
            <h3 class="tieude">Danh sách dịch vụ</h3>

            <div class="Gridview">
            <asp:GridView ID="GridDV" runat="server"  class="mydatagrid" OnSelectedIndexChanged="GridDV_SelectedIndexChanged" OnRowDeleting="GridDV_RowDeleting" AutoGenerateColumns="False" Width="637px" >
                <Columns>
                    <asp:BoundField DataField="MaDV" HeaderText="Mã dịch vụ" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TenDV" HeaderText="Tên dịch vụ" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="DonGia" HeaderText="Đơn giá" ReadOnly="true" >
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:CommandField ButtonType="Link" SelectText="Chọn" ShowSelectButton="true" />
                    <asp:CommandField ButtonType="Link" DeleteText="Xóa" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
        </div> 
</asp:Content>
