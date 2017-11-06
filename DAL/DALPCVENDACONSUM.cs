using Modelo;
using System.Data;
using System.Data.OracleClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DALPCVENDACONSUM
    {
        private DALConexao conexao;
        public DALPCVENDACONSUM(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPCVENDACONSUM modelo)
        {
            String comando1 = "";

#pragma warning disable CS0618 // "OracleCommand" é obsoleto: "OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260"
#pragma warning disable CS0618 // "OracleCommand" é obsoleto: "OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260"
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // "OracleCommand" é obsoleto: "OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260"
#pragma warning restore CS0618 // "OracleCommand" é obsoleto: "OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260"
            cmd.Connection = conexao.ObjetoConexao;

            comando1 = comando1 + "INSERT INTO pcvendaconsum " + "\n";
            comando1 = comando1 + "                ( numped " + "\n";
            comando1 = comando1 + "                 ,cliente " + "\n";
            comando1 = comando1 + "                 ,cgcent " + "\n";
            comando1 = comando1 + "                 ,enderent " + "\n";
            comando1 = comando1 + "                 ,bairroent " + "\n";
            comando1 = comando1 + "                 ,telent " + "\n";
            comando1 = comando1 + "                 ,municent " + "\n";
            comando1 = comando1 + "                 ,estent " + "\n";
            comando1 = comando1 + "                 ,cepent " + "\n";
            comando1 = comando1 + "                 ,ieent " + "\n";
            comando1 = comando1 + "                 ,nomecontato " + "\n";
            comando1 = comando1 + "                 ,telefonecontato " + "\n";
            comando1 = comando1 + "                 ,obscontato " + "\n";
            comando1 = comando1 + "                 ,email " + "\n";
            comando1 = comando1 + "                 ,codcidade " + "\n";
            comando1 = comando1 + "                 ,numeroent " + "\n";
            comando1 = comando1 + "                ) " + "\n";
            comando1 = comando1 + "         VALUES ( @numped " + "\n";
            comando1 = comando1 + "                 ,@cliente " + "\n";
            comando1 = comando1 + "                 ,@cgcent " + "\n";
            comando1 = comando1 + "                 ,@enderent " + "\n";
            comando1 = comando1 + "                 ,@bairroent " + "\n";
            comando1 = comando1 + "                 ,@telent " + "\n";
            comando1 = comando1 + "                 ,@municent " + "\n";
            comando1 = comando1 + "                 ,@estent " + "\n";
            comando1 = comando1 + "                 ,@cepent " + "\n";
            comando1 = comando1 + "                 ,@ieent " + "\n";
            comando1 = comando1 + "                 ,@nomecontato " + "\n";
            comando1 = comando1 + "                 ,@telefonecontato " + "\n";
            comando1 = comando1 + "                 ,@obscontato " + "\n";
            comando1 = comando1 + "                 ,@email " + "\n";
            comando1 = comando1 + "                 ,@codcidade " + "\n";
            comando1 = comando1 + "                 ,@numeroent " + "\n";
            comando1 = comando1 + "                )";
            cmd.CommandText = comando1;
            cmd.Parameters.AddWithValue("@numped", modelo.numped);
            cmd.Parameters.AddWithValue("@cliente", modelo.cliente);
            cmd.Parameters.AddWithValue("@cgcent", modelo.cgcent);
            cmd.Parameters.AddWithValue("@enderent", modelo.enderent);
            cmd.Parameters.AddWithValue("@bairroent", modelo.bairroent);
            cmd.Parameters.AddWithValue("@telent", modelo.telent);
            cmd.Parameters.AddWithValue("@municent", modelo.municent);
            cmd.Parameters.AddWithValue("@estent", modelo.estent);
            cmd.Parameters.AddWithValue("@cepent", modelo.cepent);
            cmd.Parameters.AddWithValue("@ieent", modelo.ieent);
            cmd.Parameters.AddWithValue("@nomecontato", modelo.nomecontato);
            cmd.Parameters.AddWithValue("@telefonecontato", modelo.telefonecontato);
            cmd.Parameters.AddWithValue("@obscontato", modelo.obscontato);
            cmd.Parameters.AddWithValue("@email", modelo.email);
            cmd.Parameters.AddWithValue("@codcidade", modelo.codcidade);
            cmd.Parameters.AddWithValue("@numeroent", modelo.numeroent);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public ModeloPCVENDACONSUM CarregaPCVENDACONSUM (long codigo)
        {
            String comando2 = "SELECT * FROM PCVENDACONSUM WHERE NUMPED = :codigo ";

            ModeloPCVENDACONSUM modelo = new ModeloPCVENDACONSUM();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando2;
            cmd.Parameters.AddWithValue(":codigo", codigo);
            conexao.Conectar();
            OracleDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();
                modelo.numped = Convert.ToInt64(registro["NUMPED"]);
                modelo.cliente = Convert.ToString(registro["CLIENTE"]);
                modelo.cgcent = Convert.ToString(registro["CGCENT"]);
                modelo.enderent = Convert.ToString(registro["ENDERENT"]);
                modelo.bairroent = Convert.ToString(registro["BAIRROENT"]);
                modelo.telent = Convert.ToString(registro["TELENT"]);
                modelo.municent = Convert.ToString(registro["MUNICENT"]);
                modelo.estent = Convert.ToString(registro["ESTENT"]);
                modelo.cepent = Convert.ToString(registro["CEPENT"]);
                modelo.ieent = Convert.ToString(registro["IEENT"]);
                modelo.nomecontato = Convert.ToString(registro["NOMECONTATO"]);
                modelo.telefonecontato = Convert.ToString(registro["TELEFONECONTATO"]);
                modelo.obscontato = Convert.ToString(registro["OBSCONTATO"]);
                modelo.email = Convert.ToString(registro["EMAIL"]);
                modelo.codcidade = Convert.ToInt32(registro["CODCIDADE"]);
                modelo.numeroent = Convert.ToString(registro["NUMEROENT"]);

            }
            conexao.Desconectar();
            return modelo;
        }
        
        
    }
}
