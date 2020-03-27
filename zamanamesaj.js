<!--zamana göre mesaj verme -->

var zaman=new date()

var saat=zaman.getHours()

if(saat<12)

{

document.write("Günaydın güzel insan...");

}

else if(saat>=12 && saat<19)

{

document.write("İyi günler güzel insan...");

}

else

{

document.write("İyi geceler güzel insan...");

}

 