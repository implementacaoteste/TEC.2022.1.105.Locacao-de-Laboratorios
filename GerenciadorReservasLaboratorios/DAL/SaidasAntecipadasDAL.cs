using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class SaidasAntecipadasDAL
    {
        public void Inserir(SaidasAntecipadas saidaAntecipada)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SaidasAntecipadas (IdAluno, IdProfessor, IdCoordenacao, Motivo, StatusSaida, DataSaida, HoraSaida) 
                                    VALUES (@IdAluno, @IdProfessor, @IdCoordenacao, @Motivo, @StatusSaida, @DataSaida, @HoraSaida)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdAluno", saidaAntecipada.IdAluno);

                if (saidaAntecipada.IdProfessor == 0)
                {
                    cmd.CommandText = cmd.CommandText.Replace("@IdProfessor,", "");
                    cmd.CommandText = cmd.CommandText.Replace("IdProfessor,", "");
                }
                else
                    cmd.Parameters.AddWithValue("@IdProfessor", saidaAntecipada.IdProfessor);

                if (saidaAntecipada.IdCoordenacao == 0)
                {
                    cmd.CommandText = cmd.CommandText.Replace("@IdCoordenacao,", "");
                    cmd.CommandText = cmd.CommandText.Replace("IdCoordenacao,", "");
                }
                else
                    cmd.Parameters.AddWithValue("@IdCoordenacao", saidaAntecipada.IdCoordenacao);

                cmd.Parameters.AddWithValue("@Motivo", saidaAntecipada.Motivo);
                cmd.Parameters.AddWithValue("@StatusSaida", saidaAntecipada.Status);
                cmd.Parameters.AddWithValue("@DataSaida", saidaAntecipada.DataSaida);
                cmd.Parameters.AddWithValue("@HoraSaida", saidaAntecipada.HoraSaida);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma saída antecipada no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<SaidasAntecipadas> BuscarTodos()
        {
            List<SaidasAntecipadas> saidasAntecipadas = new List<SaidasAntecipadas>();
            SaidasAntecipadas saidaAntecipada;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdAluno, IdProfessor, IdCoordenacao, Motivo, StatusSaida, DataSaida, HoraSaida FROM SaidasAntecipadas";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        saidaAntecipada = new SaidasAntecipadas();
                        saidaAntecipada.Id = Convert.ToInt32(rd["Id"]);
                        saidaAntecipada.IdAluno = Convert.ToInt32(rd["IdAluno"]);
                        saidaAntecipada.IdProfessor = Convert.ToInt32(rd["IdProfessor"]);
                        saidaAntecipada.IdCoordenacao = Convert.ToInt32(rd["IdCoordenacao"]);
                        saidaAntecipada.Motivo = rd["Motivo"].ToString();
                        saidaAntecipada.Status = rd["StatusSaida"].ToString();
                        saidaAntecipada.DataSaida = Convert.ToDateTime(rd["DataSaida"]);
                        saidaAntecipada.HoraSaida = (TimeSpan)rd["HoraSaida"];

                        saidaAntecipada.Aluno = new AlunoDAL().BuscarPorId(Convert.ToInt32(rd["IdAluno"]));
                        saidaAntecipada.Professor = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdProfessor"]));
                        saidaAntecipada.Coordenacao = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdCoordenacao"]));
                        saidasAntecipadas.Add(saidaAntecipada);
                    }
                }
                return saidasAntecipadas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as saídas antecipadas no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public SaidasAntecipadas BuscarPorId(int id)
        {
            SaidasAntecipadas saidaAntecipada = new SaidasAntecipadas();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT SaidasAntecipadas.Id, SaidasAntecipadas.IdAluno, SaidasAntecipadas.IdProfessor, SaidasAntecipadas.IdCoordenacao, 
                                  SaidasAntecipadas.Motivo, SaidasAntecipadas.StatusSaida, SaidasAntecipadas.DataSaida, SaidasAntecipadas.HoraSaida, 
                                  Aluno.Nome AS NomeAluno
                           FROM SaidasAntecipadas
                           LEFT JOIN Aluno ON SaidasAntecipadas.IdAluno = Aluno.Id
                           WHERE SaidasAntecipadas.Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        saidaAntecipada.Id = Convert.ToInt32(rd["Id"]);
                        saidaAntecipada.IdAluno = Convert.ToInt32(rd["IdAluno"]);
                        saidaAntecipada.IdProfessor = Convert.ToInt32(rd["IdProfessor"]);
                        saidaAntecipada.IdCoordenacao = Convert.ToInt32(rd["IdCoordenacao"]);
                        saidaAntecipada.Motivo = rd["Motivo"].ToString();
                        saidaAntecipada.Status = rd["StatusSaida"].ToString();
                        saidaAntecipada.DataSaida = Convert.ToDateTime(rd["DataSaida"]);
                        saidaAntecipada.HoraSaida = (TimeSpan)rd["HoraSaida"];

                        saidaAntecipada.Aluno = new AlunoDAL().BuscarPorId(Convert.ToInt32(rd["IdAluno"]));
                        saidaAntecipada.Professor = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdProfessor"]));
                        saidaAntecipada.Coordenacao = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdCoordenacao"]));

                        // Verifique se o campo "NomeAluno" não é nulo antes de atribuir ao objeto Aluno.
                        if (!rd.IsDBNull(rd.GetOrdinal("NomeAluno")))
                        {
                            Aluno aluno = new Aluno();
                            aluno.Nome = rd["NomeAluno"].ToString();
                            saidaAntecipada.Aluno = aluno;
                        }
                    }
                }
                return saidaAntecipada;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma saída antecipada no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<SaidasAntecipadas> BuscarPorNomeAluno(string nomeAluno)
        {
            // Use o método BuscarTodos para obter todas as saídas antecipadas
            List<SaidasAntecipadas> _todasSaidas = BuscarTodos();

            // Use LINQ para filtrar as saídas antecipadas com base no nome do aluno
            List<SaidasAntecipadas> alunoSaidasFiltradas = _todasSaidas
                .Where(s => s.Aluno != null && s.Aluno.Nome.Equals(nomeAluno, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return alunoSaidasFiltradas;
        }
        public List<SaidasAntecipadas> BuscarPorNomeProfessor(string nomeProfessor)
        {
            // Use o método BuscarTodos para obter todas as saídas antecipadas
            List<SaidasAntecipadas> _todasSaidas = BuscarTodos();

            // Use LINQ para filtrar as saídas antecipadas com base no nome do professor
            List<SaidasAntecipadas> professorSaidasFiltradas = _todasSaidas
                .Where(s => s.Professor != null && s.Professor.Nome.Equals(nomeProfessor, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return professorSaidasFiltradas;
        }
        public List<SaidasAntecipadas> BuscarPorNomeCoordenacao(string nomeCoordenador)
        {
            // Use o método BuscarTodos para obter todas as saídas antecipadas
            List<SaidasAntecipadas> _todasSaidas = BuscarTodos();

            // Use LINQ para filtrar as saídas antecipadas com base no nome do professor
            List<SaidasAntecipadas> coordenadorSaidasFiltradas = _todasSaidas
                .Where(s => s.Coordenacao != null && s.Coordenacao.Nome.Equals(nomeCoordenador, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return coordenadorSaidasFiltradas;
        }
        public void Alterar(SaidasAntecipadas saidaAntecipada)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE SaidasAntecipadas SET IdAluno = @IdAluno, IdProfessor = @IdProfessor, 
                                    IdCoordenacao = @IdCoordenacao, Motivo = @Motivo, StatusSaida = @StatusSaida, DataSaida = @DataSaida, HoraSaida = @HoraSaida
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdAluno", saidaAntecipada.IdAluno);
                cmd.Parameters.AddWithValue("@IdProfessor", saidaAntecipada.IdProfessor);
                cmd.Parameters.AddWithValue("@IdCoordenacao", saidaAntecipada.IdCoordenacao);
                cmd.Parameters.AddWithValue("@Motivo", saidaAntecipada.Motivo);
                cmd.Parameters.AddWithValue("@StatusSaida", saidaAntecipada.Status);
                cmd.Parameters.AddWithValue("@DataSaida", saidaAntecipada.DataSaida);
                cmd.Parameters.AddWithValue("@HoraSaida", saidaAntecipada.HoraSaida);
                cmd.Parameters.AddWithValue("@Id", saidaAntecipada.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma saída antecipada no banco de dados.", ex);
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
                cmd.CommandText = "DELETE FROM SaidasAntecipadas WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma saída antecipada do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}