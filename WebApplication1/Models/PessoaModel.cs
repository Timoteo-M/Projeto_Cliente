using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PessoaModel
    {
        public int PessoaID { get; set; }
        public string PessoaNome { get; set; }
        public string PessoaEndereco { get; set; }
        public string PessoaTel { get; set; }
        public string PessoaEmail { get; set; }

        readonly string connectionString = @"Data Source=DESKTOP-HV1ONTQ;Initial Catalog=Cadastro_Pessoas;Integrated Security=True";

        public void Salvar()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("INSERT INTO Pessoa VALUES(@PessoaNome, @PessoaEndereco, @PessoaTel, @PessoaEmail)", sqlCon);

                sqlCmd.Parameters.AddWithValue("@PessoaNome", PessoaNome);
                sqlCmd.Parameters.AddWithValue("@PessoaEndereco", PessoaEndereco);
                sqlCmd.Parameters.AddWithValue("@PessoaTel", PessoaTel);
                sqlCmd.Parameters.AddWithValue("@PessoaEmail", PessoaEmail);

                sqlCmd.ExecuteNonQuery();
            }
        }


    }
}
