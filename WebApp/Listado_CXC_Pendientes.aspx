<%@ Page Title="" Language="C#" MasterPageFile="~/Maste_Page.Master" AutoEventWireup="true" CodeBehind="Listado_CXC_Pendientes.aspx.cs" Inherits="WebApp.Listado_CXC_Pendientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <h2 style="text-align: center">Cobros Pendientes</h2> 
         <hr />
         <asp:Label ID="lbl_cobrador" runat="server" Text="Cobrador Asignado: JMENA" Font-Bold="True" ForeColor="#0066CC"></asp:Label>
        <table class="table table-bordered table-hover" id="tbl_cxc">
            <thead>
                <tr>
                    <th>
                        ID
                    </th>
                    <th>
                        Cuota
                    </th>
                    <th>
                        Fecha
                    </th>
                    <th>
                        Nombre
                    </th>
                    <th>
                       Monto Cuota
                    </th>
                    <th>
                        Action
                    </th>
                </tr>
            </thead>
            <tbody class="tbody">

            </tbody>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="js/JS_CXC.js"></script>
    <script src="js/plugins/moment/moment.min.js"></script>
</asp:Content>
