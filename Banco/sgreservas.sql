USE [master]
GO
/****** Object:  Database [sgreservas]    Script Date: 06/07/2023 20:41:17 ******/
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
/****** Object:  Table [dbo].[Aluno]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[Id] [int] NOT NULL,
	[Nome] [varchar](250) NOT NULL,
	[Matricula] [varchar](50) NOT NULL,
	[Email] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[Id] [int] NOT NULL,
	[Nome] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disciplina]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplina](
	[Id] [int] NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[Id_Curso] [int] NOT NULL,
 CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoUsuario]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoUsuario](
	[Id] [int] NOT NULL,
	[NomeGrupo] [varchar](50) NULL,
 CONSTRAINT [PK_GrupoUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissao]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissao](
	[Id] [int] NOT NULL,
	[Descricao] [varchar](250) NULL,
 CONSTRAINT [PK_Permissao] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissaoGrupoUsuario]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissaoGrupoUsuario](
	[IdPermissao] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Predio]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predio](
	[Id] [int] NOT NULL,
	[Nome] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Predio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Id] [int] NOT NULL,
	[IdSala] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdDisciplina] [int] NOT NULL,
	[IdCurso] [int] NOT NULL,
	[Solicitante] [varchar](150) NULL,
	[ReservaData] [date] NOT NULL,
	[ReservaHora] [datetime] NOT NULL DEFAULT CONVERT(TIME, GETDATE()),
	[DataRetirada] [datetime] NOT NULL DEFAULT GETDATE(),
	[DataDevolucao] [datetime] NOT NULL DEFAULT GETDATE(),
	[Status] [varchar](50) NOT NULL,
	[Observacoes] [text] NULL,
	[Turno] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaidasAntecipadas]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaidasAntecipadas](
	[Id] [int] NOT NULL,
	[IdAluno] [int] NOT NULL,
	[IdProfessor] [int] NOT NULL,
	[IdCoordenacao] [int] NOT NULL,
	[Motivo] [varchar](255) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[DataHoraSaida] [datetime] NOT NULL DEFAULT GETDATE(),
 CONSTRAINT [PK_SaidasAntecipadas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[Id] [int] NOT NULL,
	[IdPredio] [int] NOT NULL,
	[Nome] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] NOT NULL,
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
/****** Object:  Table [dbo].[UsuarioGrupoUsuario]    Script Date: 06/07/2023 20:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioGrupoUsuario](
	[IdUsuario] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL
) ON [PRIMARY]
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
