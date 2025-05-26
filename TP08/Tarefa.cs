using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP08
{
    internal class Tarefa
    {
        public string Nome {  get; set; }
        public string Data { get; set; }
        public bool Status { get; set; }

        public override string ToString()
        {
            return "Nome: " + Nome + " | Data: " + Data + " | Status: " + Status;
        }
    }
}
