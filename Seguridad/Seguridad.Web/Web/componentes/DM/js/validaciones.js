function solonumeros(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    permite = "0123456789";
    especiales = "";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (permite.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function caracteresRut(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    permite = " 0123456789-k";
    especiales = "";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (permite.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function carateresEmail(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    permite = "0123456789k_-qwertyuioplkjhgfdsazxcvbnm@";
    especiales = "";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (permite.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function caracteresTelefono(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    permite = " 0123456789+";
    especiales = "";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (permite.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function caracteresSitioWeb(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    permite = " 0123456789+_-qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM.";
    especiales = "";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (permite.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function caracteresTextos(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    permite = " qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM";
    especiales = "";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (permite.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function caracteresFecha(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    permite = "0123456789-/";
    especiales = "";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (permite.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}