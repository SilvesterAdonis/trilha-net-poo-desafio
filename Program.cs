using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "24563", modelo: "Nokia 3310", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instragam");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "789906", modelo: "Iphone 12", imei: "6666666", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Pinterest");