<%@ Page Title="Sample Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sample.aspx.cs" Inherits="WebFormsSample.Sample" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h1>Sample Page</h1>
        <asp:GridView runat="server" ID="gridViewEmployee" AutoGenerateColumns="false" OnRowDataBound="gridViewEmployee_RowDataBound" DataKeyNames="ID">
            <Columns>
                <asp:TemplateField ItemStyle-Width="100">
                    <HeaderTemplate>
                        <asp:CheckBox runat="server" ID="chkHeader" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox runat="server" ID="chkRow" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ID" HeaderText="Id" ItemStyle-Width="100" />
                <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="100" />
                <asp:BoundField DataField="City" HeaderText="City" ItemStyle-Width="100" />
            </Columns>
        </asp:GridView>

        <asp:Button ID="btnSubmit" runat="server" Text="Submit Selected Rows" OnClick="btnSubmit_Click" />

    </main>
</asp:Content>
