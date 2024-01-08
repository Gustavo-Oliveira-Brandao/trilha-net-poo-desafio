using DesafioPOO.Models;

// Implementado!!!

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "40028922", modelo: "Nokia 12", imei: "11111111", memoria:128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "89224002", modelo: "Iphone 15", imei: "22222222", memoria: 252);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Microsoft Teams");