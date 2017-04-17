using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DeterminadorDeResposta
    {
        public void executa(Requisicao req, Conta conta)
        {
            IResposta r1 = new RespostaEmXml();
            IResposta r2 = new RespostaEmCsv();
            IResposta r3 = new RespostaEmPorcentagem();
            

            r1.Proximo = r2;
            r2.Proximo = r3;
           

            r1.Responde(req, conta);

        }
        

        

    }
}
