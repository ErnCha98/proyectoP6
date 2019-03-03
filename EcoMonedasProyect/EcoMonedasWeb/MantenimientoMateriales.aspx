<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MantenimientoMateriales.aspx.cs" Inherits="EcoMonedasWeb.MantenimientoMateriales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <asp:Label ID="lblMensaje" runat="server" CssClass="alert alert-dismissible alert-warning" Visible="false" Text=""></asp:Label>
    </div>

    <div class="row">

        <div class="col-lg-4 offset-lg-1">

            <h2>Registro de materiales reciclables</h2>

            <div class="form-group row">
                <asp:Label ID="Label1" runat="server" Text="Tipo"></asp:Label>
                <asp:DropDownList ID="ddlMateriales" runat="server" CssClass="form-control"
                    ItemType=""
                    SelectMethod="" DataTextField=""
                    DataValueField="">
                </asp:DropDownList>
            </div>

            <div class="form-group row">
                <label for="txtNombre" class="control-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
          
            </div>

            <div class="form-group row">
                <label for="txtPrecio" class="control-label">Precio</label>
                <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server"></asp:TextBox>
               
              
            </div>


            <div class="form-group row">
                <label for="archivoImagen" class="control-label">Imagen</label>
                <asp:FileUpload ID="archivoImagen" CssClass="form-control-file" runat="server" />
               
            </div>

            <div class="form-group row">
                <asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server"
                    Text="Guardar" OnClick="btnGuardar_Click" />
            </div>
            <asp:HiddenField ID="hiddenID" runat="server" />


        </div>

        <div class="col-lg-6 offset-lg-1">
            <!-- Listado -->
            <h2>Lista de materiales</h2>
            <asp:GridView ID="grvListado" runat="server" CssClass="table table-hover"
                 AutoGenerateColumns="False"
                DataKeyNames=""
                OnSelectedIndexChanged="grvListado_SelectedIndexChanged">

               
                <HeaderStyle CssClass="table-success" />
            </asp:GridView>
            <!-- Listado -->
        </div>

    </div>


</asp:Content>
