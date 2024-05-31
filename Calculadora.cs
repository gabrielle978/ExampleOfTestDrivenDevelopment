using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listhistorico;
        private string data;

        public Calculadora(string data) //construtor
        {
            listhistorico = new List<string>();
            this.data = data; 
        }
         public int somar(int num1, int num2) 
        {
            int resultado =  num1 + num2;
            listhistorico.Insert(0, "Res: " + resultado + "-DATA: " + data);
            return resultado;
        }

        public int subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listhistorico.Insert(0, "Res: " + resultado + "-DATA: " + data);
            return resultado;
        }
        public int multiplicar(int num1, int num2)
        {
             int resultado = num1 * num2;
            listhistorico.Insert(0, "Res: " + resultado + "-DATA: " + data);
            return resultado;
        }
        public int dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listhistorico.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public List<string> historico ()
        {   
            listhistorico.RemoveRange(3,listhistorico.Count-3);
            return listhistorico;
        }
    }
}
