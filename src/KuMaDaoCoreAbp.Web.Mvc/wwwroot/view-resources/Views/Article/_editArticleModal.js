(function ($) {

    var _articleService = abp.services.app.article;  
    var _form = '.layui-layer  form[name="ArticleUpdateForm"]';
    var _$form = $(_form);
    var _$modal = $(".layui-layer .layui-layer-content")
    var _update_back = "#Back";
    var _update_confrim = "#ArticleUpdate_Confrim";             
    
    function save() {
        _$form = $(_form);
        ////todo 有没有这个
        //_$form.validate({
        //   // debug: true
        //});
        if (!_$form.valid()) {
            return false;
        }
        console.log("验证")
        
        var article = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
        //console.log(article)
        //return false;

        abp.ui.setBusy(_$modal);
        
        _articleService.createOrUpdateArticleAsync(article).done(function () {           
            
            layer.closeAll()

            $('#table').bootstrapTable('refresh');
        }).always(function () {
          
            abp.ui.clearBusy(_$modal);
        });
    }
    //function removeEvent() {
    //    $(document).off("click", _update_confrim)
    //}
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