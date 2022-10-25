$(document).ready(function () {

    $.ajax({
        type: 'GET',
        url: "GetCategoria",
        success: function (response) {
            $.each(response, function (i, categoria) {
                $("#categoria").append($('<option>', {
                    value: categoria.id,
                    text: categoria.nombre + "-" + categoria.descripcion
                }));
            });
           // console.log(response);
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


    $("#unidadAdministrativa").change(function () {
        console.log($("#unidadAdministrativa").val());
        $("#centroTrabajo").empty();
        $.ajax({
            type: 'GET',
            url: "GetCentroTrabajo",
            data: {
                id: $("#unidadAdministrativa").val()
            },
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
    });

    //$.ajax({
    //    type: 'GET',
    //    url: "GetCentroTrabajo",
    //    success: function (response) {
    //        $.each(response, function (i, centro) {
    //            $("#centroTrabajo").append($('<option>', {
    //                value: centro.id,
    //                text: centro.nombre
    //            }));
    //        });
    //        // console.log(response);
    //    },
    //});


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
        url: "GetContratacion",
        dataType: "json",
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
});