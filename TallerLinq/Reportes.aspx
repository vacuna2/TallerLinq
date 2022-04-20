<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="TallerLinq.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        * {
    padding: 0;
    margin: 0;
}

body {
    font: 11px Tahoma;
}

h1 {
    font: bold 32px Times;
    color: #666;
    text-align: center;
    padding: 20px 0;
}

#container {
    width: 700px;
    margin: 10px auto;
}

.mGrid {
    width: 100%;
    background-color: #fff;
    margin: 5px 0 10px 0;
    border: solid 1px #525252;
    border-collapse: collapse;
}

    .mGrid td {
        padding: 2px;
        border: solid 1px #c1c1c1;
        color: #717171;
    }

    .mGrid th {
        padding: 4px 2px;
        color: #fff;
        background: #424242 url(grd_head.png) repeat-x top;
        border-left: solid 1px #525252;
        font-size: 0.9em;
    }

    .mGrid .alt {
        background: #fcfcfc url(grd_alt.png) repeat-x top;
    }

    .mGrid .pgr {
        background: #424242 url(grd_pgr.png) repeat-x top;
    }

        .mGrid .pgr table {
            margin: 5px 0;
        }

        .mGrid .pgr td {
            border-width: 0;
            padding: 0 6px;
            border-left: solid 1px #666;
            font-weight: bold;
            color: #fff;
            line-height: 12px;
        }

        .mGrid .pgr a {
            color: #666;
            text-decoration: none;
        }

            .mGrid .pgr a:hover {
                color: #000;
                text-decoration: none;
            }
    </style>
    <p></p>
    <p>Consultas Usando Proyeccion
        <asp:DropDownList runat="server" ID="ddlProyeccion" AutoPostBack="True" OnSelectedIndexChanged="ddlProyeccion_SelectedIndexChanged" >
            <asp:ListItem Text="consultar productos para saber el stock menor al numero ingresado" />
            <asp:ListItem Text="consultar pedidos respecto al pais para donde se hizo" />
            <asp:ListItem Text="consultar empleados segun el apellido del empleado" />
        </asp:DropDownList>
        Texto: <asp:TextBox runat="server" ID="txtProyeccion"/>
    </p>
    <p></p>
    <p>Consultas Usando Lambda
        <asp:DropDownList runat="server" ID="ddlLambda" AutoPostBack="True" OnSelectedIndexChanged="ddlLambda_SelectedIndexChanged">
            <asp:ListItem Text="Consulta Precio Promedio,minimo,maximo de productos agrupado por categoria" />
            <asp:ListItem Text="Selecciona Productos cuyo stock es mayor a " />
            <asp:ListItem Text="Selecciona ordenes realizadas despues de 1997" />
        </asp:DropDownList>
        Mayor a: <asp:TextBox runat="server" ID="txtLambda"/>
    </p>
    <p></p>
    <p>Consultas Usando Clases Parciales
        <asp:DropDownList runat="server" ID="ddlClaseParcial" AutoPostBack="True" OnSelectedIndexChanged="ddlClaseParcial_SelectedIndexChanged" >
            <asp:ListItem Text="consultar Nombre del empeleado y Ubicacion" />
            <asp:ListItem Text="consultar Datos del envio" />
            <asp:ListItem Text="consultar Datos de contacto y direccion de cliente" />
        </asp:DropDownList>
    </p>
    <p></p>



    <p><asp:Label Text="Reporte:" runat="server" ID="lblDescripccion" /></p>
    <p>
        <asp:GridView runat="server" ID ="gvReporte" CssClass="mGrid"></asp:GridView>
    </p>
</asp:Content>
