function makeArray() { 
var args = makeArray.arguments; 
for (var i = 0; i < args.length; i++) { 
this[i] = args[i]; 
} 
this.length = args.length; 
} 

function fixDate(date) { 
var base = new Date(0); 
var skew = base.getTime(); 
if (skew > 0) 
date.setTime(date.getTime() - skew); 
} 

function getString(date) { 
var months = new makeArray("Ocak", "Subat", "Mart", 
"Nisan", "Mayis", "Haziran", 
"Temmuz", "Agustos", "Eylül", 
"Ekim", "Kasim", "Aralik"); 
var days = new makeArray("Pazar", "Pazartesi", "Sali", "Çarsamba", 
"Persembe", "Cuma", "Cumartesi"); 

return date.getDate() + " " + 
months[date.getMonth()] + " " + 
(date.getYear())+ ", " + 
(days[date.getDay()]); 
} 

var cur = new Date(); 
fixDate(cur); 
var str = getString(cur); 
document.write(str); 