using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Table
{
    public class TelefonesAdicionais
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public int FkPF { get; set; }
        public int FkPj { get; set; }
    }
}
