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

-- Para reiniciar o valor de identidade de uma coluna em uma tabela!

DBCC CHECKIDENT ('Aluno', RESEED, 1);
DBCC CHECKIDENT ('Curso', RESEED, 1);
DBCC CHECKIDENT ('Disciplina', RESEED, 1);
DBCC CHECKIDENT ('GrupoUsuario', RESEED, 1);
DBCC CHECKIDENT ('Permissao', RESEED, 1);
DBCC CHECKIDENT ('Predio', RESEED, 1);
DBCC CHECKIDENT ('Reserva', RESEED, 1);
DBCC CHECKIDENT ('SaidasAntecipadas', RESEED, 1);
DBCC CHECKIDENT ('Sala', RESEED, 1);
DBCC CHECKIDENT ('Usuario', RESEED, 1);