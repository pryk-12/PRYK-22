<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="JSYS_WEB.Principal" %>

<!DOCTYPE html>

<html lang="es">
<head runat="server">
    <meta charset ="utf-8"/>
    <title>Pagina Principal</title>
    <link href="Estilos.css" rel="stylesheet" />
    <meta name="viewport" content="with=device-with, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <%--    <script src="js/JS_CXC.js"></script>
    <script src="js/plugins/moment/moment.min.js"></script>--%>


    <!-- DataTables -->
    
</head>
<body>
    <div class="contenedor">
        <form runat="server" id="form1">
            <header>
                <h1>
                    <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="White" NavigateUrl="~/Lista_Pendientes.aspx">Lista Cobros Pendientes</asp:HyperLink></h1>
                <h1>
                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" NavigateUrl="~/Lista_Para_Imprimir.aspx">Reimprimir Recibo</asp:HyperLink></h1>
            </header>
        </form>
    </div>
</body>
</html>
