<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CategoriesCrud.aspx.cs" Inherits="TallerLinq.CategoriesCrud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p></p>
    <p>CategoryID: <asp:TextBox runat="server" ID="txtCategoryID" /></p>
    <p>CategoryName: <asp:TextBox runat="server" ID="txtCategoryName" /></p>
    <p>Description: <asp:TextBox runat="server" ID="txtDescription" /></p>
    <!---<p>Picture: <asp:TextBox runat="server" ID="txtPicture" /></p>---->
    <p>
        <asp:Button Text="Agregar" ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" />
        <asp:Button Text="Actualizar" ID="btnActualizar" runat="server" OnClick="Button1_Click" />
        <asp:Button Text="Eliminar" ID="btnEliminar" runat="server" OnClick="Button2_Click" />
    </p>
    <p>
        <asp:GridView runat="server" ID ="gvCAtegories"></asp:GridView>
    </p>
</asp:Content>
