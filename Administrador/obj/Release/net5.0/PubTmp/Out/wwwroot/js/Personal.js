$(document).ready(function () {
    $('body').on('click', '.detalles', function () {
        console.log($(this).attr("id"));
        console.log(window.location.pathname);
        var idEmpleado = $(this).attr("id") + "";
        //url: '@Url.Action("DatosGenerales", "Personal")',
        $.ajax({
            type: 'GET',
            url: "DatosGenerales",
            //url: "@Url.Action('DatosGenerales', 'Personal')",
            dataType: "json",
            data: { idEmpleado: idEmpleado },
            success: function (response) {
                console.log(response);
                if (response != undefined) {
                    var enlace = "Actualizar/?idEmpleado=" + response["id"];
                    $("#nombreCompleto").val(response['nombreCompleto']);
                    $("#numeroExpediente").val(response['numeroExpediente']);
                    $("#ur").val(response['ur']);
                    $("#municipio").val(response['municipio']);
                    $("#inmueble").val(response['inmueble']);
                    $("#centroTrabajo").val(response['centroTrabajo']);
                    $("#unidadAdministrativa").val(response['unidadAdministrativa']);
                    $("#cargo").val(response['cargo']);
                    $("#horario").val(response['horario']);
                }
            },
        });
    });
});