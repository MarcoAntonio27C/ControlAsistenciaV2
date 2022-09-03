$(document).ready(function () {

    console.log("Listo");

    $.ajax({
        type: 'GET',
        url: "/Personal/Empleados",
        dataType: "json",
        //data: { idEmpleado: idEmpleado, mes: mes },
        success: function (response) {
            console.log(response);

            if (response != undefined) {
                if (response.length > 0) {
                    var index = 0;
                    for (var i = 0; i < response.length; i++) {
                        //var enlace = "Detalles/?idEmpleado=" + response[i]["id"];
                        index = i + 1;
                        $(".table>tbody").append("<tr><td>" + index + "</td><td>" + response[i]["nombreCompleto"] + "</td><td>" + response[i]["nombreInmueble"] + "</td><td>" + response[i]["numeroExpediente"] + "</td><td>" + "<button data-toggle='modal' data-target='#staticBackdrop'  type='button' id='" +response[i]["id"]+"' class='btn btn-info detalles'><span class='material-icons'>visibility</span></button>" + "</td></tr>");
                    }
                }
            }
        },
    });

    //data-toggle='modal' data-target='#staticBackdrop'

    $('body').on('click', '.detalles', function () {
        console.log($(this).attr("id"));
        var idEmpleado = $(this).attr("id")+"";
        $.ajax({
            type: 'GET',
            url: "/Personal/DatosGenerales",
            dataType: "json",
            data: { idEmpleado: idEmpleado },
            success: function (response) {
                console.log(response);
                if (response != undefined) {
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

    $.ajax({
        type: 'GET',
        url: "/Personal/GetMunicipios",
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
            url: "/Personal/GetInmueblesMunicipio",
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
        url: "/Personal/GetUnidadAdministrativa",
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
        url: "/Personal/GetCentroTrabajo",
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
        url: "/Personal/GetCargo",
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
        url: "/Personal/GetCargoHomologado",
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
        url: "/Personal/GetContratacion",
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