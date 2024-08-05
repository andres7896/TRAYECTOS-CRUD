<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Trayectos_CRUD.Pages.Trayectos.Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <form runat="server" class="row g-2 mx-3">
        <article class="col-md-12 d-flex justify-content-start align-items-center gap-3">
            <asp:LinkButton runat="server" ID="btnVolver" OnClick="Volver">
                <i class="bi bi-chevron-left icon-info bg-primary"></i>
            </asp:LinkButton>
            <h2>Formulario Vehículos</h2>
        </article>
        <article class="col-md-3">
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputOrigen"></asp:TextBox>
                <label for="inputOrigen">Origen</label>
            </div>
        </article>
        <article class="col-md-3">
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputDestino"></asp:TextBox>
                <label for="inputDestino">Destino</label>
            </div>
        </article>
        <article class="col-md-3">
            <div class="form-floating">
                <asp:DropDownList runat="server" CssClass="form-select" ID="selectConductor"></asp:DropDownList>
                <label for="selectConductor">Conductor</label>
            </div>
        </article>
        <article class="col-md-3">
            <div class="form-floating">
                <asp:DropDownList runat="server" CssClass="form-select" ID="selectVehiculo"></asp:DropDownList>
                <label for="selectVehiculo">Vehículo</label>
            </div>
        </article>
        <article class="col-md-6">
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputValorReal"></asp:TextBox>
                <label for="inputValorReal">Valor real</label>
            </div>
        </article>
        <article class="col-md-6">
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputValorCobrado"></asp:TextBox>
                <label for="inputValorCobrado">Valor cobrado</label>
            </div>
        </article>
        <article class="col-md-6">
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ID="inputFecha" TextMode="Date"></asp:TextBox>
                <label for="inputFecha">Fecha</label>
            </div>
        </article>
        <article class="col-md-6">
            <asp:Button runat="server" CssClass="btn btn-success w-100 h-100" ID="btnCreate" Text="Guardar" Visible="false" OnClick="Post"/>
            <asp:Button runat="server" CssClass="btn btn-success w-100 h-100" ID="btnUpdate" Text="Editar" Visible="false" OnClick="Put"/>
        </article>
    </form>
</asp:Content>
