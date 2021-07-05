using System;

namespace pooMensagem
{
    public class Mensagem
    {
        private String textoMensagem;
        public String TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }
            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }

        public void exibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
