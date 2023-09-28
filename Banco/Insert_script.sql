-- Inserts aqui
INSERT INTO [dbo].[GrupoUsuario] ([NomeGrupo]) VALUES (N'Administrador')
INSERT INTO [dbo].[GrupoUsuario] ([NomeGrupo]) VALUES (N'Colaborador')
INSERT INTO [dbo].[GrupoUsuario] ([NomeGrupo]) VALUES (N'Coordenação')
INSERT INTO [dbo].[GrupoUsuario] ([NomeGrupo]) VALUES (N'Professor')
GO

INSERT INTO [dbo].[Aluno] ([Nome], [Matricula], [Email]) VALUES (N'Marcos Sena', N'RA00014222', N'marcossena@email.com')
INSERT INTO [dbo].[Aluno] ([Nome], [Matricula], [Email]) VALUES (N'Andre Costa', N'RA00014220', N'andrecosta@email.com')
INSERT INTO [dbo].[Aluno] ([Nome], [Matricula], [Email]) VALUES (N'Maria Augusta Cipriano', N'RA00014221', N'maraucipriano@email.com')
INSERT INTO [dbo].[Aluno] ([Nome], [Matricula], [Email]) VALUES (N'Alexandra Pereira Santana', N'RA00014227', N'alexapsanta@email.com')
INSERT INTO [dbo].[Aluno] ([Nome], [Matricula], [Email]) VALUES (N'Francisca Pinheiro Neves', N'RA00014229', N'francpneves@email.com')
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
    (N'Juliana Alves', N'julianaalves', N'juliana.alves@email.com', N'senha123', N'34567', 1),
    (N'João Carlos Silva', N'jcsilva', N'jcsilva@emailteste.com', N's123456', N'rfsenai123457', 1),
    (N'Maria Clara Santos', N'mcsantos', N'mcsantos@emailteste.com', N's123456', N'rfsenai123458', 1),
    (N'Pedro Paulo Costa', N'ppcosta', N'ppcosta@emailteste.com', N's123456', N'rfsenai123459', 1),
    (N'Ana Beatriz Lima', N'ablima', N'ablima@emailteste.com', N's123456', N'rfsenai123460', 1),
    (N'Lucas Gabriel Souza', N'lgsouza', N'lgsouza@emailteste.com', N's123456', N'rfsenai123461', 1),
    (N'Julia Carolina Alves', N'jcalves', N'jcalves@emailteste.com', N's123456', N'rfsenai123462', 1);

GO

INSERT INTO Curso (Nome, Turno)
VALUES
('Técnico em Desenvolvimento de Sistemas', 'Noturno'),
('Alfaiataria sob Medida – Modelagem, Corte e Costura', 'Matutino'),
('Técnico em Administração', 'Noturno'),
('Alinhamento e Balanceamento Automotivo', 'Matutino'),
('Técnico em Edificações', 'Vespertino'),
('Técnico em Informática Para Internet', 'Noturno'),
('Técnico em Logística', 'Matutino'),
('Assistente Administrativo', 'Matutino'),
('Assistente de Recursos Humanos', 'Vespertino'),
('Auxiliar de Construção Civil', 'Vespertino'),
('Contabilidade Comercial', 'Vespertino'),
('Confeiteiro', 'Matutino'),
('Desenvolvedor Mobile Android', 'Noturno'),
('Instalador e Reparador de Redes de Computadores', 'Noturno'),
('Introdução a Tecnologia da Informação e Comunicação', 'Noturno'),
('Montador e Reparador de Computadores', 'Noturno'),
('Operador de Computador', 'Noturno'),
('Técnico em Manutenção e Suporte em Informática', 'Noturno'),
('Técnico em Redes de Computadores', 'Noturno'),
('Eletricista Instalador Residencial', 'Matutino'),
('Instalador de Sistemas Fotovoltaicos', 'Noturno'),
('Montador de Sistemas Fotovoltaicos', 'Noturno'),
('Técnico em Eletrotécnica', 'Vespertino'),
('Eletricista de Automóveis', 'Matutino'),
('Mecânico de Motocicletas', 'Noturno'),
('Mecânico de Automóveis', 'Matutino');
GO

-- Inserir disciplinas para o curso 'Técnico em Desenvolvimento de Sistemas' (Curso ID 1)
INSERT INTO Disciplina (Nome)
VALUES
('Lógica de Programação'),
('Banco de Dados'),
('Modelagem de Sistemas'),
('Desenvolvimento de Sistemas'),
('Implantação de Sistemas'),
('Programação de Aplicativos');

-- Inserir disciplinas para o curso 'Alfaiataria sob Medida – Modelagem, Corte e Costura' (Curso ID 2)
INSERT INTO Disciplina (Nome)
VALUES
('Modelagem de Roupas'),
('Corte de Tecidos'),
('Costura à Mão'),
('Costura à Máquina');

