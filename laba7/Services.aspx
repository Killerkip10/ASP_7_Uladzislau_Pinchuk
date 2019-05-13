<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="laba7.Services" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Name<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
    Price<asp:TextBox ID="priceTextBox" runat="server" TextMode="Number"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    <asp:Button ID="Button2" runat="server" Height="25px" OnClick="Button2_Click" Text="Create" />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" PageSize="5">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASP_7ConnectionString %>" DeleteCommand="DELETE FROM [Services] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Services] ([Name], [Price]) VALUES (@Name, @Price)" SelectCommand="SELECT * FROM [Services]" UpdateCommand="UPDATE [Services] SET [Name] = @Name, [Price] = @Price WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
