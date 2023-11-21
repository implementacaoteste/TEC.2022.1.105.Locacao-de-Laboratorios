using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Professor _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Professor(Nome, NomeUsuario, Email, Senha, Matricula, Ativo) 
                                    VALUES(@Nome, @NomeUsuario, @Email, @Senha, @Matricula, @Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Matricula", _usuario.Matricula);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Professor> BuscarTodos()
        {
            List<Professor> usuarios = new List<Professor>();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdUser, Nome, NomeUsuario, Email, Senha, Matricula, Ativo FROM Professor";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Professor atividade = new Professor();
                        atividade.Id = Convert.ToInt32(rd["IdUser"]);
                        atividade.Nome = rd["Nome"].ToString();
                        atividade.NomeUsuario = rd["NomeUsuario"].ToString();
                        atividade.Email = rd["Email"].ToString();
                        atividade.Senha = rd["Senha"].ToString();
                        atividade.Matricula = rd["Matricula"].ToString();
                        atividade.Ativo = Convert.ToBoolean(rd["Ativo"]);

                        // Carregue os grupos de usuário relacionados a esse usuário
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        atividade.GrupoUsuarios = grupoUsuarioDAL.BuscarGrupoPorIdUsuario(atividade.Id);

                        usuarios.Add(atividade);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Professor BuscarPorNomeUsuario(string _nomeUsuario)
        {
            Professor atividade = new Professor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdUser, Nome, NomeUsuario, Email, Senha, Matricula, Ativo FROM Professor WHERE NomeUsuario = @NomeUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeUsuario", _nomeUsuario);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        atividade.Id = Convert.ToInt32(rd["IdUser"]);
                        atividade.Nome = rd["Nome"].ToString();
                        atividade.NomeUsuario = rd["NomeUsuario"].ToString();
                        atividade.Email = rd["Email"].ToString();
                        atividade.Senha = rd["Senha"].ToString();
                        atividade.Matricula = rd["Matricula"].ToString();
                        atividade.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return atividade;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuário pelo nome de usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Professor BuscarPorId(int _id)
        {
            Professor atividade;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                atividade = new Professor();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdUser, Nome, NomeUsuario, Email, Senha, Matricula, Ativo FROM Professor 
                                WHERE IdUser = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        atividade.Id = Convert.ToInt32(rd["IdUser"]);
                        atividade.Nome = rd["Nome"].ToString();
                        atividade.NomeUsuario = rd["NomeUsuario"].ToString();
                        atividade.Email = rd["Email"].ToString();
                        atividade.Senha = rd["Senha"].ToString();
                        atividade.Matricula = rd["Matricula"].ToString();
                        atividade.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }

                // Carregue os grupos de usuário relacionados a esse usuário
                GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                atividade.GrupoUsuarios = grupoUsuarioDAL.BuscarGrupoPorIdUsuario(_id);

                return atividade;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuário pelo ID no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Professor BuscarPorMatricula(string _matricula)
        {
            Professor atividade;
            atividade = new Professor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdUser, Nome, NomeUsuario, Email, Senha, Matricula, Ativo FROM Professor WHERE Matricula = @Matricula";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Matricula", _matricula);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        atividade.Id = Convert.ToInt32(rd["IdUser"]);
                        atividade.Nome = rd["Nome"].ToString();
                        atividade.NomeUsuario = rd["NomeUsuario"].ToString();
                        atividade.Email = rd["Email"].ToString();
                        atividade.Senha = rd["Senha"].ToString();
                        atividade.Matricula = rd["Matricula"].ToString();
                        atividade.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return atividade;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuário pela matrícula no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Professor> BuscarPorNome(string _nome)
        {
            List<Professor> usuarios = new List<Professor>();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdUser, Nome, NomeUsuario, Email, Senha, Matricula, Ativo FROM Professor WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Professor atividade = new Professor();
                        atividade.Id = Convert.ToInt32(rd["IdUser"]);
                        atividade.Nome = rd["Nome"].ToString();
                        atividade.NomeUsuario = rd["NomeUsuario"].ToString();
                        atividade.Email = rd["Email"].ToString();
                        atividade.Senha = rd["Senha"].ToString();
                        atividade.Matricula = rd["Matricula"].ToString();
                        atividade.Ativo = Convert.ToBoolean(rd["Ativo"]);

                        usuarios.Add(atividade);
                    }
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar os usuários pelo nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Professor _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Professor SET Nome = @Nome, NomeUsuario = @NomeUsuario, 
                            Email = @Email, Senha = @Senha, Matricula = @Matricula, Ativo = @Ativo 
                            WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Matricula", _usuario.Matricula);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@Id", _usuario.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar Alterar um usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Professor WHERE IdUser = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir o usuário do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        private void RemoverTodosGrupos(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM UsuarioGrupoUsuario WHERE IdUsuario = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _id);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir todos os grupos do usuário no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public bool ValidarPermissao(int _idUsuario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM  PermissaoGrupoUsuario 
                                    INNER JOIN UsuarioGrupoUsuario ON PermissaoGrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.IdGrupoUsuario
                                    WHERE UsuarioGrupoUsuario.IdUsuario = @IdUsuario AND PermissaoGrupoUsuario.IdPermissao = @IdPermissao";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar validar permissões do usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AdicionarGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO UsuarioGrupoUsuario(IdUsuario, IdGrupoUsuario) 
                                    VALUES(@IdUsuario, @IdGrupoUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar vincular um grupo a um usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool UsuarioPertenceAoGrupo(int _idUsuario, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM UsuarioGrupoUsuario 
                                    WHERE IdUsuario = @IdUsuario AND IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar existência de grupo vinculado ao usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void RemoverGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM UsuarioGrupoUsuario 
                                    WHERE IdUsuario = @IdUsuario AND IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar remover um grupo do usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public string ObterNomeUsuarioPorId(int _idUsuario)
        {
            string nomeUsuario = null;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT NomeUsuario FROM Professor WHERE IdUser = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idUsuario);
                cn.Open();

                nomeUsuario = cmd.ExecuteScalar() as string;
                return nomeUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o nome de usuário pelo ID no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public string ObterNomePorId(int _idUsuario)
        {
            string nomedoUsuario = null;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Nome FROM Professor WHERE IdUser = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idUsuario);
                cn.Open();

                nomedoUsuario = cmd.ExecuteScalar() as string;
                return nomedoUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o nome completo do usuário pelo ID no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
