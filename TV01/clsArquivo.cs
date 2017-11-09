using System;
using System.Drawing.Printing;
using System.IO;

namespace TV01
{
    public class clsArquivo
    {
        string datapagamento = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        public void FU_Gravar(string txtID)
        {
            File.Delete("PEDIDOS.TXT");
            StreamWriter STW_Arquivo;
            STW_Arquivo = new StreamWriter("PEDIDOS.txt", false);
            STW_Arquivo.WriteLine("     SUPERMERCADO TABAJARA      ");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("R Nossa Senhora da Glória, 695");
            STW_Arquivo.WriteLine("Cidade Nova Aracaju/SE");
            STW_Arquivo.WriteLine("");
            //STW_Arquivo.WriteLine("     COMPROVANTE DE PAGAMENTO    ");
            STW_Arquivo.WriteLine("" + txtID.Trim());
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("COMPROVANTE SEM VALOR FISCAL");
            STW_Arquivo.Close();
        }

    }
}
