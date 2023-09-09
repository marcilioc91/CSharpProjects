using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }        

        public ContaBancaria()
        { 
        }

        public ContaBancaria(int numeroConta, string nome)
        {
            Numero = numeroConta;
            Titular = nome;
        }
        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this (numeroConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: {Saldo:c}";
        }
    }
}
