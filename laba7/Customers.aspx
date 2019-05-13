<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="laba7.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Fullname<asp:TextBox ID="fullNameTextBox" runat="server" CssClass="create-customer-input"></asp:TextBox>
    Age<asp:TextBox ID="ageTextBox" runat="server" CssClass="create-customer-input" TextMode="Number"></asp:TextBox>
    Gender<asp:TextBox ID="genderTextBox" runat="server" CssClass="create-customer-input"></asp:TextBox>
    Job<asp:TextBox ID="jobTextBox" runat="server" CssClass="create-customer-input"></asp:TextBox>
    Weight<asp:TextBox ID="weightTextBox" runat="server" TextMode="Number" CssClass="create-customer-input"></asp:TextBox>
    Width<asp:TextBox ID="widthTextBox" runat="server" TextMode="Number" CssClass="create-customer-input"></asp:TextBox>
    Passport<asp:TextBox ID="PassportTextBox" runat="server" CssClass="create-customer-input"></asp:TextBox>
    Nationality<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="name" DataValueField="id" CssClass="create-customer-input">
</asp:DropDownList>
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ASP_7ConnectionString %>" SelectCommand="SELECT * FROM [Nationalities]"></asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ASP_7ConnectionString %>" SelectCommand="SELECT [name] FROM [Nationalities]"></asp:SqlDataSource>
<asp:Button ID="CreateButton" runat="server" OnClick="CreateButton_Click" Text="Create" />
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="5" DataKeyNames="Id" Height="176px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="840px">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" />
        <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
        <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
        <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
        <asp:BoundField DataField="Job" HeaderText="Job" SortExpression="Job" />
        <asp:BoundField DataField="Width" HeaderText="Width" SortExpression="Width" />
        <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Weight" />
        <asp:BoundField DataField="Passport" HeaderText="Passport" SortExpression="Passport" />
        <asp:BoundField DataField="NationalityId" HeaderText="NationalityId" SortExpression="NationalityId" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASP_7ConnectionString %>" SelectCommand="SELECT * FROM [Customers]" DeleteCommand="DELETE FROM [Customers] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Customers] ([FullName], [Age], [Gender], [Job], [Width], [Weight], [Passport], [NationalityId]) VALUES (@FullName, @Age, @Gender, @Job, @Width, @Weight, @Passport, @NationalityId)" UpdateCommand="UPDATE [Customers] SET [FullName] = @FullName, [Age] = @Age, [Gender] = @Gender, [Job] = @Job, [Width] = @Width, [Weight] = @Weight, [Passport] = @Passport, [NationalityId] = @NationalityId WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="FullName" Type="String" />
        <asp:Parameter Name="Age" Type="Int32" />
        <asp:Parameter Name="Gender" Type="String" />
        <asp:Parameter Name="Job" Type="String" />
        <asp:Parameter Name="Width" Type="Int32" />
        <asp:Parameter Name="Weight" Type="Int32" />
        <asp:Parameter Name="Passport" Type="String" />
        <asp:Parameter Name="NationalityId" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="FullName" Type="String" />
        <asp:Parameter Name="Age" Type="Int32" />
        <asp:Parameter Name="Gender" Type="String" />
        <asp:Parameter Name="Job" Type="String" />
        <asp:Parameter Name="Width" Type="Int32" />
        <asp:Parameter Name="Weight" Type="Int32" />
        <asp:Parameter Name="Passport" Type="String" />
        <asp:Parameter Name="NationalityId" Type="Int32" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
