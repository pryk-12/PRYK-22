<%@ Page Title="" Language="C#" MasterPageFile="~/Maste_Page.Master" AutoEventWireup="true" CodeBehind="Listado_CXC.aspx.cs" Inherits="WebApp.Listado_CXC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <h2 style="text-align: center">Cobros Pendientes</h2> 
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


