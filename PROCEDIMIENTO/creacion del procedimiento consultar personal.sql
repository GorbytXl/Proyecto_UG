USE [veterinaria]
GO
/****** Object:  StoredProcedure [dbo].[sp_con_personal]    Script Date: 18/5/2024 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_con_personal]
	@i_personal int,
	@i_nombre varchar (30),
	@i_cargo varchar (30),
	@i_cedula varchar (30),
	@i_edad int
AS
BEGIN
	select id_Personal, nombre, cargo, cedula, edad
	from veterinaria.dbo.Personal 
	where  nombre = @i_nombre 
	or cargo = @i_cargo
	or cedula =@i_cedula
	or edad =@i_edad 
END
