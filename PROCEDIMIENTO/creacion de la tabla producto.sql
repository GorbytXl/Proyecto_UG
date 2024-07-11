use veterinaria
create table producto
(
	id_producto int primary key identity,
	nombre_producto varchar (50),
	descripcion_Producto varchar (300),
	cantidadStock int,
	precio int,
	tipoProducto varchar (50)
	)