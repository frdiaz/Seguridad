function camposFono(e){
  key = e.keyCode || e.which;
   tecla = String.fromCharCode(key).toLowerCase();
   caract = "0123456789+ ";
   especiales = "";

   tecla_especial = false
   for(var i in especiales){
        if(key == especiales[i]){
            tecla_especial = true;
            break;
        }
    }

    if(caract.indexOf(tecla)==-1 && !tecla_especial){
        return false;
    }
}

function camposRut(e){
  key = e.keyCode || e.which;
   tecla = String.fromCharCode(key).toLowerCase();
   caract = "0123456789.-k";
   especiales = "";

   tecla_especial = false
   for(var i in especiales){
        if(key == especiales[i]){
            tecla_especial = true;
            break;
        }
    }

    if(caract.indexOf(tecla)==-1 && !tecla_especial){
        return false;
    }
}

function camposTexto(e){
  key = e.keyCode || e.which;
   tecla = String.fromCharCode(key).toLowerCase();
   caract = " qwertyuiopasdfghjklñzxcvbnm";
   especiales = "";

   tecla_especial = false
   for(var i in especiales){
        if(key == especiales[i]){
            tecla_especial = true;
            break;
        }
    }

    if(caract.indexOf(tecla)==-1 && !tecla_especial){
        return false;
    }
}
