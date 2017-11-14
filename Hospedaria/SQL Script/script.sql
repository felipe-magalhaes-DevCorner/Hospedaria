USE [Hospedaria]
GO
/****** Object:  Table [dbo].[CATEGORIA_PRODUTOS]    Script Date: 11/13/2017 6:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA_PRODUTOS](
	[idCATEGORIA] [int] NOT NULL,
	[DESCRICAO] [nchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIA_QUARTO]    Script Date: 11/13/2017 6:06:23 PM ******/
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
/****** Object:  Table [dbo].[CATEGORIAUSU]    Script Date: 11/13/2017 6:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAUSU](
	[idCATEGORIAUSU] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](150) NOT NULL,
	[powerlevel] [int] NOT NULL,
 CONSTRAINT [PK_CATEGORIAUSU] PRIMARY KEY CLUSTERED 
(
	[idCATEGORIAUSU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 11/13/2017 6:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[idCLIENTES] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [nchar](20) NOT NULL,
	[NOME] [nchar](100) NOT NULL,
	[TELEFONE] [nchar](20) NULL,
	[CELULAR] [nchar](20) NULL,
	[EMAIL] [nchar](100) NULL,
	[CIDADE] [nchar](100) NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[idCLIENTES] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONDICAO]    Script Date: 11/13/2017 6:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONDICAO](
	[idCONDICAO] [int] NOT NULL,
	[DESCRICAO] [nchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEPENDENTES]    Script Date: 11/13/2017 6:06:23 PM ******/
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
/****** Object:  Table [dbo].[FATURAMENTO]    Script Date: 11/13/2017 6:06:23 PM ******/
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
/****** Object:  Table [dbo].[HOSPEDAGEM]    Script Date: 11/13/2017 6:06:23 PM ******/
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
/****** Object:  Table [dbo].[PENSAO]    Script Date: 11/13/2017 6:06:23 PM ******/
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
/****** Object:  Table [dbo].[PRODUTOS]    Script Date: 11/13/2017 6:06:23 PM ******/
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
/****** Object:  Table [dbo].[RESERVAS]    Script Date: 11/13/2017 6:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESERVAS](
	[idRESERVA] [int] IDENTITY(1,1) NOT NULL,
	[idHOSPEDAGEM] [int] NOT NULL,
	[idCLIENTES] [int] NOT NULL,
	[DATARESERVA] [datetime] NOT NULL,
	[DATASAIDA] [datetime] NOT NULL,
 CONSTRAINT [PK_RESERVAS] PRIMARY KEY CLUSTERED 
(
	[idRESERVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SITUACAO]    Script Date: 11/13/2017 6:06:23 PM ******/
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
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 11/13/2017 6:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[idUSUARIOS] [int] IDENTITY(1,1) NOT NULL,
	[idCATEGORIAUSU] [int] NOT NULL,
	[NOME] [varchar](100) NOT NULL,
	[LOGIN] [varchar](50) NOT NULL,
	[SENHA] [varchar](50) NOT NULL,
	[SENHA_MESTRE] [varchar](50) NOT NULL,
	[logged] [bit] NOT NULL,
	[BAN] [bit] NOT NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[idUSUARIOS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENDAS]    Script Date: 11/13/2017 6:06:23 PM ******/
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
SET IDENTITY_INSERT [dbo].[CATEGORIAUSU] ON 

