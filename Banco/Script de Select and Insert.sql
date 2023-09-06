SELECT DISTINCT P.IdPerm, P.Descricao, GU.IdGrupo, GU.NomeGrupo
FROM Permissao P
INNER JOIN PermissaoGrupoUsuario PGU ON P.IdPerm = PGU.IdPermissao
INNER JOIN GrupoUsuario GU ON PGU.IdGrupoUsuario = GU.IdGrupo ORDER BY GU.NomeGrupo;

DECLARE @NomeDoGrupo NVARCHAR(255) = 'Administrador'

-- Inserir todas as permissões para o grupo "Administrador"
INSERT INTO PermissaoGrupoUsuario (IdPermissao, IdGrupoUsuario)
SELECT P.Id, GU.Id
FROM Permissao P
CROSS JOIN GrupoUsuario GU
WHERE GU.NomeGrupo = @NomeDoGrupo;