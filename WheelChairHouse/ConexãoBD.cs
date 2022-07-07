///Iniciando a conexao entre o banco de dados do MySql com o Visual Studio C#
using MySql.Data.MySqlClient;
using System.Data;

namespace WheelChairHouse
{
    class ConexãoBD
    {
        private MySqlConnection conexao;

        public void ConectarBD()
        {
            ///Conexão MySql com C#
            conexao = new MySqlConnection("persist security info = false;" +
                                          "server=localhost;" +
                                          "database=WHEELHOUSE_BD;" +
                                          "uid=root;pwd=;SslMode=none;");

            conexao.Open();

        }

        public void AlterarTabelas(string sql)
        {
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql,conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ConsultarTabelas(string sql)
        {

            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;

        }



    }





}
