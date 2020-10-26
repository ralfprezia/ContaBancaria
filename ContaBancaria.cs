using System.Globalization;

namespace ContaBancaria {
    class ContaBancaria {
        //atributos
        public int Numero { get; private set; }//encapsulamento sem alteração somente acesso
        public string Titular { get; set; }// pode ser alterado o nome do titular
        public double Saldo { get; private set; }//somente será alterado por um método interno


        //Construtor com dois argumentos
        public ContaBancaria(int numero, string titular) {//quando for criado um objeto conta bancária o saldo recebe = 0.00
            Numero = numero;
            Titular = titular;
        }
        //Sobrecarga neste construtor com 3 argumentos com o de cima, utilizando o :This(..., ....)
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }
        //implementando a operação Depósito com void para alterar o valor dela
        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        //implementando a operação Saque com void para alterar o valor dela
        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public override string ToString() {//para a exibição do resultado em forma de string concatenado e configurado para ser exibido em um formato assim: Conta 7801, Tiular: Maria Brown, Saldo: $0.00
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);// CultureInfo.InvariantCulture faz com que a virgula seja trocada por um ponto 

        }


    }
}
