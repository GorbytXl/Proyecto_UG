
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE sp_grb_personal
				@i_id_Personal int,
				@i_nombre varchar (30),
				@i_cargo varchar (30),
				@i_cedula varchar (30),
				@i_edad int
AS
    declare 
	@w_registros int =0;
BEGIN
	
	select @w_registros = count(*)
	from veterinaria.dbo.Personal
	where id_Personal = @i_id_Personal
	
	if @w_registros > 0
	begin 
		update veterinaria.dbo.Personal 
		set nombre =@i_nombre,
			cargo = @i_cargo,
			cedula = @i_cedula,
			edad = @i_edad

			where id_Personal = @i_id_Personal
	end
	else 
	begin
		insert into veterinaria.dbo.Personal (
		nombre,
		cargo,
		cedula,
		edad)
		values
		(
			@i_nombre,
			@i_cargo,
			@i_cedula,
			@i_edad
		)
	end


END
GO
