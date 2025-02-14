USE [veterinaria]
GO
/****** Object:  StoredProcedure [dbo].[sp_con_paciente]    Script Date: 18/5/2024 23:41:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_con_paciente] 
	@i_id_paciente int,
	@i_nomb_paciente varchar (30),
	@i_cedula_paciente varchar (30),
	@i_tipo_consulta varchar (30),
	@i_tipo_mascota varchar(30)
AS
BEGIN
	select id_consulta, nombre_paciente, cedula_paciente, tipo_consulta, tipo_mascota
	from veterinaria.dbo.Consulta_paciente 
	where  nombre_paciente = @i_nomb_paciente 
	or cedula_paciente = @i_cedula_paciente
	or tipo_consulta =@i_tipo_consulta
	or tipo_mascota =@i_tipo_mascota 
END
