using System;
using System.Threading.Tasks;

namespace ByteBank{
    class Program {
        static void Main(String[] args)
        {
            ContaCorrente ContaDaGabriela = new ContaCorrente();

            ContaDaGabriela.titular = "Gabriela"; 
            ContaDaGabriela.agencia = 0863;
            ContaDaGabriela.numero = 863452;
            ContaDaGabriela.saldo = 100;

            Console.WriteLine(ContaDaGabriela.titular);
            Console.WriteLine("Agencia:" + ContaDaGabriela.agencia);
            Console.WriteLine("Número.:" + ContaDaGabriela.numero);
            Console.WriteLine("Saldo..:" + ContaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
