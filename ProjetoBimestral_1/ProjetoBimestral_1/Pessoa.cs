using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBimestral_1
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public int fixo { get; set; }
        public int celular { get; set; }
        public DateTime data_de_nascimento { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        
    }
}
