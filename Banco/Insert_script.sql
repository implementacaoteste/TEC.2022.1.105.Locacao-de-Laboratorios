USE [master]
GO
ALTER DATABASE [sgreservas] SET SINGLE_USER WITH ROLLBACK IMMEDIATE 
GO
DROP DATABASE [sgreservas]
GO

/****** Object:  Database [sgreservas]    Script Date: 07/07/2023 21:50:38 ******/
CREATE DATABASE [sgreservas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sgreservas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\sgreservas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sgreservas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\sgreservas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sgreservas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sgreservas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sgreservas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sgreservas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sgreservas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sgreservas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sgreservas] SET ARITHABORT OFF 
GO
ALTER DATABASE [sgreservas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [sgreservas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sgreservas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sgreservas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sgreservas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sgreservas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sgreservas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sgreservas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sgreservas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sgreservas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sgreservas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sgreservas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sgreservas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sgreservas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sgreservas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sgreservas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sgreservas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sgreservas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sgreservas] SET  MULTI_USER 
GO
ALTER DATABASE [sgreservas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sgreservas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sgreservas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sgreservas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sgreservas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sgreservas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [sgreservas] SET QUERY_STORE = OFF
GO
USE [sgreservas]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](250) NOT NULL,
	[Matricula] [varchar](50) NOT NULL,
	[Email] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disciplina]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[IdCurso] [int] NOT NULL,
 CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoUsuario]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoUsuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeGrupo] [varchar](50) NULL,
 CONSTRAINT [PK_GrupoUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissao]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](250) NULL,
 CONSTRAINT [PK_Permissao] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissaoGrupoUsuario]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissaoGrupoUsuario](
	[IdPermissao] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Predio]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Predio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSala] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdDisciplina] [int] NOT NULL,
	[IdCurso] [int] NOT NULL,
	[Solicitante] [varchar](150) NULL,
	[ReservaData] [date] NOT NULL,
	[ReservaHora] [datetime] NOT NULL,
	[DataRetirada] [datetime] NOT NULL,
	[DataDevolucao] [datetime] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Observacoes] [text] NULL,
	[Turno] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaidasAntecipadas]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaidasAntecipadas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAluno] [int] NOT NULL,
	[IdProfessor] [int] NOT NULL,
	[IdCoordenacao] [int] NOT NULL,
	[Motivo] [varchar](255) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[DataHoraSaida] [datetime] NOT NULL,
 CONSTRAINT [PK_SaidasAntecipadas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPredio] [int] NOT NULL,
	[Nome] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[NomeUsuario] [varchar](150) NOT NULL,
	[Email] [varchar](150) NULL,
	[Senha] [varchar](50) NOT NULL,
	[Matricula] [varchar](50) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioGrupoUsuario]    Script Date: 28/08/2023 20:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioGrupoUsuario](
	[IdUsuario] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aluno] ON 

INSERT [dbo].[Aluno] ([Id], [Nome], [Matricula], [Email]) VALUES (1, N'Marcos Sena', N'RA00014222', N'marcossena@email.com')
INSERT [dbo].[Aluno] ([Id], [Nome], [Matricula], [Email]) VALUES (2, N'Andre Costa', N'RA00014220', N'andrecosta@email.com')
INSERT [dbo].[Aluno] ([Id], [Nome], [Matricula], [Email]) VALUES (3, N'Maria Augusta Cipriano', N'RA00014221', N'maraucipriano@email.com')
SET IDENTITY_INSERT [dbo].[Aluno] OFF
GO
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([Id], [Nome]) VALUES (1, N'Desenvolvimento de Sistemas')
INSERT [dbo].[Curso] ([Id], [Nome]) VALUES (2, N'Técnico em Segurança II')
INSERT [dbo].[Curso] ([Id], [Nome]) VALUES (3, N'Corte e Costura Industrial')
INSERT [dbo].[Curso] ([Id], [Nome]) VALUES (4, N'Excel Avançado')
SET IDENTITY_INSERT [dbo].[Curso] OFF
GO
SET IDENTITY_INSERT [dbo].[Disciplina] ON 

