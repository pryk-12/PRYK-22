
$(document).ready(function () {
    Listar_CXP();
});

function addRowDT(data) {
    tabla = $("#tbl_cxc").DataTable();

    tabla.fnClearTable();

    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].ID_FACTURA,
            data[i].NUMERO_CUOTA,
            moment(data[i].FECHA).format("DD/MM/YYYY"),
            data[i].NOMBRE,
            data[i].MONTO_CUOTA,
            '<button type="button" value="Actualizar" title="Actualizar" class="btn btn-primary btn-edit" data-target="#imodal" data-toggle="modal"><i class="fa fa-check-square-o" aria-hidden="true"></i></button>' 
        ]);
    }
}
//Load Data function
function Listar_CXP() {
    $.ajax({
        type: "POST",
        url: "Lista_Pendientes.aspx/Listar_CXP",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (data) {
            addRowDT(data.d);
        }
    });
}