INSERT [dbo].[CATEGORIAUSU] ([idCATEGORIAUSU], [DESCRICAO], [powerlevel]) VALUES (1, N'Suporte', 4)
INSERT [dbo].[CATEGORIAUSU] ([idCATEGORIAUSU], [DESCRICAO], [powerlevel]) VALUES (2, N'Gerencia', 3)
INSERT [dbo].[CATEGORIAUSU] ([idCATEGORIAUSU], [DESCRICAO], [powerlevel]) VALUES (3, N'Recepção', 2)
INSERT [dbo].[CATEGORIAUSU] ([idCATEGORIAUSU], [DESCRICAO], [powerlevel]) VALUES (4, N'Garcon', 1)
INSERT [dbo].[CATEGORIAUSU] ([idCATEGORIAUSU], [DESCRICAO], [powerlevel]) VALUES (5, N'Estoquista', 0)
SET IDENTITY_INSERT [dbo].[CATEGORIAUSU] OFF
SET IDENTITY_INSERT [dbo].[CLIENTES] ON 

INSERT [dbo].[CLIENTES] ([idCLIENTES], [CPF], [NOME], [TELEFONE], [CELULAR], [EMAIL], [CIDADE]) VALUES (7, N'555.555.555-55      ', N'testecidade                                                                                         ', N'(55) 5555-5555      ', N'(55) 55555-5555     ', N'5555555555555                                                                                       ', N'555555555555                                                                                        ')
INSERT [dbo].[CLIENTES] ([idCLIENTES], [CPF], [NOME], [TELEFONE], [CELULAR], [EMAIL], [CIDADE]) VALUES (8, N'083.244.356-54      ', N'felipe                                                                                              ', N'(55) 5555-5555      ', N'(55) 55555-5555     ', N'fespa123@hotmail.com                                                                                ', N'bh                                                                                                  ')
SET IDENTITY_INSERT [dbo].[CLIENTES] OFF
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
SET IDENTITY_INSERT [dbo].[RESERVAS] ON 

INSERT [dbo].[RESERVAS] ([idRESERVA], [idHOSPEDAGEM], [idCLIENTES], [DATARESERVA], [DATASAIDA]) VALUES (1, 1, 7, CAST(N'2017-11-03T16:04:20.000' AS DateTime), CAST(N'2017-11-03T16:04:20.000' AS DateTime))
INSERT [dbo].[RESERVAS] ([idRESERVA], [idHOSPEDAGEM], [idCLIENTES], [DATARESERVA], [DATASAIDA]) VALUES (2, 1, 7, CAST(N'2017-11-03T16:11:47.000' AS DateTime), CAST(N'2017-11-03T16:11:47.000' AS DateTime))
INSERT [dbo].[RESERVAS] ([idRESERVA], [idHOSPEDAGEM], [idCLIENTES], [DATARESERVA], [DATASAIDA]) VALUES (3, 1, 7, CAST(N'2017-11-03T16:11:47.000' AS DateTime), CAST(N'2017-11-16T14:11:47.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[RESERVAS] OFF
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 

INSERT [dbo].[USUARIOS] ([idUSUARIOS], [idCATEGORIAUSU], [NOME], [LOGIN], [SENHA], [SENHA_MESTRE], [logged], [BAN]) VALUES (1, 1, N'Felipe', N'support', N'1234', N'12345678', 0, 0)
INSERT [dbo].[USUARIOS] ([idUSUARIOS], [idCATEGORIAUSU], [NOME], [LOGIN], [SENHA], [SENHA_MESTRE], [logged], [BAN]) VALUES (2, 2, N'Adriana', N'gerencia', N'1234', N'12345678', 0, 0)
INSERT [dbo].[USUARIOS] ([idUSUARIOS], [idCATEGORIAUSU], [NOME], [LOGIN], [SENHA], [SENHA_MESTRE], [logged], [BAN]) VALUES (3, 3, N'Rafaela', N'rafa_rec', N'1234', N'12345678', 0, 0)
INSERT [dbo].[USUARIOS] ([idUSUARIOS], [idCATEGORIAUSU], [NOME], [LOGIN], [SENHA], [SENHA_MESTRE], [logged], [BAN]) VALUES (4, 4, N'Julio', N'julio_garc', N'1234', N'12345678', 0, 1)
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
USE [master]
GO
ALTER DATABASE [Hospedaria] SET  READ_WRITE 
GO