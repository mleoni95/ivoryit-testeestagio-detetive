using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Detetive
    {
        private int Criminoso { get; set; }
        private int Local { get; set; }
        private int Arma { get; set; }

        // Variável de tentativa inicial para criminoso,arma e local.
        private int CriminosoTemporario = 1;
        private int LocalTemporario = 1;
        private int ArmaTemporaria = 1;

            // Função que interroga a testemunha enquanto houver resposta errada.
            public int Interroga(Testemunha testemunha)
            {
                int resposta = testemunha.Interrogar(CriminosoTemporario, LocalTemporario, ArmaTemporaria);
                
                // Enquanto houver resposta errada irá adicionar 1 no item incorreto.
                while (resposta != 0)
                {

                    if (resposta == 1)
                    {
                        CriminosoTemporario++;
                    }
                    else if (resposta == 2)
                    {
                        LocalTemporario++;
                    }
                    else
                    {
                        ArmaTemporaria++;
                    }

                    resposta = testemunha.Interrogar(CriminosoTemporario, LocalTemporario, ArmaTemporaria);
                }

                // Atribuindo o valor correto que corresponde a cada item.
                Criminoso = CriminosoTemporario;
                Local = LocalTemporario;
                Arma = ArmaTemporaria;
                
                // Exibição.
                Console.WriteLine("Criminoso = " + Criminoso);
                Console.WriteLine("Local = " + Local);
                Console.WriteLine("Arma = " + Arma);
                Console.WriteLine("");

                return (1);
            } 
    }
}
