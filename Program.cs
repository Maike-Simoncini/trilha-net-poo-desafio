using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando o Nokia:");
Nokia nokia = new Nokia("123456", "Modelo A", "IMEI123", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTestando o iPhone:");
Iphone iphone = new Iphone("654321", "Modelo B", "IMEI456", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
