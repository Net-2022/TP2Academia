<%@ Page Title="Log In" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Home" %>

<html xmlns="http://www.w3.org//199//xhtml">
    <head runat ="server">
        <title>LogIn</title>
        <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css"/>
        <link href="~/Login/Login.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
        <h1 class="text-bg-primary text-center border-top border-dark">La Academia</h1>           
        <form id="bodyForm" runat="server">
            <div class="center-container container w-40 text-center p-2 form-background">
                  <!-- Email input -->
                 <div class="d-flex p-2 ">
                    <asp:Label ID="lblNombre" runat="server" Text="Usuario: " CssClass="flex-fill flex-shrink-0 align-self-center p-sm-2 fixed-width"/>
                    <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control flex-fill"/>
                 </div>
                <br />

                  <!-- Password input -->
                  <div class="d-flex p-2">
                    <label class="flex-fill flex-shrink-0 align-self-center p-sm-2 fixed-width">Contraseña: </label>
                    <asp:TextBox runat="server" type="password" id="txtContraseña" class="form-control flex-fill" />
                  </div>
                    <br />
                  <asp:Label runat="server" ID="lblWarning" CssClass="text-bg-warning"/>
                    <div class="col">
                      <!-- Simple link -->
                      <asp:Button runat="server" ID="btnAyuda" Text="Ayuda?" CssClass="btn btn-info" OnClick="Unnamed2_Click"/>
                    </div>
                    <br />
                  <!-- Submit button -->
                  <asp:Button runat="server" ID="btnLoguearse" class="btn btn-primary btn-block mb-4" Text="Log In" OnClick="btnLoguearse_Click"/>
            </div>
        </form>
    </body>
</html>
