(function () {
    'use strict';

    $(document).ready(function () {
        $('a.btn-delete').click(function () {
            var title = $(this).data('title');
            var message = $(this).data('message');
            var href = $(this).attr('href');

            $.get(href, function (result) {
                if (result.sucesso) {
                    alert('Registro excluido com sucesso!', function () {
                        window.location.href = result.url;
                    });
                    window.location.reload(true);
                }
                else
                    alert('Não foi possível excluir o registro.');
            });

            /*bootbox.dialog({ 
                title: title,
                message: message,
                size: 'large',
                buttons: {
                    cancel: {
                        label: "Não",
                        className: 'btn-light',
                        callback: function () {
                            // cancelado
                        }
                    },
                    ok: {
                        label: "Sim",
                        className: 'btn-primary',
                        callback: function () {
                            
                        }
                    }
                }
            });*/
            return false;
        });

    });
})();