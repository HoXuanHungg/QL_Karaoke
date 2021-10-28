<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="QLKARAOKE.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="/css/main.css">
    <h4 class="tieude">Danh sách phòng</h4>
    <asp:GridView class="mydatagrid" ID="GridP" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridP_SelectedIndexChanged" >
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
                    <asp:BoundField DataField="TinhTrang" HeaderText="Trạng thái">
                        <ItemStyle Width="30%" />
                    </asp:BoundField>
                    <asp:CommandField ButtonType="Link" SelectText="Sử dụng" ShowSelectButton="true" />
                </Columns>
            </asp:GridView>
</asp:Content>
