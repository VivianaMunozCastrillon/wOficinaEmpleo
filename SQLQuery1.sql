use dboOficinaEmpleo;

create table tblEmpleado(
strTipoDocumento varchar(20),
intNumeroDocumento int,
strNombreEmpleado varchar(20),
strApellidoEmpleado varchar(20),
datFechaNacimiento date,
strNivelDeEstudios varchar(20),
strTituloAcademico varchar(20),
primary key(intNumeroDocumento)
);
 select * from tblEmpleado


 create table tblBuscarEmpleo(
intCodigoEmpleo int,
strNombreEmpleo varchar(25),
strDescripcionEmpleo varchar(50),
intRangoSalarial int,
intExperiencia int,
primary key(intCodigoEmpleo)
);

insert  into tblBuscarEmpleo(intCodigoEmpleo,strNombreEmpleo,StrDescripcionEmpleo,intRangoSalarial,intExperiencia)
values(1,'Psicologia','Tiempo Completo',6000000,6)
insert  into tblBuscarEmpleo(intCodigoEmpleo,strNombreEmpleo,strDescripcionEmpleo,intRangoSalarial,intExperiencia)
values(2,'Ingenieria','Trabajo Remoto',20000000,10)
insert  into tblBuscarEmpleo(intCodigoEmpleo,strNombreEmpleo,StrDescripcionEmpleo,intRangoSalarial,intExperiencia)
values(3,'Contaduria','Tiempo Completo',4000000,4)
insert  into tblBuscarEmpleo(intCodigoEmpleo,strNombreEmpleo,StrDescripcionEmpleo,intRangoSalarial,intExperiencia)
values(4,'Carpinteria','Tiempo Completp',1000000,3)
insert  into tblBuscarEmpleo(intCodigoEmpleo,strNombreEmpleo,StrDescripcionEmpleo,intRangoSalarial,intExperiencia)
values(5,'Docencia','Tiempo Completo',5000000,5)

select * from tblBuscarEmpleo