$(document).ready(function () {

    console.log("Listo");

    $.ajax({
        type: 'GET',
        url: "Empleados",
        dataType: "json",
        //data: { idEmpleado: idEmpleado, mes: mes },
        success: function (response) {
            console.log(response);

            if (response != undefined) {
                if (response.length > 0) {
                    var index = 0;
                    for (var i = 0; i < response.length; i++) {
                        var enlace = "DetallesEmpleado/?idEmpleado=" + response[i]["id"];
                        index = i + 1;
                        $(".table>tbody").append("<tr><td>" + index + "</td><td>" + response[i]["nombre"] + " " + response[i]["apellidoPaterno"] + " " + response[i]["apellidoMaterno"] + "</td><td>" + response[i]["nombreInmueble"] + "</td><td>" + response[i]["adscripcion"] + "</td><td>" + response[i]["numeroExpediente"] +"</td><td>" + "<a  href='" + enlace + "'>Detalles</a>" + "</td></tr>");
                    }
                }
            }
        },
    });

    $.ajax({
        type: 'GET',
        url: "GetMunicipios",
        success: function (response) {
            $.each(response, function (i, municipio) {
                $("#municipio").append($('<option>', {
                    value: municipio.id,
                    text: municipio.nombre
                }));
            });
            console.log(response);
        },
    });

    $.ajax({
        type: 'GET',
        url: "GetInmueblesMunicipio/829D477C-F775-4C88-9953-85D22BA08598",
        success: function (response) {
            $.each(response, function (i, inmueble) {
                $("#inmueble").append($('<option>', {
                    value: inmueble.id,
                    text: inmueble.nombre
                }));
            });
             console.log(response);
        },
    });


});