INSERT [dbo].[Disciplina] ([Id], [Nome], [IdCurso]) VALUES (1, N'Banco de Dados', 1)
INSERT [dbo].[Disciplina] ([Id], [Nome], [IdCurso]) VALUES (2, N'Programação de Aplicativos', 1)
INSERT [dbo].[Disciplina] ([Id], [Nome], [IdCurso]) VALUES (3, N'Eletroeletrônica', 1)
INSERT [dbo].[Disciplina] ([Id], [Nome], [IdCurso]) VALUES (4, N'Redes', 1)
INSERT [dbo].[Disciplina] ([Id], [Nome], [IdCurso]) VALUES (5, N'Lógica de Programação', 1)
INSERT [dbo].[Disciplina] ([Id], [Nome], [IdCurso]) VALUES (6, N'Prototipagem', 1)
INSERT [dbo].[Disciplina] ([Id], [Nome], [IdCurso]) VALUES (7, N'Moldes e Croquis', 3)
INSERT [dbo].[Disciplina] ([Id], [Nome], [IdCurso]) VALUES (8, N'wertyu', 4)
SET IDENTITY_INSERT [dbo].[Disciplina] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (1, N'João Silva', N'joaosilva', N'joao.silva@email.com', N'senha123', N'12345', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (2, N'Maria Santos', N'mariasantos', N'maria.santos@email.com', N'senha456', N'67890', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (3, N'Pedro Souza', N'pedrosouza', N'pedro.souza@email.com', N'senha789', N'54321', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (4, N'Ana Lima', N'analima', N'ana.lima@email.com', N'senhaabc', N'98765', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (5, N'Carlos Pereira', N'carlospereira', N'carlos.pereira@email.com', N'senhaxyz', N'24680', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (6, N'Lúcia Oliveira', N'luciaoliveira', N'lucia.oliveira@email.com', N'senhajkl', N'13579', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (7, N'Fernando Costa', N'fernandocosta', N'fernando.costa@email.com', N'senha321', N'11223', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (8, N'Amanda Gomes', N'amandagomes', N'amanda.gomes@email.com', N'senha789', N'45678', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (9, N'Ricardo Santos', N'ricardosantos', N'ricardo.santos@email.com', N'senha456', N'98765', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [NomeUsuario], [Email], [Senha], [Matricula], [Ativo]) VALUES (10, N'Juliana Alves', N'julianaalves', N'juliana.alves@email.com', N'senha123', N'34567', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[GrupoUsuario] ON 

INSERT [dbo].[GrupoUsuario] ([Nome]) VALUES (N'Administrador')
INSERT [dbo].[GrupoUsuario] ([Nome]) VALUES (N'Colaborador')
INSERT [dbo].[GrupoUsuario] ([Nome]) VALUES (N'Coordenação')
INSERT [dbo].[GrupoUsuario] ([Nome]) VALUES (N'Professor')
SET IDENTITY_INSERT [dbo].[GrupoUsuario] OFF
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermissaoGrupoUsuario_GrupoUsuario] FOREIGN KEY([IdGrupoUsuario])
REFERENCES [dbo].[GrupoUsuario] ([Id])
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario] CHECK CONSTRAINT [FK_PermissaoGrupoUsuario_GrupoUsuario]
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermissaoGrupoUsuario_Permissao] FOREIGN KEY([IdPermissao])
REFERENCES [dbo].[Permissao] ([Id])
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario] CHECK CONSTRAINT [FK_PermissaoGrupoUsuario_Permissao]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Curso] FOREIGN KEY([IdCurso])
REFERENCES [dbo].[Curso] ([Id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Curso]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Disciplina] FOREIGN KEY([IdDisciplina])
REFERENCES [dbo].[Disciplina] ([Id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Disciplina]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Sala] FOREIGN KEY([IdSala])
REFERENCES [dbo].[Sala] ([Id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Sala]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Usuario]
GO
ALTER TABLE [dbo].[SaidasAntecipadas]  WITH CHECK ADD  CONSTRAINT [FK_SaidasAntecipadas_Aluno] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[Aluno] ([Id])
GO
ALTER TABLE [dbo].[SaidasAntecipadas] CHECK CONSTRAINT [FK_SaidasAntecipadas_Aluno]
GO
ALTER TABLE [dbo].[SaidasAntecipadas]  WITH CHECK ADD  CONSTRAINT [FK_SaidasAntecipadas_Usuario] FOREIGN KEY([IdProfessor])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[SaidasAntecipadas] CHECK CONSTRAINT [FK_SaidasAntecipadas_Usuario]
GO
ALTER TABLE [dbo].[SaidasAntecipadas]  WITH CHECK ADD  CONSTRAINT [FK_SaidasAntecipadas_Usuario1] FOREIGN KEY([IdCoordenacao])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[SaidasAntecipadas] CHECK CONSTRAINT [FK_SaidasAntecipadas_Usuario1]
GO
ALTER TABLE [dbo].[Sala]  WITH CHECK ADD  CONSTRAINT [FK_Sala_Predio] FOREIGN KEY([IdPredio])
REFERENCES [dbo].[Predio] ([Id])
GO
ALTER TABLE [dbo].[Sala] CHECK CONSTRAINT [FK_Sala_Predio]
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioGrupoUsuario_GrupoUsuario] FOREIGN KEY([IdGrupoUsuario])
REFERENCES [dbo].[GrupoUsuario] ([Id])
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario] CHECK CONSTRAINT [FK_UsuarioGrupoUsuario_GrupoUsuario]
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioGrupoUsuario_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario] CHECK CONSTRAINT [FK_UsuarioGrupoUsuario_Usuario]
GO
USE [master]
GO
ALTER DATABASE [sgreservas] SET  READ_WRITE 
GO
