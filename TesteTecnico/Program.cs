using System;
using System.Globalization;

namespace testeTecnico {
    class Program {
        static void Main(string[] args) {

           
            int indice = 13, soma = 0, K = 0;

            while (K < indice) {
                K = K + 1;
                soma = soma + K;
            }

            Console.WriteLine(soma);

        }
    }
}
 

    
