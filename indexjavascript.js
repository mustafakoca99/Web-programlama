<!--kopyalama engelleme-->
function bookmarkthis(title,url) {
if (window.sidebar) { // Firefox için
window.sidebar.addPanel(title, url, "");
} else if (document.all) { // IE ve chorome  için
window.external.AddFavorite(url, title);
} else if (window.opera && window.print) { // Opera için
var elem = document.createElement('a');
elem.setAttribute('href',url);
elem.setAttribute('title',title);
elem.setAttribute('rel','sidebar');
elem.click();
}
}
<!--değişen site başlığı-->
var default1 = "EN ZOR RAKİP 'SENSİN' |"; 
var text1 = "EN ZOR RAKİP 'SENSİN' | BAŞARI";
var text2 = "EN ZOR RAKİP 'SENSİN' | EN BÜYÜK";
var text3 = "EN ZOR RAKİP 'SENSİN' | İNTİKAMDIR";
var text4 = "EN ZOR RAKİP 'SENSİN' | MUSTAFA KOCA";
var changeRate = 2000;
var messageNumber = 0;
function changeStatus() {
  if (messageNumber == 0) {
     window.status=default1;
     document.title=default1;
    }
  else if (messageNumber == 1) {
     window.status=text1;
     document.title=text1;
    }
  else if (messageNumber == 2) {
     window.status=text2;
     document.title=text2;
     }
  else if (messageNumber == 3) {
     window.status=text3;
     document.title=text3;
     }
  else if (messageNumber == 4) {
     window.status=text4;
     document.title=text4;
     messageNumber = 0;
     }
  messageNumber++;
  setTimeout("changeStatus();",changeRate);
}
changeStatus(); 
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