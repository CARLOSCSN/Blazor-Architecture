// Tradução pt-br para MatDatePicker(flatpickr)
flatpickr.localize(flatpickr.l10ns.pt);

$('[name="NumeroNotaFiscal"]').mask("9999");
$('[name="DataNF"]').mask('00/00/0000', { reverse: true });

function applyMaskMoney(nameInput) {
    //console.log('applyMaskMoney');
    $('[name="' + nameInput + '"]').mask('#.##0,00', { autoUnmask: true, digitsOptional: false, reverse: true });
}

function removeMask(nameInput) {
    //console.log('removeMask');
    $('[name="' + nameInput + '"]').unmask();
}

function getCleanVal(nameInput) {
    //console.log('cleanVal');
    return $('[name="' + nameInput + '"]').cleanVal();
}