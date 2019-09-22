<!--zamana göre mesaj verme -->
var zaman=new date()
var saat=zaman.getHours()
if(saat<12)
{
alert("Günaydın güzel insan...");
}
else if(saat>=12 && saat<19)
{
alert("İyi günler güzel insan...");
}
else
{
alert("İyi geceler güzel insan...");
}
 