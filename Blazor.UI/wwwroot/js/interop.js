// Tradução pt-br para MatDatePicker(flatpickr)
flatpickr.localize(flatpickr.l10ns.pt);

function controlInputTypeSubmit(isInvalid) {
    console.log(isInvalid);
    $(':input[type="submit"]').prop('disabled', isInvalid);
}

function applyInputMask() {
    setTimeout(function () {

        $('[name="NumeroNotaFiscal"]').inputmask("9999");

        $('[name="ValorVenda"]').maskMoney({
            prefix: "R$:",
            decimal: ",",
            thousands: "."
        });

    }, 500);
}
