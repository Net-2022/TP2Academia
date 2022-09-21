<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceholder" runat="server">
    <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
       <Columns>
           <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
           <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
           <asp:BoundField HeaderText="Email" DataField="Email" />
           <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
           <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
           <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
       </Columns>
    </asp:GridView>
    
    <asp:Panel ID="gridActionPanel" runat="server">
        <asp:LinkButton ID="btnEditar" runat="server" OnClick="btnEditar_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="btnEliminar" runat="server" OnClick="btnEliminar_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="btnNuevo" runat="server" OnClick="btnNuevo_Click">Nuevo</asp:LinkButton>
    </asp:Panel>

    <asp:Panel ID="formPanel" Visible="false" runat="server">
        
        <asp:Label ID="lblNombre" runat="server" Text="Nombre: " />
        <asp:TextBox ID="txtNombre" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtNombre" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="lblApellido" runat="server" Text="Apellido: " />
        <asp:TextBox ID="txtApellido" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtApellido"   ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="lblEmail" runat="server" Text="Email: " />
        <asp:TextBox ID="txtEmail" runat="server" CausesValidation="true" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtEmail" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidator1" ControlToValidate="txtEmail" OnServerValidate="ValidateEmail" runat="server" ErrorMessage="AA"/>
        <br />

        <asp:Label ID="lblHabilitado" runat="server" Text="Habilitado: " />
        <asp:CheckBox ID="chkHabilitado" runat="server" />
        <br />

        <asp:Label ID="lblNombreUsuario" runat="server" Text="Usuario: " />
        <asp:TextBox ID="txtNombreUsuario" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" controlToValidate="txtNombreUsuario" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="lblClave" runat="server" Text="Clave: " />
        <asp:TextBox ID="txtClave" TextMode="Password" runat="server" />
        <asp:CustomValidator ID="CustomValidator2" controlToValidate="txtClave" OnServerValidate="ValidatePassword" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
        <br />

        <asp:Label ID="lblRepetirClave" runat="server" Text="Repetir clave: " />
        <asp:TextBox ID="txtRepetirClave" TextMode="Password" runat="server" /><asp:CompareValidator ID="CompareValidator1" ControlToValidate="txtRepetirClave" ControlToCompare="txtClave" runat="server" ErrorMessage="CompareValidator"></asp:CompareValidator>
        <br />

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowSummary="true"/>
        <asp:Panel ID="formActionPanel" runat="server">
            <asp:LinkButton ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" CausesValidation="true">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" CausesValidation="false">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
    
</asp:Content>
