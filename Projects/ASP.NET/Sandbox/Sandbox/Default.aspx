<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sandbox.App_Pages.Default" %>

<asp:Content ContentPlaceHolderID="cphContent" runat="server">
    <script>
        var gesign = {

        }

    function gInsertBlock()
    {
        var content = $('#g-content');
    }    
    </script>

    <div id="g-builder" class="g-builder">
        <button onclick="insertBlock()">Insert</button>
        <button>Delete</button>
    </div>

    <div id="g-content" class="g-content">

    </div>
</asp:Content>

<%--<asp:Content ContentPlaceHolderID="cphFooter" runat="server">
</asp:Content>--%>