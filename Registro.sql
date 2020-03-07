create database Registro
use Registro

create table Estudiante(
Id_estudiante int primary key,
Nombre varchar(50),
Apellidos varchar(50),
Estatus float 
)
alter table estudiante add Carrera varchar(50)


insert into Estudiante(id_estudiante, nombre, apellidos, estatus)
Values(1, 'Amanda Massiel', 'Garcia Guillen', 1)

insert into Estudiante(id_estudiante, nombre, apellidos, estatus, carrera)
Values(2, 'Henry Alexander', 'Perez Ramirez', 0, 'Informatico')

insert into Estudiante(id_estudiante, nombre, apellidos, estatus, carrera)
Values(3, 'Jennifer', 'Decena', 1, 'Psicoligia')

insert into Estudiante(id_estudiante, nombre, apellidos, estatus, carrera)
Values(4, 'Francisco', 'Perez Ramirez', 1, 'Educacion Fisica')

insert into Estudiante(id_estudiante, nombre, apellidos, estatus, carrera)
Values(5, 'Madelyn', 'Rmona',0, 'Medicina')

insert into Estudiante(id_estudiante, nombre, apellidos, estatus, carrera)
Values(6, 'Florencio', 'Perez Sanchez', 1, 'Ingeniero')

insert into Estudiante(id_estudiante, nombre, apellidos, estatus, carrera)
Values(7, 'Jose', ' Sanchez', 0, 'Educacion')


select * from Estudiante