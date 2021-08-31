using System;

namespace Design.Patterns.Commands.Aula01.Entidades
{
    public class ContaBancaria
    {
        private int _saldo;
        private const int LimiteChequeEspecial = -500;

        public void Depositar(int valor)
        {
            _saldo += valor;
            Console.WriteLine($"Valor depositado: R$ {valor}, Saldo atual: R$ {_saldo}");
        }
        
        public void Sacar(int valor)
        {
            if (_saldo - valor >= LimiteChequeEspecial)
            {
                _saldo -= valor;
                Console.WriteLine($"Valor retirado: R$ {valor}, Saldo atual: R$ {_saldo}");
            }
        }

        public override string ToString()
        {
            return $"Saldo: R$ {_saldo}";
        }
    }
}