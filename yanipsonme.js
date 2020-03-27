 var mesaj = "Hoşgeldiniz!";
 var hiz = 500;
 var visible = 0;
 
 function goster()
 {
 if (visible == 0) 
    {
     window.status = mesaj; visible =1;
    }
    else { window.status = " "; visible = 0; }
 setTimeout('goster()', hiz);
 }
