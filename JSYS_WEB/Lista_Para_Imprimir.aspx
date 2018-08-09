<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lista_Para_Imprimir.aspx.cs" Inherits="JSYS_WEB.Lista_Para_Imprimir" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html>

<html lang="es">
<head runat="server">
    <meta charset ="utf-8"/>
    <title>Reimprimir Recibo</title>
    <link href="Estilos.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="with=device-with, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
   
    <!-- DataTables -->
    
</head>
<body>
    <div class ="contenedor">
        <form runat="server" id="form1">
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cerrar Sesion" CssClass="btn-success" OnClick="Button1_Click" Width="100px" />
            <asp:Button ID="Button2" runat="server" Text="Volver" CssClass="btn-danger" OnClick="Button2_Click" Width="100px" />
        <header >
            <h1>Reimprimir Recibo</h1>
        </header>
        <section class ="contenido">
           
            <div>
                <strong>Cliente:</strong>&nbsp; <telerik:RadComboBox ID="cb_cliente" runat="server" Width="178px" OnSelectedIndexChanged="cb_cliente_SelectedIndexChanged" AutoPostBack="True"></telerik:RadComboBox>
            </div>
            <div>
                <strong>Buscar Por:&nbsp; </strong><telerik:RadComboBox ID="cb_buscar" runat="server" Width="150px" Culture="es-ES">
                    <Items>
                        <telerik:RadComboBoxItem runat="server" />
                        <telerik:RadComboBoxItem runat="server" Text="Cliente" Value="Cliente" />
                        <telerik:RadComboBoxItem runat="server" Text="Recibo" Value="Recibo" />
                    </Items>
                </telerik:RadComboBox>
            </div>
            <div class="form-group">
    
                <asp:TextBox ID="txt_buscar" runat="server" Text="" Width="165px"></asp:TextBox>
                
                            <telerik:RadButton ID="RadButton3" runat="server" Text="Buscar" OnClick="RadButton3_Click">
                </telerik:RadButton>
                
                            </div>
            <div>&nbsp;&nbsp;</div>
            <div style="text-align: left" >
                <br />
                <asp:Label ID="Lbl_usuario" runat="server" Text="Label" style="text-align: left; font-weight: 700;"></asp:Label>
                <br />
            </div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" Width="97%" ForeColor="#333333" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BorderStyle="Solid" BorderWidth="1px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID_RECIBO" HeaderText="No" />
                    <asp:BoundField DataField="FECHA_CREADO" HeaderText="Fecha" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="CUOTA_COBRADA" HeaderText="Cuota" />
                    <asp:BoundField DataField="NOMBRE" HeaderText="Cliente" />
                    <asp:BoundField DataField="VALOR_PAGADO" HeaderText="Monto" DataFormatString="{0:n2}" />
                    <asp:CommandField ButtonType="Button" SelectText="Imprimir" ShowSelectButton="True">
                    <ControlStyle Font-Bold="True" CssClass="btn-primary btn-block btn-xs" />
                    <ItemStyle Font-Bold="True" />
                    </asp:CommandField>
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#3d9970" Font-Bold="True" ForeColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>

        </section>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
             </form>
    </div>
  
    
  
</body>
</html>
