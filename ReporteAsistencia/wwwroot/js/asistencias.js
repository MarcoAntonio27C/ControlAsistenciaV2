

$(document).ready(function () {
    console.log("SacarCita Ready!");
    $(".alert").hide();
    var idEmpleado = $("#idEmpleado").val();
    var mes = $("#mes").val();
    $.ajax({
        type: 'POST',
        url: "GetAsistencias",
        dataType: "json",
        data: { idEmpleado: idEmpleado, mes: mes },
        success: function (response) {
            //  console.log(response);
            if (response != undefined) {
                if (response.length > 0) {
                    $(".alert").hide();
                    for (var i = 0; i < response.length; i++) {
                        $("#tabla>tbody").append("<tr><td>" + response[i]["dia"] + "</td><td>" + response[i]["entrada"] + "</td><td>" + response[i]["salidaComida"] + "</td><td>" + response[i]["regresoComida"] + "</td><td>" + response[i]["salida"] + "</td></tr>");
                    }

                } else {
                    $(".alert").show();
                }
            } else {
                $(".alert").show();
            }
        },
    });



    $("#Buscar").click(function () {
        var mes = $("#mes").val();
        $("#tabla>tbody").empty();
        $.ajax({
            type: 'POST',
            url: "GetAsistencias",
            dataType: "json",
            data: { idEmpleado: idEmpleado, mes: mes },
            success: function (response) {
                  console.log(response);
                if (response != undefined) {
                    if (response.length > 0) {
                        $(".alert").hide();
                        for (var i = 0; i < response.length; i++) {
                            $("#tabla>tbody").append("<tr><td>" + response[i]["dia"] + "</td><td>" + response[i]["entrada"] + "</td><td>" + response[i]["salidaComida"] + "</td><td>" + response[i]["regresoComida"] + "</td><td>" + response[i]["salida"] + "</td></tr>");
                        }

                    } else {
                        $(".alert").show();
                    }
                } else {
                    $(".alert").show();
                }
            },
        });
    });

});