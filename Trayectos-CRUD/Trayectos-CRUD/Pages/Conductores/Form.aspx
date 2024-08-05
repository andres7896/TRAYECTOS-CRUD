<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Trayectos_CRUD.Pages.Conductores.Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <form runat="server" class="row g-2 mx-3 mt-3">
        <article class="col-md-12 d-flex justify-content-start align-items-center gap-3">
            <asp:LinkButton runat="server" ID="btnVolver" OnClick="Volver">
                <i class="bi bi-chevron-left icon-info bg-primary"></i>
            </asp:LinkButton>
            <h2>Formulario Conductores</h2>
        </article>
        <article class="col-md-3">
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputNombre"></asp:TextBox>
                <label for="inputNombre">Nombre</label>
            </div>
        </article>
        <article class="col-md-3">
            <div class="form-floating ">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputApellido"></asp:TextBox>
                <label for="inputApellido">Apellido</label>
            </div>
        </article>
        <article class="col-md-2">
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputDocumento"></asp:TextBox>
                <label for="inputDocumento">Documento</label>
            </div>
        </article>
        <article class="col-md-2">
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputCelular"></asp:TextBox>
                <label for="inputCelular">Celular</label>
            </div>
        </article>
        <article class="col-md-2">
            <asp:Button runat="server" CssClass="btn btn-success w-100 h-100" ID="btnCreate" Text="Guardar" OnClick="Post" Visible="false"/>
            <asp:Button runat="server" CssClass="btn btn-success w-100 h-100" ID="btnUpdate" Text="Editar" OnClick="Put" Visible="false"/>
        </article>
    </form>
</asp:Content>
