using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Atividade1
{
    public class Cliente
    {
        string nome;
        public Cliente()
        {
            Write("Titular: ");
            Nome = ReadLine();
        }
        public string Nome { get; set; }
    }
}