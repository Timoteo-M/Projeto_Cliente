using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas.Models
{
    public class PessoaModel
    {
        public int PessoaID { get; set; }
        public string PessoaNome { get; set; }
        public string PessoaEndereco { get; set; }
        public string PessoaEmail { get; set; }
        public string PessoaTel { get; set; }

        readonly string connectionString = @"Data Source=DESKTOP-HV1ONTQ;Initial Catalog=DB_Cadastro;Integrated Security=True";

        public DataTable Listar()
        {
            DataTable tblPessoa = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Pessoa", sqlCon);

                sqlDa.Fill(tblPessoa);
            }

            return tblPessoa;
        }

        public void Salvar()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("INSERT INTO Pessoa VALUES(@PessoaNome, @PessoaEndereco, @PessoaEmail, @PessoaTel)", sqlCon);

                sqlCmd.Parameters.AddWithValue("@PessoaNome", PessoaNome);
                sqlCmd.Parameters.AddWithValue("@PessoaEndereco", PessoaEndereco);
                sqlCmd.Parameters.AddWithValue("@PessoaEmail", PessoaEmail);
                sqlCmd.Parameters.AddWithValue("@PessoaTel", PessoaTel);


                sqlCmd.ExecuteNonQuery();
            }
        }

        public void Editar(int IDPessoa)
        {
            DataTable tblPessoa = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Pessoa WHERE @PessoaID = PessoaID", sqlCon);

                sqlDa.SelectCommand.Parameters.AddWithValue("@PessoaID", IDPessoa);

                sqlDa.Fill(tblPessoa);
            }
            PessoaID = Convert.ToInt32(tblPessoa.Rows[0][0].ToString());
            PessoaNome = tblPessoa.Rows[0][1].ToString();
            PessoaEndereco = tblPessoa.Rows[0][2].ToString();
            PessoaEmail = tblPessoa.Rows[0][3].ToString();
            PessoaTel = tblPessoa.Rows[0][4].ToString();
           

        }

        public void Atualizar()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("UPDATE Pessoa SET PessoaNome = @PessoaNome, PessoaEndereco = @PessoaEndereco, PessoaEmail = @PessoaEmail, PessoaTel = @PessoaTel WHERE PessoaID = @PessoaID", sqlCon);

                sqlCmd.Parameters.AddWithValue("@PessoaID", PessoaID);
                sqlCmd.Parameters.AddWithValue("@PessoaNome", PessoaNome);
                sqlCmd.Parameters.AddWithValue("@PessoaEndereco", PessoaEndereco);
                sqlCmd.Parameters.AddWithValue("@PessoaEmail", PessoaEmail);
                sqlCmd.Parameters.AddWithValue("@PessoaTel", PessoaTel);
                

                sqlCmd.ExecuteNonQuery();
            }
        }
        public void Excluir(int idPessoa)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();

                //Cria a instrução SQL DELETE para remover o registro indicado com o ID
                SqlCommand sqlCmd = new SqlCommand(
                    "DELETE Pessoa WHERE PessoaID = @PessoaID", sqlCon);

                sqlCmd.Parameters.AddWithValue("@PessoaID", idPessoa);

                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
