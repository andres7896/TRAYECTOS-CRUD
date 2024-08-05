<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Trayectos_CRUD.Pages.Trayectos.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Trayectos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <form runat="server" class="row g-3 mx-3">
        <article class="col-md-12 d-flex justify-content-start align-items-center gap-3">
            <asp:LinkButton runat="server" ID="btnVolver" OnClick="Volver">
                <i class="bi bi-chevron-left icon-info bg-primary"></i>
            </asp:LinkButton>
            <h2>Trayectos</h2>
        </article>
        <article>
            <asp:GridView runat="server" class="table table-striped table-borderless table-hover mt-3" ID="gvTrayectos" AutoGenerateColumns="False" EmptyDataText="No se encontraron trayectos.">
                <Columns>
                    <asp:BoundField DataField="IdTrayecto" HeaderText="Id" />
                    <asp:BoundField DataField="CiudadOrigen" HeaderText="Origen" />
                    <asp:BoundField DataField="CiudadDestino" HeaderText="Destino" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre Conductor" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido Conductor" />
                    <asp:BoundField DataField="Placa" HeaderText="Placa vehículo" />
                    <asp:BoundField DataField="ValorReal" HeaderText="Valor real" />
                    <asp:BoundField DataField="ValorCobrado" HeaderText="Valor cobrado" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />

                    <asp:TemplateField HeaderText="Actualizar">
                        <ItemTemplate>
                            <asp:Button runat="server" CssClass="btn btn-warning" ID="btnUpdate" Text="Editar" OnClick="RedirectTo"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Eliminar">
                        <ItemTemplate>
                            <asp:Button runat="server" CssClass="btn btn-danger" ID="btnDelete" Text="Eliminar" OnClick="Delete"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </article>
        <asp:Button runat="server" CssClass="btn btn-primary btnAdd" ID="btnAdd" Text="+" OnClick="RedirectTo"/>
    </form>
</asp:Content>
