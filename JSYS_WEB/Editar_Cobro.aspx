<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar_Cobro.aspx.cs" Inherits="JSYS_WEB.Editar_Cobro" %>

<!DOCTYPE html>

<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <title>Relizar Cobro</title>

        
    <link href="Estilos.css" rel="stylesheet" />
    <meta name="viewport" content="with=device-with, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <%--    <script src="js/JS_CXC.js"></script>
    <script src="js/plugins/moment/moment.min.js"></script>--%>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/ionicons.min.css" rel="stylesheet" />
    <!-- DataTables -->
    <link href="css/AdminLTE.css" rel="stylesheet" />
    
</head>
<body>
    <div class="contenedor">
        <form runat="server" id="form1">
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cerrar Sesion" CssClass="btn-success" OnClick="Button1_Click" Width="100px" />
            <asp:Button ID="Button2" runat="server" Text="Volver" CssClass="btn-danger" OnClick="Button2_Click" Width="100px" />
        
            <header>
                <h1>Cobrar Cuota Pendiente</h1>
            </header>
            <section class="contenido">
                <div style="width: 350px;">
                    <div class="box box-primary" style="width: 300px">
                        <div class="box-body">
                            <div class="form-group">
                                <strong>No. Factura
                                <asp:TextBox ID="txt_no_factura" runat="server" Text="" CssClass="form-control" Enabled="False" Width="250px"></asp:TextBox>
                                </strong>
                            </div>
                            <div class="form-group">
                                <strong>No. Cuota
                                <asp:TextBox ID="txt_no_cuota" runat="server" Text="" CssClass="form-control" Enabled="False" Width="250px"></asp:TextBox>
                                </strong>
                            </div>
                            <div class="form-group">
                                <label>Cliente</label>
                                <asp:TextBox ID="txt_cliente" runat="server" Text="" CssClass="form-control" Enabled="False" Width="250px"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Monto Cuota</label>
                                <asp:TextBox ID="txt_monto_cuota" runat="server" Text="" CssClass="form-control" Enabled="False" Width="250px"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:CheckBox ID="ch_pago_total" runat="server" Text="Pago Total" />
                                <br />
                                <label>A Pagar</label>
                                <asp:TextBox ID="txt_valor_a_pagar" runat="server" Text="" CssClass="form-control" Width="250px"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="btn_cobrar" runat="server" CssClass="btn btn-primary" Width="120px" Text="Cobrar" OnClick="btn_cobrar_Click" style="font-weight: bold" />
                                &nbsp;&nbsp;
                            </div>
                            <div>
                                
                            </div>
                        </div>
                    </div>
                    <asp:Label ID="lbl_error" runat="server" style="color: #FF0000; font-weight: 700;"></asp:Label>
                    <br />
                    <asp:RegularExpressionValidator ID="RegexDecimal" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" ErrorMessage="Ingrese un Monto Decimal" ControlToValidate="txt_valor_a_pagar" style="color: #FF0000; font-weight: 700" />
                </div>
            </section>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </form>
    </div>



</body>
</html>
