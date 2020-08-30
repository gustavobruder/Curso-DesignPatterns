using System;

namespace Design.Patterns.Commands.Aula02.Entidades
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

        public bool Sacar(int valor)
        {
            if (_saldo - valor >= LimiteChequeEspecial)
            {
                _saldo -= valor;
                Console.WriteLine($"Valor retirado: R$ {valor}, Saldo atual: R$ {_saldo}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Saldo: R$ {_saldo}";
        }
    }
}