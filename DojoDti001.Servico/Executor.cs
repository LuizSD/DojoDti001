using System;
using System.Collections.Generic;
using System.Linq;

namespace DojoDti001.Servico
{
    public class Executor
    {

        public string Teste(string entrada)
        {
            if (entrada == "A")
                return entrada;
            var diamante = "";

            // for(var x = 0; Alfabeto[x].Equals(entrada); x++)
            int x = 0;
            while (true)
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
                if (Alfabeto[x].Equals(entrada)) break;

                x++;
            }
            var indiceEntrada = Alfabeto.IndexOf(entrada) - 1;
            for (var z = indiceEntrada; z >= 0; z--)
            {
                diamante += Alfabeto[z];
                for (int espaco = 0; espaco < z; espaco++)
                {
                    diamante += " ";
                }
                if (z > 0)
                {
                    diamante += Alfabeto[z];
                }
                if(z == 0)
                    break;
                diamante += "\n";
            }
            Console.WriteLine(diamante);
            Console.WriteLine("fim");
            return diamante;
        }

        public static IList<string> Alfabeto => new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


    }
}
