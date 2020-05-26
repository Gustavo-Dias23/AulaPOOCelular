using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular redmi = new celular();
            redmi.cor = "Vermelho";
            redmi.modelo = "Redmi";
            redmi.tamanho = 5;
            redmi.ligado = true;

            Console.WriteLine (redmi.modelo + " " +redmi.cor);
            Console.WriteLine (redmi.Ligar());  
            Console.WriteLine (redmi.Desligar());
            Console.WriteLine (redmi.FazerLigacao());
            Console.WriteLine (redmi.EnviarMensagem());
        }
    }
}
