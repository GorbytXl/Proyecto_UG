USE [veterinaria]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 18/7/2024 20:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
	[mascotas_registradas] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mascotas]    Script Date: 18/7/2024 20:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mascotas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[especie] [varchar](50) NULL,
	[raza] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[propietario] [varchar](50) NULL,
	[historial_medico] [varchar](50) NULL,
 CONSTRAINT [PK_mascotas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[mascotas]  WITH CHECK ADD  CONSTRAINT [FK_mascotas_Clientes] FOREIGN KEY([id])
REFERENCES [dbo].[Clientes] ([id])
GO
ALTER TABLE [dbo].[mascotas] CHECK CONSTRAINT [FK_mascotas_Clientes]
GO
