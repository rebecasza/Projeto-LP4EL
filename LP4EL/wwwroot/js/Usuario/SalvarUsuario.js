(function () {
    'use strict';

    $(document).ready(function () {
        $('a#btn-salvar').click(function () {
            var href = $(this).attr('href');
            var data = $('#frm-usuario').serialize();
            $.post(href, data, function (result) {
                console.log(data);
                if (result.sucesso) {
                    alert('Registro salvo com sucesso!', function () {
                        window.location.href = result.url;
                    });
                    window.location.reload(true);
                }
                else
                    alert('Não foi possível salvar o registro.');
            })
                .fail(function (e) {
                    alert(e);
                });

            return false;
        });
    });
})();