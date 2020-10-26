using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;// declarando uma conta
            
            //Entrada de dados nas variáveis temporárias
            Console.WriteLine("Entre como o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);//cria a conta com o depósito inicial//chamada  do método construtor com 3 argumentos
            }
            else {
                conta = new ContaBancaria(numero, titular);//cria a conta sem o depósito inicial//chamada do método construtor com 2 argumentos e este contrutor joga o valor do saldo pra 0.00 por não ter depoísto inicial
            }
            //interação 
            Console.WriteLine();//quebra delinha
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);//mostra a conta 

            Console.WriteLine();//quebra de linha
            Console.WriteLine("Entre com o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//ENTRADA DE DADOS
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);    
        }
    }
}