-- Inserir disciplinas para o curso 'Técnico em Administração' (Curso ID 3)
INSERT INTO Disciplina (Nome)
VALUES
('Administração Geral'),
('Contabilidade Financeira'),
('Gestão de Recursos Humanos'),
('Marketing e Vendas');

-- Inserir disciplinas para o curso 'Alinhamento e Balanceamento Automotivo' (Curso ID 4)
INSERT INTO Disciplina (Nome)
VALUES
('Mecânica Automotiva Básica'),
('Alinhamento de Direção'),
('Balanceamento de Rodas'),
('Manutenção de Suspensão');

-- Inserir disciplinas para o curso 'Técnico em Edificações' (Curso ID 5)
INSERT INTO Disciplina (Nome)
VALUES
('Desenho Técnico'),
('Fundações e Estruturas'),
('Instalações Prediais'),
('Orçamento e Planejamento');

-- Inserir disciplinas para o curso 'Técnico em Informática Para Internet' (Curso ID 6)
INSERT INTO Disciplina (Nome)
VALUES
('Programação Web'),
('Banco de Dados'),
('Design de Interfaces'),
('Desenvolvimento Mobile');

-- Inserir disciplinas para o curso 'Técnico em Logística' (Curso ID 7)
INSERT INTO Disciplina (Nome)
VALUES
('Gestão de Estoques'),
('Logística de Distribuição'),
('Cadeia de Suprimentos'),
('Transporte e Logística Internacional');

-- Inserir disciplinas para o curso 'Assistente Administrativo' (Curso ID 8)
INSERT INTO Disciplina (Nome)
VALUES
('Atendimento ao Cliente'),
('Rotinas Administrativas'),
('Arquivamento e Documentação'),
('Comunicação Empresarial');

-- Inserir disciplinas para o curso 'Assistente de Recursos Humanos' (Curso ID 9)
INSERT INTO Disciplina (Nome)
VALUES
('Gestão de Pessoas'),
('Recrutamento e Seleção'),
('Treinamento e Desenvolvimento'),
('Legislação Trabalhista');

-- Inserir disciplinas para o curso 'Auxiliar de Construção Civil' (Curso ID 10)
INSERT INTO Disciplina (Nome)
VALUES
('Materiais de Construção'),
('Fundações e Estruturas'),
('Leitura de Projetos'),
('Técnicas de Construção');

-- Inserir disciplinas para o curso 'Contabilidade Comercial' (Curso ID 11)
INSERT INTO Disciplina (Nome)
VALUES
('Contabilidade Básica'),
('Escrituração Fiscal'),
('Contabilidade de Custos'),
('Auditoria Contábil');

-- Inserir disciplinas para o curso 'Confeiteiro' (Curso ID 12)
INSERT INTO Disciplina (Nome)
VALUES
('Confeitaria Básica'),
('Bolos e Tortas'),
('Doces e Sobremesas'),
('Panificação');

-- Inserir disciplinas para o curso 'Desenvolvedor Mobile Android' (Curso ID 13)
INSERT INTO Disciplina (Nome)
VALUES
('Desenvolvimento Android'),
('Interface de Usuário'),
('Banco de Dados para Mobile'),
('Publicação de Aplicativos');

-- Inserir disciplinas para o curso 'Instalador e Reparador de Redes de Computadores' (Curso ID 14)
INSERT INTO Disciplina (Nome)
VALUES
('Redes de Computadores'),
('Cabeamento Estruturado'),
('Configuração de Roteadores'),
('Segurança de Redes');

-- Inserir disciplinas para o curso 'Introdução a Tecnologia da Informação e Comunicação' (Curso ID 15)
INSERT INTO Disciplina (Nome)
VALUES
('Fundamentos de TI'),
('Sistemas Operacionais'),
('Redes de Computadores'),
('Segurança da Informação');

-- Inserir disciplinas para o curso 'Montador e Reparador de Computadores' (Curso ID 16)
INSERT INTO Disciplina (Nome)
VALUES
('Montagem de Computadores'),
('Manutenção de Hardware'),
('Diagnóstico e Reparo de Problemas'),
('Configuração de Sistemas');

-- Inserir disciplinas para o curso 'Operador de Computador' (Curso ID 17)
INSERT INTO Disciplina (Nome)
VALUES
('Introdução à Informática'),
('Sistemas Operacionais'),
('Aplicativos de Escritório'),
('Navegação na Internet');

-- Inserir disciplinas para o curso 'Técnico em Manutenção e Suporte em Informática' (Curso ID 18)
INSERT INTO Disciplina (Nome)
VALUES
('Manutenção de Hardware'),
('Suporte Técnico'),
('Redes de Computadores'),
('Sistemas Operacionais');

