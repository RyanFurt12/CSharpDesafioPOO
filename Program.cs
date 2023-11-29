using DesafioPOO.Models;

Console.Clear();

Iphone iphone = new Iphone("99875631", "Iphone 14","1561566", 258);
Nokia nokia = new Nokia("97566425", "G21","151622", 64);

iphone.InstalarAplicativo("WhatsApp");
iphone.Ligar();

nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();
