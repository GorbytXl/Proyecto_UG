
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE sp_grb_con_paciente
				@i_id_consulta int,
				@i_nomb_paciente varchar (30),
				@i_cedula_paciente varchar (30),
				@i_tipo_consulta varchar (30),
				@i_tipo_mascota varchar(30)

AS
	declare 
	@w_registros int =0;
BEGIN
	--
	select @w_registros = count(*)
	from veterinaria.dbo.Consulta_paciente 
	where id_consulta = @i_id_consulta;
	
	if @w_registros > 0
	begin 
		update veterinaria.dbo.Consulta_paciente 
		set nombre_paciente =@i_nomb_paciente,
			cedula_paciente = @i_cedula_paciente,
			tipo_consulta = @i_tipo_consulta,
			tipo_mascota = @i_tipo_mascota

			where id_consulta = @i_id_consulta
	end
	else 
	begin
		insert into veterinaria.dbo.Consulta_paciente (
		nombre_paciente,
		cedula_paciente,
		tipo_consulta,
		tipo_mascota)
		values
		(
			@i_nomb_paciente,
			@i_cedula_paciente,
			@i_tipo_consulta,
			@i_tipo_mascota
		)
	end

END
GO
