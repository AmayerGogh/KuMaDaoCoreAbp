(function () {
    $(function () {
        //service
        var _articleService = abp.services.app.article;
        var _$modal = $('.layui-layer #ArticleCreateModal');
       // var _$form = $('.layui-layer  form[name="articleCreateForm"]');       //_$modal.find('#articleCreateForm');        
        var _add_confrim = "#ArticleCreate_Comfrim";                   
        $(document).on("click", _add_confrim,function () {
            var _$form = $('.layui-layer  form[name="articleCreateForm"]');
            _$form.validate({
            });
       
            console.log(_$form.html())
            if (!_$form.valid()) {
                return;
            }
            var model = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
            console.log(model)
         
         

            abp.ui.setBusy(_$modal);
            _articleService.createOrUpdateArticleAsync(model).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new role!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

      
    });
})();