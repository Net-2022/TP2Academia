<%@ Page Title="Home" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Home" %>

<html xmlns="http://www.w3.org//199//xhtml">
    <head runat ="server">
        <title>Academia</title>
        <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
        <h1 class="text-bg-primary text-center border-top border-dark">La Academia</h1>           
        <form id="bodyForm" runat="server">
            <div>

                    <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="250px" Width="400px" MembershipProvider="" DestinationPageUrl="~/Default.aspx">
                        <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                        <TextBoxStyle Font-Size="0.8em" />
                        <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                    </asp:Login>
            </div>
        </form>
    </body>
</html>
