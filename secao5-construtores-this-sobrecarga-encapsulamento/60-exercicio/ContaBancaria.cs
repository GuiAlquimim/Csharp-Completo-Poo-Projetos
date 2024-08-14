using System;
using System.Globalization;

namespace _60_exercicio
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: ${Saldo.ToString("f2", CultureInfo.InvariantCulture)}";
        }

        public double Deposito(double quantiaDeposito)
        {
            return Saldo += quantiaDeposito;
        }

        public double Saque(double quantia)
        {
            double Taxa = quantia + 5.00;
            return Saldo -= Taxa;
        }
    }
}
