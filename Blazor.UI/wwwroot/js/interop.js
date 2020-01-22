function controlInputTypeSubmit(isInvalid) {
    //console.log(isInvalid);
    $(':input[type="submit"]').prop('disabled', isInvalid);


    // teste mask
    $('#Cliente').mask('00/00/0000');
}