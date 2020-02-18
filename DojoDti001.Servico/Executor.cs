using System;
using System.Collections.Generic;
using System.Linq;

namespace DojoDti001.Servico
{
    public class Executor
    {

        public string Teste(string entrada) {
            
            var diamante = "";
            
           // for(var x = 0; Alfabeto[x].Equals(entrada); x++)
            int x = 0;
            while(true)
            {
                diamante += Alfabeto[x];
                for (int espaco = 0; espaco < x; espaco++)
                {
                    diamante += " ";
                }
                if (x > 0)
                {
                    diamante += Alfabeto[x];
                    diamante += "\n";
                }
                x++;
                if(Alfabeto[x].Equals(entrada)) break;
            }
            var indiceEntrada = Alfabeto.IndexOf(entrada) - 1;
            for(var x = indiceEntrada; x > 0; x--)
            {
                diamante += Alfabeto[x];
                for (int espaco = 0; espaco < x; espaco++)
                {
                    diamante += " ";
                }
                if (x > 0)
                {
                    diamante += Alfabeto[x];
                }
                diamante += "\n";
            }
            Console.WriteLine(diamante);
            Console.WriteLine("fim");
            return diamante;
        }

        public static IList<string> Alfabeto => new List<string>{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};


    }
}
