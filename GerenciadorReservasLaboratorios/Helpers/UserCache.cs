using Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class UserCache
    {
        private static UserCache instance;

        private List<Usuario> usuarios;
        private Dictionary<string, List<Usuario>> usuariosPorGrupo; // Mapeia nomes de grupo para lista de usuários

        private UserCache()
        {
            usuarios = new List<Usuario>();
            usuariosPorGrupo = new Dictionary<string, List<Usuario>>();
        }

        public static UserCache Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserCache();
                }
                return instance;
            }
        }
        public List<Usuario> GetUsuariosPorGrupo(string nomeGrupo)
        {
            if (usuariosPorGrupo.ContainsKey(nomeGrupo))
            {
                return usuariosPorGrupo[nomeGrupo];
            }
            return new List<Usuario>(); // Retornar uma lista vazia se o grupo não estiver em cache
        }

        public void AtualizarCache()
        {
            // Obtenha uma lista de todos os usuários do banco de dados.
            List<Usuario> usuarios = new UsuarioDAL().BuscarTodos();

            // Recrie o cache de usuários por grupo
            usuariosPorGrupo.Clear();
            foreach (Usuario usuario in usuarios)
            {
                foreach (GrupoUsuario grupo in usuario.GrupoUsuarios)
                {
                    if (!usuariosPorGrupo.ContainsKey(grupo.NomeGrupo))
                    {
                        usuariosPorGrupo[grupo.NomeGrupo] = new List<Usuario>();
                    }
                    usuariosPorGrupo[grupo.NomeGrupo].Add(usuario);
                }
            }
        }


    }
}
