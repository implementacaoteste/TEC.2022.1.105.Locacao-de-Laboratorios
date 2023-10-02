using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PredioDAL
    {
        public void Inserir(Predio _predio)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Predio (Nome, Andares, Descricao, Estado) VALUES (@Nome, @Andares, @Descricao, @Estado)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _predio.Nome);
                cmd.Parameters.AddWithValue("@Andares", _predio.Andares);
                cmd.Parameters.AddWithValue("@Descricao", _predio.Descricao);
                cmd.Parameters.AddWithValue("@Estado", _predio.Estado);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Predio no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Predio> BuscarTodos()
        {
            List<Predio> predios = new List<Predio>();
            Predio predio;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Andares, Descricao, Estado FROM Predio";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        predio = new Predio();
                        predio.Id = Convert.ToInt32(rd["Id"]);
                        predio.Nome = rd["Nome"].ToString();
                        predio.Andares = rd["Andares"].ToString();
                        predio.Descricao = rd["Descricao"].ToString();
                        predio.Estado = rd["Estado"].ToString();

                        predios.Add(predio);
                    }
                }
                return predios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Predios no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Predio BuscarPorId(int id)
        {
            Predio predio = new Predio();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Andares, Descricao, Estado  FROM Predio WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        predio.Id = Convert.ToInt32(rd["Id"]);
                        predio.Nome = rd["Nome"].ToString();
                    }
                }
                return predio;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um predio no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Predio>  BuscarPorNome(string nome)
        {
            List<Predio> predios = new List<Predio>();
            Predio predio;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Andares, Descricao, Estado FROM Predio WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        predio = new Predio();
                        predio.Id = Convert.ToInt32(rd["Id"]);
                        predio.Nome = rd["Nome"].ToString();
                        predios.Add(predio);
                    }
                }
                return predios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um predio por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Predio _predio)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Predio SET Nome = @Nome, Andares = @Andares, Descricao = @Descricao, Estado = @Estado  WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _predio.Nome);
                cmd.Parameters.AddWithValue("@Andares", _predio.Andares);
                cmd.Parameters.AddWithValue("@Descricao", _predio.Descricao);
                cmd.Parameters.AddWithValue("@Estado", _predio.Estado);
                cmd.Parameters.AddWithValue("@Id", _predio.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar um predio no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Predio WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um predio do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
