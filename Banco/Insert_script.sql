-- Inserts aqui

INSERT [dbo].[Aluno] ([Nome], [Matricula], [Email]) VALUES (N'Marcos Sena', N'RA00014222', N'marcossena@email.com')
INSERT [dbo].[Aluno] ([Nome], [Matricula], [Email]) VALUES (N'Andre Costa', N'RA00014220', N'andrecosta@email.com')
INSERT [dbo].[Aluno] ([Nome], [Matricula], [Email]) VALUES (N'Maria Augusta Cipriano', N'RA00014221', N'maraucipriano@email.com')

GO

INSERT INTO Curso (Nome)
VALUES
('Técnico em Desenvolvimento de Sistemas'),
('Alfaiataria sob Medida – Modelagem, Corte e Costura'),
('Técnico em Administração'),
('Alinhamento e Balanceamento Automotivo'),
('Técnico em Edificações'),
('Técnico em Informática Para Internet'),
('Técnico em Logística'),
('Assistente Administrativo'),
('Assistente de Recursos Humanos'),
('Auxiliar de Construção Civil'),
('Contabilidade Comercial'),
('Confeiteiro'),
('Desenvolvedor Mobile Android'),
('Instalador e Reparador de Redes de Computadores'),
('Introdução a Tecnologia da Informação e Comunicação'),
('Montador e Reparador de Computadores'),
('Operador de Computador'),
('Técnico em Manutenção e Suporte em Informática'),
('Técnico em Redes de Computadores'),
('Eletricista Instalador Residencial'),
('Instalador de Sistemas Fotovoltaicos'),
('Montador de Sistemas Fotovoltaicos'),
('Técnico em Eletrotécnica'),
('Eletricista de Automóveis'),
('Mecânico de Motocicletas'),
('Mecânico de Automóveis');

GO

-- Inserir disciplinas para o curso 'Técnico em Desenvolvimento de Sistemas' (Curso ID 1)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Lógica de Programação', 1),
('Banco de Dados', 1),
('Modelagem de Sistemas', 1),
('Desenvolvimento de Sistemas', 1),
('Implantação de Sistemas', 1),
('Programação de Aplicativos', 1);

-- Inserir disciplinas para o curso 'Alfaiataria sob Medida – Modelagem, Corte e Costura' (Curso ID 2)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Modelagem de Roupas', 2),
('Corte de Tecidos', 2),
('Costura à Mão', 2),
('Costura à Máquina', 2);

-- Inserir disciplinas para o curso 'Técnico em Administração' (Curso ID 3)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Administração Geral', 3),
('Contabilidade Financeira', 3),
('Gestão de Recursos Humanos', 3),
('Marketing e Vendas', 3);

-- Inserir disciplinas para o curso 'Alinhamento e Balanceamento Automotivo' (Curso ID 4)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Mecânica Automotiva Básica', 4),
('Alinhamento de Direção', 4),
('Balanceamento de Rodas', 4),
('Manutenção de Suspensão', 4);

-- Inserir disciplinas para o curso 'Técnico em Edificações' (Curso ID 5)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Desenho Técnico', 5),
('Fundações e Estruturas', 5),
('Instalações Prediais', 5),
('Orçamento e Planejamento', 5);

-- Inserir disciplinas para o curso 'Técnico em Informática Para Internet' (Curso ID 6)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Programação Web', 6),
('Banco de Dados', 6),
('Design de Interfaces', 6),
('Desenvolvimento Mobile', 6);

-- Inserir disciplinas para o curso 'Técnico em Logística' (Curso ID 7)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Gestão de Estoques', 7),
('Logística de Distribuição', 7),
('Cadeia de Suprimentos', 7),
('Transporte e Logística Internacional', 7);

-- Inserir disciplinas para o curso 'Assistente Administrativo' (Curso ID 8)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Atendimento ao Cliente', 8),
('Rotinas Administrativas', 8),
('Arquivamento e Documentação', 8),
('Comunicação Empresarial', 8);

