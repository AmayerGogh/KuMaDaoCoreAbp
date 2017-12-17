(function () {
    $(function () {

        var _articleService = abp.services.app.article;
        var _$modal = $('#ArticleCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshRoleList();
        });

        $('.delete-article').click(function () {
            var roleId = $(this).attr("data-article-id");
            var roleName = $(this).attr('data-article-name');

            deleteRole(roleId, roleName);
        });

        $('.edit-article').click(function (e) {
            var id = $(this).attr("data-article-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'admin/article/EditArticleModal?Id=' + id,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#ArticleEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {

            console.log(e)
            e.preventDefault();

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

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshRoleList() {
            location.reload(true); //reload page to see new role!
        }

        function deleteRole(roleId, roleName) {
            abp.message.confirm(
                "Remove Users from Role and delete Role '" + roleName + "'?",
                function (isConfirmed) {
                    if (isConfirmed) {
                        _roleService.delete({
                            id: roleId
                        }).done(function () {
                            refreshRoleList();
                        });
                    }
                }
            );
        }
    });
})();