function ativaTab(idTab) {
    $('#' + idTab).addClass("active");
}

function removeCursorDisabled() {
    $('.form-control[disabled]').css("cursor", "default");
}

function exibeAlertaDeErro() {
    toastr.options = {
        "positionClass": "toast-top-center",
    };

    toastr.error("Ocorreu um erro na solicitação. Por favor, tente novamente.");
}

function bloqueiaTela() {
    $.blockUI(
    {
        message: "Por favor, aguarde.. Esta operação pode demorar alguns minutos.",
        css: {
            border: 'none',
            padding: '15px',
            backgroundColor: '#000',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            opacity: .5,
            color: '#fff'
        }
    });
}

function desbloqueiaTela() {
    $.unblockUI();
}

$(document).ready(function() {
    $.datepicker.setDefaults({
        showOn: "focus",
        altFormat: "yy-mm-dd",
        defaultDate: new Date()
    });
})