-- Inserir disciplinas para o curso 'Assistente de Recursos Humanos' (Curso ID 9)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Gestão de Pessoas', 9),
('Recrutamento e Seleção', 9),
('Treinamento e Desenvolvimento', 9),
('Legislação Trabalhista', 9);

-- Inserir disciplinas para o curso 'Auxiliar de Construção Civil' (Curso ID 10)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Materiais de Construção', 10),
('Fundações e Estruturas', 10),
('Leitura de Projetos', 10),
('Técnicas de Construção', 10);

-- Inserir disciplinas para o curso 'Contabilidade Comercial' (Curso ID 11)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Contabilidade Básica', 11),
('Escrituração Fiscal', 11),
('Contabilidade de Custos', 11),
('Auditoria Contábil', 11);

-- Inserir disciplinas para o curso 'Confeiteiro' (Curso ID 12)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Confeitaria Básica', 12),
('Bolos e Tortas', 12),
('Doces e Sobremesas', 12),
('Panificação', 12);

-- Inserir disciplinas para o curso 'Desenvolvedor Mobile Android' (Curso ID 13)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Desenvolvimento Android', 13),
('Interface de Usuário', 13),
('Banco de Dados para Mobile', 13),
('Publicação de Aplicativos', 13);

-- Inserir disciplinas para o curso 'Instalador e Reparador de Redes de Computadores' (Curso ID 14)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Redes de Computadores', 14),
('Cabeamento Estruturado', 14),
('Configuração de Roteadores', 14),
('Segurança de Redes', 14);

-- Inserir disciplinas para o curso 'Introdução a Tecnologia da Informação e Comunicação' (Curso ID 15)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Fundamentos de TI', 15),
('Sistemas Operacionais', 15),
('Redes de Computadores', 15),
('Segurança da Informação', 15);

-- Inserir disciplinas para o curso 'Montador e Reparador de Computadores' (Curso ID 16)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Montagem de Computadores', 16),
('Manutenção de Hardware', 16),
('Diagnóstico e Reparo de Problemas', 16),
('Configuração de Sistemas', 16);

-- Inserir disciplinas para o curso 'Operador de Computador' (Curso ID 17)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Introdução à Informática', 17),
('Sistemas Operacionais', 17),
('Aplicativos de Escritório', 17),
('Navegação na Internet', 17);

-- Inserir disciplinas para o curso 'Técnico em Manutenção e Suporte em Informática' (Curso ID 18)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Manutenção de Hardware', 18),
('Suporte Técnico', 18),
('Redes de Computadores', 18),
('Sistemas Operacionais', 18);

-- Inserir disciplinas para o curso 'Técnico em Redes de Computadores' (Curso ID 19)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Administração de Redes', 19),
('Protocolos de Rede', 19),
('Segurança de Redes', 19),
('Configuração de Roteadores', 19);

-- Inserir disciplinas para o curso 'Eletricista Instalador Residencial' (Curso ID 20)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Eletricidade Básica', 20),
('Instalações Elétricas Residenciais', 20),
('Normas e Regulamentos', 20),
('Segurança em Eletricidade', 20);

-- Inserir disciplinas para o curso 'Instalador de Sistemas Fotovoltaicos' (Curso ID 21)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Energia Solar Fotovoltaica', 21),
('Instalação de Painéis Solares', 21),
('Manutenção de Sistemas Fotovoltaicos', 21),
('Normas e Segurança', 21);

-- Inserir disciplinas para o curso 'Montador de Sistemas Fotovoltaicos' (Curso ID 22)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Montagem de Sistemas Fotovoltaicos', 22),
('Dimensionamento de Sistemas Solares', 22),
('Manutenção de Painéis Solares', 22),
('Instalação Elétrica', 22);

-- Inserir disciplinas para o curso 'Técnico em Eletrotécnica' (Curso ID 23)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Eletricidade Industrial', 23),
('Comandos Elétricos', 23),
('Automação Industrial', 23),
('Manutenção Industrial', 23);

