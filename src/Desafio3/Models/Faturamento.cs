using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.Models
{
    public class Faturamento
    {
        [JsonProperty("dia")]
        public int DiaMes { get; set; }
        public double Valor { get; set; }
    }
}
