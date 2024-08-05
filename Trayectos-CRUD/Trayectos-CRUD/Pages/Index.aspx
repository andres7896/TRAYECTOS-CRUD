<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Trayectos_CRUD.Pages.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    CRUD App
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="mx-auto p-5">
        <section class="d-flex justify-content-center align-content-center m-5">
            <h1>CRUD App</h1>
        </section>
        <section class="m-5">
            <h5 class="text-center mb-4">Hola, bienevenido a la CRUD App... esta es la pagina principal de la APP, puedes dar click a los botones de abajo para acceder a la información por que desees.
            </h5>
        </section>
        <form runat="server" class="d-flex justify-content-center align-content-center gap-2 mx-auto">
            <asp:Button runat="server" CssClass="btn btn-primary btn-lg w-100" ID="btnVehiculos" Text="Vehículos" OnClick="RedirectTo"/>
            <asp:Button runat="server" CssClass="btn btn-primary btn-lg w-100" ID="btnConductores" Text="Conductores" OnClick="RedirectTo" />
            <asp:Button runat="server" CssClass="btn btn-primary btn-lg w-100" ID="btnTrayectos" Text="Trayectos" OnClick="RedirectTo" />
        </form>
    </div>
    <footer class="position-absolute bg-body-secondary fixed-bottom w-100 text-center py-1 fw-semibold">
        Prueba de ingreso - Andrés Sneider García Quintero - 04/08/2024
    </footer>
</asp:Content>
