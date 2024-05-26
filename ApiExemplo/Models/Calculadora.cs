using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExemplo.Models
{
    public class Calculadora
    {
        private List<string> HistoricoList;

        public Calculadora()
        {
            HistoricoList = new List<string>();
        }
        public int Somar(int n1, int n2)
        {
            int res =  n1 + n2;
            string r = $"{n1} + {n2} = {res}";
            HistoricoList.Add(r);
            return res;
        }

        public int Subtrair(int n1, int n2)
        {
            int res =  n1 - n2;
            string r = $"{n1} - {n2} = {res}";
            HistoricoList.Add(r);
            return res;
        }

        public int Multiplicar(int n1, int n2)
        {
            int res =  n1 * n2;
            string r = $"{n1} * {n2} = {res}";
            HistoricoList.Add(r);
            return res;
        }

        public int Dividir(int n1, int n2)
        {
            int res =  n1 / n2;
            string r = $"{n1} / {n2} = {res}";
            HistoricoList.Add(r);
            return res;
        }

        public List<string> Historico()
        {
            return HistoricoList;
        }
      
    }
}