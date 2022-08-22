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
});