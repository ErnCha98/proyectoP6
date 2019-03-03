<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MantenimientoMateriales.aspx.cs" Inherits="WebEcoMonedas.MantenimientoMateriales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <asp:Label ID="lblMensaje" runat="server" CssClass="alert alert-dismissible alert-warning" Visible="false" Text=""></asp:Label>
    </div>

    <div class="row">
        <h2>Regestro de materiales de reciclaje</h2>

        <div class="form-group row">


            <div class="form-group row">
                <asp:Label ID="Label1" runat="server" Text="Color que representa"></asp:Label>
                <asp:DropDownList ID="ddlColor" runat="server" CssClass="form-control"
                    ItemType=""
                    SelectMethod="" DataTextField=""
                    DataValueField="">
                </asp:DropDownList>
            </div>

            <label for="txtNombre" class="control-label">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                runat="server"
                ErrorMessage="El nombre es requerido"
                ControlToValidate="txtNombre"
                ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                runat="server"
                ErrorMessage="El nombre solo puede contener letras"
                ControlToValidate="txtNombre"
                ValidationExpression="[ A-Za-zñÑäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙ.-]+"></asp:RegularExpressionValidator>
        </div>

        <div class="form-group row">
            <label for="txtPrecio" class="control-label">Precio</label>
            <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator3"
                runat="server" Text="* Precio Requerido."
                ControlToValidate="txtPrecio"
                SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator
                ID="RegularExpressionValidator1"
                runat="server"
                Text="* El precio solo debe contener números"
                ControlToValidate="txtPrecio" SetFocusOnError="True"
                Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
        </div>

    </div>


</asp:Content>
