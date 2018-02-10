(function ($) {


   
            
    var _articleService = abp.services.app.article;

    var _$form = $('.layui-layer  form[name="ArticleDetailUpdateForm"]');
    var _$modal = $(".layui-layer .layui-layer-content"); //$('.layui-layer #ArticleDetailUpateModal'); //vvar _$modal = $(".layui-layer .layui-layer-content")
    var _update_confrim = "#ArticleDetailUpdate_Confrim";

    function save() {
      
        //todo 有没有这个
        //_$form.validate({
        //});
        if (!_$form.valid()) {
            return;
        }
        var article = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js


        abp.ui.setBusy(_$form);
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

    //$.AdminBSB.input.activate(_$form);

    //_$modal.on('shown.bs.modal', function () {
    //    _$form.find('input[type=text]:first').focus();
    //});

})(jQuery);