using System;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem mensagem1, mensagem2;
            mensagem1 = new Mensagem();
            mensagem1.setTextoMensagem("Olá Mundo");
            Console.WriteLine(mensagem1.getTextoMensagem());
            //mensagem1.exibirMensagem();



            mensagem2 = new Mensagem();
            mensagem2.setTextoMensagem("Segundo Objeto");
            mensagem2.exibirMensagem();
            Console.ReadKey();

        }
    }
}
