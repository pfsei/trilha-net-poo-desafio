using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criar uma instância de Nokia
        Nokia nokiaPhone = new Nokia("12345", "Nokia 3310", "123456789", 8);

        // Criar uma instância de iPhone
        Iphone iphone = new Iphone("67890", "iPhone 13", "987654321", 64);

        // Testar os métodos das classes
        nokiaPhone.Ligar();
        nokiaPhone.ReceberLigacao();
        nokiaPhone.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        // Aguarde a entrada do usuário para que a janela do console não seja fechada imediatamente.
        Console.ReadLine();
    }
}

// TODO: Realizar os testes com as classes Nokia e Iphone