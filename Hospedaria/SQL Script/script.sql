USE [Hospedaria]
GO
/****** Object:  Table [dbo].[VENDAS]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[VENDAS]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[USUARIOS]
GO
/****** Object:  Table [dbo].[SITUACAO]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[SITUACAO]
GO
/****** Object:  Table [dbo].[RESERVAS]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[RESERVAS]
GO
/****** Object:  Table [dbo].[PRODUTOS]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[PRODUTOS]
GO
/****** Object:  Table [dbo].[PENSAO]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[PENSAO]
GO
/****** Object:  Table [dbo].[HOSPEDAGEM]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[HOSPEDAGEM]
GO
/****** Object:  Table [dbo].[FATURAMENTO]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[FATURAMENTO]
GO
/****** Object:  Table [dbo].[DEPENDENTES]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[DEPENDENTES]
GO
/****** Object:  Table [dbo].[CONDICAO]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[CONDICAO]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[CLIENTES]
GO
/****** Object:  Table [dbo].[CATEGORIAUSU]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[CATEGORIAUSU]
GO
/****** Object:  Table [dbo].[CATEGORIA_QUARTO]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[CATEGORIA_QUARTO]
GO
/****** Object:  Table [dbo].[CATEGORIA_PRODUTOS]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP TABLE [dbo].[CATEGORIA_PRODUTOS]
GO
USE [master]
GO
/****** Object:  Database [Hospedaria]    Script Date: 10/31/2017 2:48:08 PM ******/
DROP DATABASE [Hospedaria]
GO
/****** Object:  Database [Hospedaria]    Script Date: 10/31/2017 2:48:08 PM ******/
CREATE DATABASE [Hospedaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospedaria', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Hospedaria.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Hospedaria_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Hospedaria_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Hospedaria] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospedaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospedaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospedaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospedaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospedaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospedaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospedaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hospedaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospedaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospedaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospedaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospedaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospedaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospedaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospedaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospedaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospedaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospedaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospedaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospedaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospedaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospedaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospedaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospedaria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hospedaria] SET  MULTI_USER 
GO
ALTER DATABASE [Hospedaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospedaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospedaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospedaria] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Hospedaria]
GO
/****** Object:  Table [dbo].[CATEGORIA_PRODUTOS]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA_PRODUTOS](
	[idCATEGORIA] [int] NOT NULL,
	[DESCRICAO] [nchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIA_QUARTO]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA_QUARTO](
	[idCATEGORIA_QUARTO] [int] NOT NULL,
	[DESCRICAO] [varchar](50) NOT NULL,
	[VALOR] [decimal](19, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIAUSU]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAUSU](
	[idCATEGORIAUSU] [int] NOT NULL,
	[DESCRICAO] [varchar](1) NULL,
	[CODIGO] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[idCLIENTES] [int] NOT NULL,
	[CPF] [nchar](20) NOT NULL,
	[NOME] [nchar](100) NOT NULL,
	[TELEFONE] [nchar](20) NULL,
	[CELULAR] [nchar](20) NULL,
	[EMAIL] [nchar](100) NULL,
	[CIDADE] [nchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONDICAO]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONDICAO](
	[idCONDICAO] [int] NOT NULL,
	[DESCRICAO] [nchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEPENDENTES]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPENDENTES](
	[idDEPENDENTES] [int] NOT NULL,
	[idSITUACAO] [int] NOT NULL,
	[idCLIENTES] [int] NOT NULL,
	[NOME] [nchar](100) NOT NULL,
	[IDADE] [int] NOT NULL,
	[HOSPEDADO] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FATURAMENTO]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FATURAMENTO](
	[idFATURAMENTO] [int] NOT NULL,
	[idVENDAS] [int] NULL,
	[idSITUACAO] [int] NOT NULL,
	[DEPENDENTES] [int] NULL,
	[HORAS_HOSPEDAGEM] [int] NOT NULL,
	[VALOR_HOSPEDAGEM] [decimal](19, 4) NOT NULL,
	[VALOR_VENDAS] [decimal](19, 4) NULL,
	[VALOR_TOTAL] [decimal](19, 4) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOSPEDAGEM]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOSPEDAGEM](
	[idHOSPEDAGEM] [int] NOT NULL,
	[idCATEGORIA] [int] NOT NULL,
	[NOME] [nchar](50) NOT NULL,
	[idCONDICAO] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PENSAO]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PENSAO](
	[idPENSAO] [int] NOT NULL,
	[DESCRICAO] [nchar](30) NOT NULL,
	[INCREMENTO] [decimal](19, 4) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUTOS]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUTOS](
	[idPRODUTOS] [int] NOT NULL,
	[idPENSAO] [int] NOT NULL,
	[idCATEGORIA] [int] NOT NULL,
	[NOME] [varchar](100) NOT NULL,
	[VALOR] [decimal](19, 4) NOT NULL,
	[ESTOQUE] [int] NOT NULL,
	[MASTER] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RESERVAS]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESERVAS](
	[idRESERVA] [int] IDENTITY(1,1) NOT NULL,
	[idHOSPEDAGEM] [int] NOT NULL,
	[idCLIENTES] [int] NOT NULL,
	[DATARESERVA] [datetime] NOT NULL,
 CONSTRAINT [PK_RESERVAS] PRIMARY KEY CLUSTERED 
(
	[idRESERVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SITUACAO]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SITUACAO](
	[idSITUACAO] [int] NOT NULL,
	[idHOSPEDAGEM] [int] NOT NULL,
	[idCLIENTES] [int] NOT NULL,
	[idPENSAO] [int] NOT NULL,
	[DATACHECKIN] [datetime] NOT NULL,
	[DATECHECKOUT] [datetime] NULL,
	[idUSUARIOS] [int] NOT NULL,
	[SITUACAO] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[idUSUARIOS] [int] NOT NULL,
	[idCATEGORIAUSU] [int] NOT NULL,
	[NOME] [varchar](1) NOT NULL,
	[LOGIN] [varchar](1) NOT NULL,
	[SENHA] [varchar](1) NOT NULL,
	[SENHA_MESTRE] [varchar](1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENDAS]    Script Date: 10/31/2017 2:48:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENDAS](
	[idVENDAS] [int] NOT NULL,
	[idSITUACAO] [int] NOT NULL,
	[idPRODUTOS] [int] NOT NULL,
	[QUANTIDADE] [int] NOT NULL,
	[VALOR] [decimal](19, 4) NOT NULL,
	[STATUS_PAGAMENTO] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CATEGORIA_QUARTO] ([idCATEGORIA_QUARTO], [DESCRICAO], [VALOR]) VALUES (1, N'STANDART', CAST(120.00 AS Decimal(19, 2)))
INSERT [dbo].[CATEGORIA_QUARTO] ([idCATEGORIA_QUARTO], [DESCRICAO], [VALOR]) VALUES (2, N'MASTER', CAST(230.00 AS Decimal(19, 2)))
INSERT [dbo].[CLIENTES] ([idCLIENTES], [CPF], [NOME], [TELEFONE], [CELULAR], [EMAIL], [CIDADE]) VALUES (7, N'555.555.555-55      ', N'testecidade                                                                                         ', N'(55) 5555-5555      ', N'(55) 55555-5555     ', N'5555555555555                                                                                       ', N'555555555555                                                                                        ')
INSERT [dbo].[CONDICAO] ([idCONDICAO], [DESCRICAO]) VALUES (1, N'Livre               ')
INSERT [dbo].[CONDICAO] ([idCONDICAO], [DESCRICAO]) VALUES (2, N'Ocupado             ')
INSERT [dbo].[CONDICAO] ([idCONDICAO], [DESCRICAO]) VALUES (3, N'Manutenção          ')
INSERT [dbo].[CONDICAO] ([idCONDICAO], [DESCRICAO]) VALUES (4, N'RESERVADO           ')
INSERT [dbo].[HOSPEDAGEM] ([idHOSPEDAGEM], [idCATEGORIA], [NOME], [idCONDICAO]) VALUES (1, 2, N'Suite Pink Floyd                                  ', 3)
INSERT [dbo].[HOSPEDAGEM] ([idHOSPEDAGEM], [idCATEGORIA], [NOME], [idCONDICAO]) VALUES (2, 2, N'Suite Rolling Stones                              ', 1)
INSERT [dbo].[HOSPEDAGEM] ([idHOSPEDAGEM], [idCATEGORIA], [NOME], [idCONDICAO]) VALUES (3, 1, N'Suite Dave Grohl                                  ', 1)
INSERT [dbo].[HOSPEDAGEM] ([idHOSPEDAGEM], [idCATEGORIA], [NOME], [idCONDICAO]) VALUES (4, 1, N'Quarto Bob Dylan                                  ', 1)
INSERT [dbo].[HOSPEDAGEM] ([idHOSPEDAGEM], [idCATEGORIA], [NOME], [idCONDICAO]) VALUES (5, 1, N'Quarto Janes                                      ', 1)
INSERT [dbo].[PRODUTOS] ([idPRODUTOS], [idPENSAO], [idCATEGORIA], [NOME], [VALOR], [ESTOQUE], [MASTER]) VALUES (1, 0, 1, N'Café', CAST(2.5000 AS Decimal(19, 4)), 100, 0)
INSERT [dbo].[PRODUTOS] ([idPRODUTOS], [idPENSAO], [idCATEGORIA], [NOME], [VALOR], [ESTOQUE], [MASTER]) VALUES (2, 0, 2, N'Pão de Queijo', CAST(3.5000 AS Decimal(19, 4)), 100, 0)
INSERT [dbo].[PRODUTOS] ([idPRODUTOS], [idPENSAO], [idCATEGORIA], [NOME], [VALOR], [ESTOQUE], [MASTER]) VALUES (3, 2, 2, N'Almoço', CAST(16.5000 AS Decimal(19, 4)), 100, 0)
INSERT [dbo].[PRODUTOS] ([idPRODUTOS], [idPENSAO], [idCATEGORIA], [NOME], [VALOR], [ESTOQUE], [MASTER]) VALUES (4, 0, 1, N'Agua', CAST(2.0000 AS Decimal(19, 4)), 100, 1)
INSERT [dbo].[PRODUTOS] ([idPRODUTOS], [idPENSAO], [idCATEGORIA], [NOME], [VALOR], [ESTOQUE], [MASTER]) VALUES (5, 0, 1, N'Refrigerante Lata', CAST(4.5000 AS Decimal(19, 4)), 100, 1)
USE [master]
GO
ALTER DATABASE [Hospedaria] SET  READ_WRITE 
GO
