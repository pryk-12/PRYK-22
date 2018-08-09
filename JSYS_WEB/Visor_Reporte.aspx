<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Visor_Reporte.aspx.cs" Inherits="JSYS_WEB.Visor_Reporte" %>


<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html lang="es">
<head runat="server">
    <meta charset ="utf-8"/>
    <title>Ver Recibo</title>
    <link href="Estilos.css" rel="stylesheet" />
    <meta name="viewport" content="with=device-with, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/ionicons.min.css" rel="stylesheet" />
    <!-- DataTables -->
    <link href="css/AdminLTE.css" rel="stylesheet" />
    
</head>
<body>
    <div class ="contenedor">
        <form runat="server" id="form1">
                     <br />
                     <asp:Button ID="Button1" runat="server" Text="Cerrar Sesion" CssClass="btn-success" OnClick="Button1_Click" Width="100px" />
            <asp:Button ID="Button2" runat="server" Text="Volver" CssClass="btn-danger" OnClick="Button2_Click" Width="100px" />
        <section class ="contenido">
            <dx:ASPxDocumentViewer ID="rv" runat="server" Height="500px" ReportTypeName="Rep_Recibo" Theme="PlasticBlue" Width="100%">
                <toolbaritems>
                    <dx:ReportToolbarButton ItemKind="PrintReport" />
                </toolbaritems>
            </dx:ASPxDocumentViewer>
        </section>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
             </form>
    </div>
  
    
  
</body>
</html>
