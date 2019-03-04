<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MantenimeintoUsuarios.aspx.cs" Inherits="EcoMonedasWeb.MantenimeintoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <asp:Label ID="lblMensaje" runat="server" CssClass="alert alert-dismissible alert-warning" Visible="false" Text=""></asp:Label>
    </div>

    <div class="row">

         

        <div class="col-lg-4 offset-lg-1">

              <h2>Registro de Usuarios</h2>


   

            <div class="form-group row">
                <label for="txtNombre" class="control-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>

            </div>

             <div class="form-group row">
                <label for="txt" class="control-label">Correo electronico</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>


             <div class="form-group row">
                <label for="txtPrecio" class="control-label">Telefono:</label>
                <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>        
            </div>

            <div class="form-group row">
                <label for="txtDireccion" class="control-label">Dirección:</label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

              <div class="form-group row">
                <label for="txt" class="control-label">Contraseña:</label>
                <asp:TextBox ID="txtContraUno" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group row">
                <label for="txt" class="control-label">Confirmación de contraseña:</label>
                <asp:TextBox ID="txtContraDos" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
     

             <asp:Button CssClass="btn btn-success" ID="btnGuardar"  Text="Guardar usuario" runat="server"
             ></asp:Button>


        </div>
    </div>

    <!---->

    
</asp:Content>
