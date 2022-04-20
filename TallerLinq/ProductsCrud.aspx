<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductsCrud.aspx.cs" Inherits="TallerLinq.ProductsCrud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <p></p>
    <p>ID Product: <asp:TextBox runat="server" ID="txtIdPorducto" /></p>
    <p>Product Name: <asp:TextBox runat="server" ID="txtProductName" /></p>
    <p>Supplier: <asp:DropDownList runat="server" ID="ddlSuppliers"></asp:DropDownList></p>
    <p>Categorie: <asp:DropDownList runat="server" ID="ddlCategories"></asp:DropDownList></p>
    <p>QuantityPerUnit: <asp:TextBox runat="server" ID="txtQuantityPerUnit" /></p>
    <p>UnitPrice: <asp:TextBox runat="server" ID="txtUnitPrice" /></p>
    <p>UnitsInStock: <asp:TextBox runat="server" ID="txtUnitsInStock" /></p>
    <p>UnitsOnOrder: <asp:TextBox runat="server" ID="txtUnitsOnOver" /></p>
    <p>ReorderLevel: <asp:TextBox runat="server" ID="txtReorderLevel" /></p>
    <p>Discontinued:<asp:CheckBox Text="" ID="cbxDiscontinued" runat="server" /> </p>
    <p>
        <asp:Button Text="Agregar" ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" />
        <asp:Button Text="Actualizar" ID="Button1" runat="server" OnClick="Button1_Click" />
        <asp:Button Text="Eliminar" ID="Button2" runat="server" OnClick="Button2_Click" />
    </p>
    <p>
        <asp:GridView runat="server" ID ="gvProductos"></asp:GridView>
    </p>

</asp:Content>