-- Inserir disciplinas para o curso 'Eletricista de Automóveis' (Curso ID 24)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Sistemas Elétricos de Veículos', 24),
('Diagnóstico e Reparo de Falhas', 24),
('Eletrônica Automotiva', 24),
('Manutenção de Veículos', 24);

-- Inserir disciplinas para o curso 'Mecânico de Motocicletas' (Curso ID 25)
INSERT INTO Disciplina (Nome, IdCurso)
VALUES
('Mecânica de Motocicletas', 25),
('Diagnóstico e Reparo de Motocicletas', 25),
('Sistemas de Combustão', 25),
('Manutenção Preventiva', 25);

GO
INSERT INTO [dbo].[Usuario] ([Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) 
VALUES 
    (N'Antonio Renato Barbosa', N'arbarbosa', N'arbarbosa@emailteste.com', N's123456', N'rfsenai123456', 1),
    (N'Claudio Martins', N'claudiom', N'claudiom@emailteste.com', N's234567', N'rfsenai234567', 1),
    (N'Bruno Pires', N'brunopi', N'brunopi@emailteste.com', N's345678', N'rfsenai345678', 1),
    (N'Erisvaldo Carvalho', N'admin', N'admin@emailteste.com', N's456789', N'rfsenai456789', 1),
    (N'João Silva', N'joaosilva', N'joao.silva@email.com', N'senha123', N'12345', 1),
    (N'Maria Santos', N'mariasantos', N'maria.santos@email.com', N'senha456', N'67890', 1),
    (N'Pedro Souza', N'pedrosouza', N'pedro.souza@email.com', N'senha789', N'54321', 1),
    (N'Ana Lima', N'analima', N'ana.lima@email.com', N'senhaabc', N'98765', 1),
    (N'Carlos Pereira', N'carlospereira', N'carlos.pereira@email.com', N'senhaxyz', N'24680', 1),
    (N'Lúcia Oliveira', N'luciaoliveira', N'lucia.oliveira@email.com', N'senhajkl', N'13579', 1),
    (N'Fernando Costa', N'fernandocosta', N'fernando.costa@email.com', N'senha321', N'11223', 1),
    (N'Amanda Gomes', N'amandagomes', N'amanda.gomes@email.com', N'senha789', N'45678', 1),
    (N'Ricardo Santos', N'ricardosantos', N'ricardo.santos@email.com', N'senha456', N'98765', 1),
    (N'Juliana Alves', N'julianaalves', N'juliana.alves@email.com', N'senha123', N'34567', 1);

GO

INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Criar Reservas')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Editar Reservas')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Cancelar Reservas')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Visualizar Reservas')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Criar Usuários')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Editar Usuários')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Excluir Usuários')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Criar Grupos de Usuários')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Editar Grupos de Usuários')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Excluir Grupos de Usuários')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Atribuir Permissões aos Grupos de Usuários')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Revogar Permissões dos Grupos de Usuários')
GO

INSERT [dbo].[GrupoUsuario] ([NomeGrupo]) VALUES (N'Administrador')
INSERT [dbo].[GrupoUsuario] ([NomeGrupo]) VALUES (N'Colaborador')
INSERT [dbo].[GrupoUsuario] ([NomeGrupo]) VALUES (N'Coordenação')
INSERT [dbo].[GrupoUsuario] ([NomeGrupo]) VALUES (N'Professor')
GO

INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (1, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (2, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (3, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (4, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (1, 2)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (4, 2)
GO

-- Simulando um INSERT na tabela UsuarioGrupoUsuario
INSERT INTO [dbo].[UsuarioGrupoUsuario] ([IdUsuario], [IdGrupoUsuario])
VALUES
    (1, 1),
    (2, 2),
    (3, 4),
    (4, 1),
    (5, 2),
    (6, 3), 
    (7, 3), 
    (8, 4),
    (9, 4),
    (10, 4),
    (13, 4),
    (14, 4);	
GO

