using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Electrophorus
{
    class ClassArqText
    {
        public void FU_Salvar(string textBoxReceber)
        {
            StreamWriter STW_Arquivo;
            STW_Arquivo = new StreamWriter("c:\\ArquivoTXT_Electrophorus.text");
            STW_Arquivo.WriteLine(textBoxReceber.Trim());
            STW_Arquivo.Close();
        }
    }
}
