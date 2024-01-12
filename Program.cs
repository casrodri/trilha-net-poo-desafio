using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123-4567", "Nokia 3310", "789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("555-1234", "iPhone 12", "123", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
    