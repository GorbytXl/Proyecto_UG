USE [veterinaria]
GO
/****** Object:  StoredProcedure [dbo].[sp_con_producto]    Script Date: 18/5/2024 23:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_con_producto]
	@i_id_producto int,
	@i_nomb_prod varchar(50),
	@i_descripcion varchar(50),
	@i_cantidad_stock int,
	@i_precio int,
	@i_tipo_producto varchar(30)
	
AS
BEGIN
	select * from veterinaria.dbo.producto
	where tipoProducto = @i_tipo_producto
END
