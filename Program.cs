using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone13 = new Iphone("2199999999", "13", "IMEI98989721", 256);
iphone13.InstalarAplicativo("whatsapp");
iphone13.Ligar();
iphone13.ReceberLigacao();

Smartphone nokiaWindowsPhone = new Nokia("2199999999", "Windows phone", "I1208138192",16);

nokiaWindowsPhone.Ligar();
nokiaWindowsPhone.ReceberLigacao();
nokiaWindowsPhone.InstalarAplicativo("Twitter");
