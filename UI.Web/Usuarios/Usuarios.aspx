<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceholder" runat="server" >
    <link type="text/css" rel="stylesheet" href="~/Usuarios/Usuarios.css" />
    <br />
    <br />
    <br />
    <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" CellPadding="5" HorizontalAlign="Center">
       <Columns>
           <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
           <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
           <asp:BoundField HeaderText="Email" DataField="Email" />
           <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
           <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
           <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
       </Columns>
    </asp:GridView>
    
    <asp:Panel ID="gridActionPanel" runat="server" Height="50px" HorizontalAlign="Center">
        <br />
        <asp:LinkButton ID="btnEditar" runat="server" OnClick="btnEditar_Click">Editar</asp:LinkButton>
        &nbsp;&nbsp;
        <asp:LinkButton ID="btnEliminar" runat="server" OnClick="btnEliminar_Click">Eliminar</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnNuevo" runat="server" OnClick="btnNuevo_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <div class="container">

    <asp:Panel ID="formPanel" Visible="false" runat="server">
        
        <asp:Label ID="lblNombre" runat="server" Text="Nombre: " />
        <asp:TextBox ID="txtNombre" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre" ControlToValidate="txtNombre" runat="server" ErrorMessage="El Nombre es requerido."></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="lblApellido" runat="server" Text="Apellido: " />
        <asp:TextBox ID="txtApellido" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorApellido" runat="server" ControlToValidate="txtApellido"   ErrorMessage="El Apellido es requerido."></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="lblEmail" runat="server" Text="Email: " />
        <asp:TextBox ID="txtEmail" runat="server" CausesValidation="true" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" ControlToValidate="txtEmail" runat="server" ErrorMessage="El Email es requerido."></asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidatorEmail" ControlToValidate="txtEmail" OnServerValidate="ValidateEmail" runat="server" ErrorMessage="El Email no es valido."/>
        <br />

        <asp:Label ID="lblHabilitado" runat="server" Text="Habilitado: " />
        <asp:CheckBox ID="chkHabilitado" runat="server" />
        <br />

        <asp:Label ID="lblNombreUsuario" runat="server" Text="Usuario: " />
        <asp:TextBox ID="txtNombreUsuario" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombreUsuario" controlToValidate="txtNombreUsuario" runat="server" ErrorMessage="El Nombre de Usuario es requerido."></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="lblClave" runat="server" Text="Clave: " />
        <asp:TextBox ID="txtClave" TextMode="Password" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorClave" controlToValidate="txtClave" runat="server" ErrorMessage="La clave es requerida."></asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidatorClave" controlToValidate="txtClave" OnServerValidate="ValidatePassword" runat="server" ErrorMessage="La Clave no es valida."></asp:CustomValidator>
        <br />

        <asp:Label ID="lblRepetirClave" runat="server" Text="Repetir clave: " />
        <asp:TextBox ID="txtRepetirClave" TextMode="Password" runat="server" />
        <asp:CompareValidator ID="CompareValidatorPassword" ControlToValidate="txtRepetirClave" ControlToCompare="txtClave" runat="server" ErrorMessage="Las contraseñas no coinciden." CssClass="warningText"></asp:CompareValidator>
        <br />
        <br />

        <asp:Panel ID="formActionPanel" runat="server" Height="50px">
            <br />
            <asp:LinkButton ID="btnAceptar" runat="server" OnClick="btnAceptar_Click"  CausesValidation="true">Aceptar</asp:LinkButton>
            &nbsp;&nbsp;
            <asp:LinkButton ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" CausesValidation="false">Cancelar</asp:LinkButton>
        </asp:Panel>

    </asp:Panel>
    
    </div>
</asp:Content>
