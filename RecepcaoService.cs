using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example
{
    public class RecepcaoService : IRecepcaoService
    {
        public string Saudacao(string nome)
        {
            return $"Olá {nome}!";
        }
    }
}
