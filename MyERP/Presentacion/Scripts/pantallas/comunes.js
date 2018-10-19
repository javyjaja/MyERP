function ConsumeAjax(url, parametros)
{
    var respuesta;
   var x = JSON.stringify(parametros)
    $.ajax({
        type: "POST",
        url: "../" + url,
        data: { CategoriaId: parametros },
                
        content: "application/json; charset=utf-8",
        //dataType: "json",
        success: function (response) {
            respuesta = response;
        }
    });

    return respuesta;
}