using System;
using System.Data.OracleClient;


namespace DAL
{
    public class DALConexao
    {

#pragma warning disable CS0618

        private String _stringConexao;

        private OracleConnection _conexao;

        private OracleTransaction _transaction;

        public DALConexao(String dadosConexao)
        {

            this._conexao = new OracleConnection();

            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }


        public OracleConnection ObjetoConexao

        {
            get { return this._conexao; }
            set { this._conexao = value; }

        }

        public OracleTransaction ObjetoTransacao
        {
            get { return this._transaction; }
            set { this._transaction = value; }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
        public void IniciarTransacao()
        {
            this._transaction = _conexao.BeginTransaction();
        }

        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }

        public void CancelarTransacao()
        {
            this._transaction.Rollback();
        }

    }
}
