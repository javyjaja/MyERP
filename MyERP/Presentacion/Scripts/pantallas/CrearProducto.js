$("#producto_CategoriaId").change(function () {
    ConsumeAjax("Home/CargaCaracteristicas", this.value);
});

