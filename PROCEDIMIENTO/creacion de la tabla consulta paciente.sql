use veterinaria
create table Consulta_Paciente
(
	id_consulta int primary key identity,
	nombre_paciente varchar (30),
	cedula_paciente varchar(30),
	tipo_consulta varchar(30),
	tipo_mascota varchar(30)

)