(function ($) {


   
            
    var _articleService = abp.services.app.article;
    var _form = '.layui-layer  form[name="ArticleDetailUpdateForm"]';
    var _$form = $(_form);
    var _$modal = $(".layui-layer .layui-layer-content");
    var _update_back = "#Back";
    var _update_confrim = "#ArticleDetailUpdate_Confrim";

    function save() {
        _$form =$(_form)
       
        if (!_$form.valid()) {
            return;
        }
        var article = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js


        abp.ui.setBusy(_$modal);
        _articleService.createOrUpdateArticleDetailAsync(article).done(function () {
            layer.closeAll();
            $('#table').bootstrapTable('refresh');
        }).always(function () {
            abp.ui.clearBusy(_$modal);
        });
    }
    $(document).on("click", _update_confrim, function (e) {
        e.preventDefault();
      
        save();
    });
    //Handle enter key
    _$form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            save();
        }
    });
    $(document).on("click", _update_back, function (e) {

        layer.closeAll()

    });
    //$.AdminBSB.input.activate(_$form);

    //_$modal.on('shown.bs.modal', function () {
    //    _$form.find('input[type=text]:first').focus();
    //});

})(jQuery);