<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportesJoin.aspx.cs" Inherits="TallerLinq.ReportesJoin" %>
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
    <br />
    Consulta que muestra la informacion de una orden con el id, nombre del cliente y el empleado
    <asp:Button ID="btnConsulta1" runat="server" Text="Consultar" OnClick="btnConsulta1_Click" />
    <br />
    <br />
    Consulta que muestra la informacion de una orden con el id, nombre del cliente y el empleado de el año
    <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnConsulta4" runat="server" Text="Consutlar" OnClick="btnConsulta4_Click" />
    <br />
    <br />
    Informacion de un producto(nombre,id) categoria (nombre, descripcion) y proveedor(nombre,ciudad)
    <asp:Button ID="btnConsulta2" runat="server" Text="Consultar" OnClick="btnConsulta2_Click" />
    <br />
    <br />
    Informacion de un producto(nombre,id) categoria (nombre, descripcion) y proveedor(nombre,ciudad) Ordenado segun el Precio o el stock
    <asp:DropDownList ID="ddlbuscar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl1_SelectedIndexChanged">
                            <asp:ListItem Text="Precio" />
                    <asp:ListItem Text="Stock" />
    </asp:DropDownList>
    <br />
    <asp:GridView ID="GridView1" runat="server" CssClass="mGrid">
    </asp:GridView>
    <br />
    <br />
</asp:Content>