-- Inserir disciplinas para o curso 'Técnico em Redes de Computadores' (Curso ID 19)
INSERT INTO Disciplina (Nome)
VALUES
('Administração de Redes'),
('Protocolos de Rede'),
('Segurança de Redes'),
('Configuração de Roteadores');

-- Inserir disciplinas para o curso 'Eletricista Instalador Residencial' (Curso ID 20)
INSERT INTO Disciplina (Nome)
VALUES
('Eletricidade Básica'),
('Instalações Elétricas Residenciais'),
('Normas e Regulamentos'),
('Segurança em Eletricidade');

-- Inserir disciplinas para o curso 'Instalador de Sistemas Fotovoltaicos' (Curso ID 21)
INSERT INTO Disciplina (Nome)
VALUES
('Energia Solar Fotovoltaica'),
('Instalação de Painéis Solares'),
('Manutenção de Sistemas Fotovoltaicos'),
('Normas e Segurança');

-- Inserir disciplinas para o curso 'Montador de Sistemas Fotovoltaicos' (Curso ID 22)
INSERT INTO Disciplina (Nome)
VALUES
('Montagem de Sistemas Fotovoltaicos'),
('Dimensionamento de Sistemas Solares'),
('Manutenção de Painéis Solares'),
('Instalação Elétrica');

-- Inserir disciplinas para o curso 'Técnico em Eletrotécnica' (Curso ID 23)
INSERT INTO Disciplina (Nome)
VALUES
('Eletricidade Industrial'),
('Comandos Elétricos'),
('Automação Industrial'),
('Manutenção Industrial');

-- Inserir disciplinas para o curso 'Eletricista de Automóveis' (Curso ID 24)
INSERT INTO Disciplina (Nome)
VALUES
('Sistemas Elétricos de Veículos'),
('Diagnóstico e Reparo de Falhas'),
('Eletrônica Automotiva'),
('Manutenção de Veículos');

-- Inserir disciplinas para o curso 'Mecânico de Motocicletas' (Curso ID 25)
INSERT INTO Disciplina (Nome)
VALUES
('Mecânica de Motocicletas'),
('Diagnóstico e Reparo de Motocicletas'),
('Sistemas de Combustão'),
('Manutenção Preventiva');


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
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Criar Saídas Antecipadas')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Editar Saídas Antecipadas')
INSERT [dbo].[Permissao] ([Descricao]) VALUES (N'Excluir Saídas Antecipadas')
GO

INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (1, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (2, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (3, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (4, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (5, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (6, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (7, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (8, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (9, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (10, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (11, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (12, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (2, 2)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (4, 2)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (1, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (2, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (3, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (4, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (5, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (6, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (7, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (11, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (1, 4)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (2, 4)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (3, 4)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (4, 4)

INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (13, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (14, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (15, 3)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (13, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (14, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (15, 1)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (13, 4)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (14, 4)
INSERT [dbo].[PermissaoGrupoUsuario] ([IdPermissao], [IdGrupoUsuario]) VALUES (15, 4)

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
    (11, 4),
    (12, 4),
    (13, 2),
    (14, 4),
    (15, 4),
    (16, 3),
    (17, 3),
    (18, 3),
    (19, 4),	
    (20, 4);
GO

INSERT INTO Predio (Nome, Andares, Descricao, Estado)
VALUES ('Prédio A', '1', 'Prédio principal', 'Ativo');

INSERT INTO Predio (Nome, Andares, Descricao, Estado)
VALUES ('Prédio B', '2', 'Núcleo Tecnológico', 'Inativo');

INSERT INTO Sala (Nome, IdPredio, Tipo, Descricao, Estado, Capacidade)
VALUES ('Sala 101', 1, 'Sala de Aula', 'Sala para aulas teóricas', 'Disponível', 30);

INSERT INTO Sala (Nome, IdPredio, Tipo, Descricao, Estado, Capacidade)
VALUES ('Sala 201', 2, 'Sala de Reuniões', 'Sala de reuniões pequena', 'Indisponível', 10);

-- Exemplos de inserção na tabela Reserva
INSERT INTO Reserva (IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno)
VALUES (1, 2, 3, 4, 5, '2023-09-30', '2023-09-30 14:00:00', '2023-09-30 15:00:00', '2023-09-30 17:00:00', 'Pendente', 'Observação 1', 'Manhã');

INSERT INTO Reserva (IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno)
VALUES (2, 3, 4, 5, 6, '2023-10-05', '2023-10-05 10:00:00', '2023-10-05 11:00:00', '2023-10-05 13:00:00', 'Aprovada', 'Observação 2', 'Tarde');