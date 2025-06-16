using DesafioPOO.Models;

Iphone iphone = new Iphone("123456789", "Iphone 13", "123456789", 128);
Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321", 64);

Console.WriteLine("Testando Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine();
Console.WriteLine("Testando Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");