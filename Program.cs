using DesafioPOO.Models;
    
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("O celular Nokia esta em funcionamento...");
    Smartphone nokia = new Nokia(numero:"55 ## 987##-0000", modelo:"Ano 1990", _IMEI:"xptr45", memoria: 2);
    nokia.Ligar();
    nokia.InstalarAplicativo("Jogo da cobrinha.");


Console.WriteLine("SmartPhone Iphone esta em funcionamento: ");
    Smartphone iphone = new Iphone(numero: "01 1# 91##-09##", modelo: "X Pro MAX", _IMEI: "cctre45", memoria: 128);
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Instagram");