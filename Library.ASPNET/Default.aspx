<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Library.ASPNET._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Book Store</h1>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Book List</h2>
            <asp:Repeater ID="rpt_book_list" runat="server">
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <a href='About.aspx?zcms=<%#Eval("Id") %>'>
                            <%#Eval("Title") %></a>
                        </div>
                        <div class="panel-body">
                            <%#Eval("Description") %>
                            <p><%#Eval("Year") %></p>

                        </div>
                    </div>
                </ItemTemplate>
                <FooterTemplate>
                </FooterTemplate>
            </asp:Repeater>

        </div>


    </div>

</asp:Content>
