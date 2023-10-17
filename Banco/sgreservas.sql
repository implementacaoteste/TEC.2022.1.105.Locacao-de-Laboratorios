USE [master]
GO
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'sgreservas')
BEGIN
    ALTER DATABASE [sgreservas] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [sgreservas];
END
GO
/****** Object:  Database [sgreservas]    Script Date: 28/09/2023 15:18:02 ******/
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
/****** Object:  Table [dbo].[Aluno]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Nome] [varchar](250) NOT NULL,
    [Matricula] [varchar](50) NOT NULL,
    [Email] [varchar](200) NOT NULL,
    [CaminhoFoto] [varchar](500), -- Campo para o caminho da foto
    CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
    (
        [Id] ASC
    )
    WITH (
        PAD_INDEX = OFF, 
        STATISTICS_NORECOMPUTE = OFF, 
        IGNORE_DUP_KEY = OFF, 
        ALLOW_ROW_LOCKS = ON, 
        ALLOW_PAGE_LOCKS = ON, 
        OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](250) NOT NULL,
	[Turno] [varchar](150) NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursoDisciplina]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursoDisciplina](
	[IdCurso] [int] NOT NULL,
	[IdDisciplina] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disciplina]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoUsuario]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoUsuario](
	[IdGrupo] [int] IDENTITY(1,1) NOT NULL,
	[NomeGrupo] [varchar](50) NULL,
 CONSTRAINT [PK_GrupoUsuario] PRIMARY KEY CLUSTERED 
(
	[IdGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissao]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissao](
	[IdPerm] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](250) NULL,
 CONSTRAINT [PK_Permissao] PRIMARY KEY CLUSTERED 
(
	[IdPerm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissaoGrupoUsuario]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissaoGrupoUsuario](
	[IdPermissao] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Predio]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[Andares] [varchar](250) NOT NULL,
	[Descricao] [varchar](250) NOT NULL,
	[Estado] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Predio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recursos]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recursos](
	[Id] [int] NOT NULL,
	[Nome] [varchar](250) NOT NULL,
	[Marca] [varchar](250) NULL,
	[Tipo] [varchar](250) NULL,
 CONSTRAINT [PK_Recursos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecursosSalas]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecursosSalas](
	[IdSala] [int] NULL,
	[IdRecursos] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSala] [int] NOT NULL,
	[IdResponsavel] [int] NULL,
	[IdDisciplina] [int] NOT NULL,
	[IdCurso] [int] NOT NULL,
	[IdSolicitante] [int] NOT NULL,
	[ReservaDataInicial] [date] NOT NULL,
	[ReservaDataFinal] [date],
	[HoraInicial] [time] NOT NULL,
	[HoraFinal] [time],
	[DataRetirada] [datetime] NULL,
	[DataDevolucao] [datetime] NULL,
	[StatusReserva] [varchar](50) NOT NULL,
	[Observacoes] [text] NULL,
	[Turno] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaidasAntecipadas]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaidasAntecipadas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAluno] [int] NOT NULL,
	[IdProfessor] [int] NULL,
	[IdCoordenacao] [int] NULL,
	[Motivo] [varchar](255) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[DataHoraSaida] [datetime] NOT NULL,
 CONSTRAINT [PK_SaidasAntecipadas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[IdPredio] [int] NOT NULL,
	[Tipo] [varchar](200) NOT NULL,
	[Descricao] [varchar](255) NULL,
	[Estado] [varchar](255) NOT NULL,
	[Capacidade] [int] NOT NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[NomeUsuario] [varchar](150) NOT NULL,
	[Email] [varchar](150) NULL,
	[Senha] [varchar](50) NOT NULL,
	[Matricula] [varchar](50) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioGrupoUsuario]    Script Date: 28/09/2023 15:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioGrupoUsuario](
	[IdUsuario] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CursoDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CursoDisciplina_Curso] FOREIGN KEY([IdCurso])
REFERENCES [dbo].[Curso] ([Id])
GO
ALTER TABLE [dbo].[CursoDisciplina] CHECK CONSTRAINT [FK_CursoDisciplina_Curso]
GO
ALTER TABLE [dbo].[CursoDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CursoDisciplina_Disciplina] FOREIGN KEY([IdDisciplina])
REFERENCES [dbo].[Disciplina] ([Id])
GO
ALTER TABLE [dbo].[CursoDisciplina] CHECK CONSTRAINT [FK_CursoDisciplina_Disciplina]
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermissaoGrupoUsuario_GrupoUsuario] FOREIGN KEY([IdGrupoUsuario])
REFERENCES [dbo].[GrupoUsuario] ([IdGrupo])
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario] CHECK CONSTRAINT [FK_PermissaoGrupoUsuario_GrupoUsuario]
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermissaoGrupoUsuario_Permissao] FOREIGN KEY([IdPermissao])
REFERENCES [dbo].[Permissao] ([IdPerm])
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario] CHECK CONSTRAINT [FK_PermissaoGrupoUsuario_Permissao]
GO
ALTER TABLE [dbo].[RecursosSalas]  WITH CHECK ADD  CONSTRAINT [FK_RecursosSalas_Recursos] FOREIGN KEY([IdRecursos])
REFERENCES [dbo].[Recursos] ([Id])
GO
ALTER TABLE [dbo].[RecursosSalas] CHECK CONSTRAINT [FK_RecursosSalas_Recursos]
GO
ALTER TABLE [dbo].[RecursosSalas]  WITH CHECK ADD  CONSTRAINT [FK_RecursosSalas_Salas] FOREIGN KEY([IdSala])
REFERENCES [dbo].[Sala] ([Id])
GO
ALTER TABLE [dbo].[RecursosSalas] CHECK CONSTRAINT [FK_RecursosSalas_Salas]
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
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Usuario] FOREIGN KEY([IdResponsavel])
REFERENCES [dbo].[Usuario] ([IdUser])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Usuario]
GO
ALTER TABLE [dbo].[SaidasAntecipadas]  WITH CHECK ADD  CONSTRAINT [FK_SaidasAntecipadas_Aluno] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[Aluno] ([Id])
GO
ALTER TABLE [dbo].[SaidasAntecipadas] CHECK CONSTRAINT [FK_SaidasAntecipadas_Aluno]
GO
ALTER TABLE [dbo].[SaidasAntecipadas]  WITH CHECK ADD  CONSTRAINT [FK_SaidasAntecipadas_Usuario] FOREIGN KEY([IdProfessor])
REFERENCES [dbo].[Usuario] ([IdUser])
GO
ALTER TABLE [dbo].[SaidasAntecipadas] CHECK CONSTRAINT [FK_SaidasAntecipadas_Usuario]
GO
ALTER TABLE [dbo].[SaidasAntecipadas]  WITH CHECK ADD  CONSTRAINT [FK_SaidasAntecipadas_Usuario1] FOREIGN KEY([IdCoordenacao])
REFERENCES [dbo].[Usuario] ([IdUser])
GO
ALTER TABLE [dbo].[SaidasAntecipadas] CHECK CONSTRAINT [FK_SaidasAntecipadas_Usuario1]
GO
ALTER TABLE [dbo].[Sala]  WITH CHECK ADD  CONSTRAINT [FK_Sala_Predio] FOREIGN KEY([IdPredio])
REFERENCES [dbo].[Predio] ([Id])
GO
ALTER TABLE [dbo].[Sala] CHECK CONSTRAINT [FK_Sala_Predio]
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioGrupoUsuario_GrupoUsuario] FOREIGN KEY([IdGrupoUsuario])
REFERENCES [dbo].[GrupoUsuario] ([IdGrupo])
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario] CHECK CONSTRAINT [FK_UsuarioGrupoUsuario_GrupoUsuario]
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioGrupoUsuario_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUser])
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario] CHECK CONSTRAINT [FK_UsuarioGrupoUsuario_Usuario]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [CK_Turno_Valido] CHECK  (([Turno]='Noturno' OR [Turno]='Vespertino' OR [Turno]='Matutino'))
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [CK_Turno_Valido]
GO
USE [master]
GO
ALTER DATABASE [sgreservas] SET  READ_WRITE 
GO
