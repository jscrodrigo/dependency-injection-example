using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example
{
    public class Controller
    {
        private readonly IRecepcaoService _recepcaoService;
        public Controller(IRecepcaoService recepcaoService)
        {
            _recepcaoService = recepcaoService ?? throw new ArgumentNullException(nameof(recepcaoService));     
        }
        public string Ola(string nome)
        {
            var saudacao = _recepcaoService.Saudacao(nome);
            return saudacao;
        }
    }
}
