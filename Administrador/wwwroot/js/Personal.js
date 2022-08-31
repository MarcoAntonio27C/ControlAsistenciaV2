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
           // console.log(response);
        },
    });


    $("#municipio").change(function () {
        $("#inmueble").empty();
        $.ajax({
            type: 'GET',
            url: "GetInmueblesMunicipio",
            data: {
                id: $("#municipio").val()
            },
            success: function (response) {
                $.each(response, function (i, inmueble) {
                    $("#inmueble").append($('<option>', {
                        value: inmueble.id,
                        text: inmueble.nombre
                    }));
                });
               // console.log(response);
            },
        });
    });

    $.ajax({
        type: 'GET',
        url: "GetUnidadAdministrativa",
        success: function (response) {
            $.each(response, function (i, unidad) {
                $("#unidadAdministrativa").append($('<option>', {
                    value: unidad.id,
                    text: unidad.nombre
                }));
            });
            // console.log(response);
        },
    });

    $.ajax({
        type: 'GET',
        url: "GetCentroTrabajo",
        success: function (response) {
            $.each(response, function (i, centro) {
                $("#centroTrabajo").append($('<option>', {
                    value: centro.id,
                    text: centro.nombre
                }));
            });
            // console.log(response);
        },
    });


    $.ajax({
        type: 'GET',
        url: "GetCargo",
        success: function (response) {
            $.each(response, function (i, cargo) {
                $("#cargo").append($('<option>', {
                    value: cargo.id,
                    text: cargo.nombre
                }));
            });
            // console.log(response);
        },
    });

    $.ajax({
        type: 'GET',
        url: "GetCargoHomologado",
        success: function (response) {
            $.each(response, function (i, cargoHomologado) {
                $("#cargoHomologado").append($('<option>', {
                    value: cargoHomologado.id,
                    text: cargoHomologado.nombre
                }));
            });
            // console.log(response);
        },
    });

    $.ajax({
        type: 'GET',
        url: "GetContratacion",
        success: function (response) {
            $.each(response, function (i, contratacion) {
                $("#contratacion").append($('<option>', {
                    value: contratacion.id,
                    text: contratacion.nombre
                }));
            });
             console.log(response);
        },
    });



    $("#registrar").click(function () {
        console.log($("#nombreCompleto").val());
        console.log($("#numeroExpediente").val());
        console.log($("#ur").val());
        console.log($("#fechaIngreso").val());
        console.log($("#municipio").val());
        console.log($("#inmueble").val());
        console.log($("#unidadAdministrativa").val());
        console.log($("#centroTrabajo").val());
        console.log($("#cargo").val());
        console.log($("#cargoHomologado").val());
        console.log($("#horario").val());
    });
});