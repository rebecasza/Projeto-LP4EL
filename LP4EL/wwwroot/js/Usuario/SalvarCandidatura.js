(function () {
    'use strict';

    $(document).ready(function () {
        $('a#btn-salvar').click(function () {
            var href = $(this).attr('href');
            var data = $('#frm-usuario').serialize();
            var urlArray = window.location.href.split('/');
            var id = urlArray[urlArray.length - 1];
            data = data + '&IdVaga=' + id;

            $.post(href, data, function (result) {
                console.log("success");
                if (result.sucesso)
                    bootbox.alert('Registro salvo com sucesso!', function () {
                        window.location.href = result.url;
                    });
                else
                    bootbox.alert('Não foi possível salvar o registro.');
            })
                .fail(function (e) {
                    bootbox.alert(e);
                });

            return false;
        });
    });
})();