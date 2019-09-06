$(document).ready(function () {

});

DatasetGuardar = [];
DatasetInfoDep = [];

GuardarInfo = function () {
    debugger;
    if (DatasetGuardar.length > 0) {
        $.ajax({
            type: "POST",
            url: 'Default.aspx/GuadarInfo',
            data: JSON.stringify({ Parametros: DatasetGuardar }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            processData: true,
            async: false,
            success: function (data) {
                debugger;
                console.log('guarda bien')
                $("#TxtDepartamento").val('')
                // deberia tener un mensaje de satisfacion o error 
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    }
}

ConsultarInfo = function () {

    $.ajax({
        type: "POST",
        url: 'Default.aspx/BuscarInfo',
        data: JSON.stringify({ IdIngreso: IdIngreso }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        processData: true,
        success: function (data) {
            debugger;
            if (data.d.length > 0) {
                for (i = 0; i < data.d.length; i++) {
                    var Dieta = data.d[i]
                    ObDieta = {
                        Origen: Dieta.ORIGEN,
                        id: DatasetDietas.length + 1,
                        Dieta: Dieta.TIPODIETA,
                        IDDIETA: Dieta.IDDIETA,
                        IDTIPODIETA: Dieta.IDTIPODIETA,
                        hora: Dieta.HORARIO,
                        IDHORARIO: Dieta.IDHORARIO,
                        COMENTARIO: Dieta.COMENTARIO,
                        IDINGRESO: IdIngreso,
                        USUARIO: "",
                        ESTADO: Dieta.ESTADO
                    }
                    DatasetDietas.push(ObDieta)

                }
                PintarGrillaDietas()
            }

        },
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
}

LlenarDatasetDep = function () {
    //deberia validar requeridos
    DatasetGuardar = [];

    Departamento = {
        Operacion: 1,
        nombreDepartamento: $("#TxtDepartamento").val(),
        NombreCiudad: '',
        IdCiudad: 0,
        IdRelacion: 0,
        IdDepartamento: 0,
        IdRelacion: 0,
        login: 'JccA'
    }

    DatasetGuardar.push(Departamento)

    GuardarInfo();

}