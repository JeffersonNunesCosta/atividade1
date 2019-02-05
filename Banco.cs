using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Atividade1
{
    public class Banco
    {
         
        List<Agencia> agencias = new List<Agencia>();

        public void AdicionarAgencia(Agencia agencia)
        {
    
            agencias.Add(agencia);
            WriteLine("Agência " + agencia.IdAgencia + " criada!");
            WriteLine("Numero de agencias: " + (agencias.Count) + "\n");
        }

        public int IdBanco { get; set; }

        public List<Agencia> Agencias { get; }

        public Agencia buscaAgencia(int num)
        {
            Agencia ag = null;
            foreach (var agencia in agencias)
            {
                if (agencia.IdAgencia == num)
                {
                    ag = agencia;
                    return ag;
                }
            }
            WriteLine("DADOS INFORMADOS NÃO ESTÃO CORRETOS, TENTE NOVAMENTE\n");
            return null;
            
            
        }

        public bool listaIdAgencias()
        {
            if(agencias.Count == 0)
            {
                WriteLine("Nenhuma agência cadastrada");
                return false;
            }
            else
            {
                WriteLine("Agências");
                foreach (var agencia in agencias)
                {
                    WriteLine("Agência: " + agencia.IdAgencia);
                }
                return true;
            }
        }

    }
}
