using System;

namespace pooMensagem
{
    public class Mensagem
    {
        private string TextoMensagem;

        public void exibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

        public String getTextoMensagem()
        {
            return this.TextoMensagem;
        }

        public void setTextoMensagem(String valor)
        {
            this.TextoMensagem = valor;
        }
    }
}
