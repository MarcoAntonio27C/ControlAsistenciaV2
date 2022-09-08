

$(document).ready(function () {

    console.log("Listo entra aqui");

    $(".alert").hide();
    var idEmpleado = $("#idEmpleado").val();
    var mes = $("#mes").val();

    $.ajax({
        type: 'GET',
        contentType: "application/json",
        url: "/Asistencias/GetAsistencias",
        data: { idEmpleado: idEmpleado, mes: mes },
        success: function (response) {
            console.log(response);
            if (response != undefined) {
                if (response.length > 0) {
                    $("#ReportePDF").attr("disabled", false);
                    $(".alert").hide();
                    for (var i = 0; i < response.length; i++) {
                        $("#tabla>tbody").append("<tr><td>" + response[i]["dia"] + "</td><td>" + response[i]["entrada"] + "</td><td>" + response[i]["salidaComida"] + "</td><td>" + response[i]["regresoComida"] + "</td><td>" + response[i]["salida"] + "</td></tr>");
                    }

                } else {
                    $("#ReportePDF").attr("disabled", true);
                    $(".alert").show();
                }
            } else {
                $("#ReportePDF").attr("disabled", true);
                $(".alert").show();
            }
        },
    });


    $("#Buscar").click(function () {
        var mes = $("#mes").val();
        $("#tabla>tbody").empty();
        $.ajax({
            type: 'GET',
            contentType: "application/json",
            url: "/Asistencias/GetAsistencias",
            data: { idEmpleado: idEmpleado, mes: mes },
            success: function (response) {
                console.log(response);
                if (response != undefined) {
                    if (response.length > 0) {
                        $("#ReportePDF").attr("disabled", false);
                        $(".alert").hide();
                        for (var i = 0; i < response.length; i++) {
                            $("#tabla>tbody").append("<tr><td>" + response[i]["dia"] + "</td><td>" + response[i]["entrada"] + "</td><td>" + response[i]["salidaComida"] + "</td><td>" + response[i]["regresoComida"] + "</td><td>" + response[i]["salida"] + "</td></tr>");
                        }

                    } else {
                        $("#ReportePDF").attr("disabled", true);
                        $(".alert").show();
                    }
                } else {
                    $("#ReportePDF").attr("disabled", true);
                    $(".alert").show();
                }
            },
        });
    });



});