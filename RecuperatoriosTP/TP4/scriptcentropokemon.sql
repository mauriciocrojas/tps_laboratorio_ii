CREATE DATABASE [CentroPokemon]
GO
USE [CentroPokemon]
GO
/****** Object:  Table [dbo].[PokemonAlojados]    Script Date: 20/6/2022 00:03:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PokemonAlojados](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPokemon] [int] NULL,
	[Nombre] [nchar](50) NULL,
	[Tipo] [nchar](50) NULL,
	[AtaquePrincipal] [nchar](50) NULL,
	[Danio] [int] NULL
) ON [PRIMARY]

GO


