use [Clase 15];
insert into SECTORES (DESCRIPCION) values ('Legislación');
insert into EMPLEADOS (NOMBRE, APELLIDO, ID_SECTOR) values ('Jorge','Saenz',3);

--select * from EMPLEADOS where NOMBRE = 'Carlos' AND APELLIDO = 'fasfaw';

--select NOMBRE, APELLIDO from EMPLEADOS where ID = 2;

--select NOMBRE, APELLIDO from EMPLEADOS where NOMBRE like 'j%';
--select NOMBRE, APELLIDO from EMPLEADOS where NOMBRE like '____s';

--select * from EMPLEADOS where NOMBRE = 'Carlos' OR NOMBRE = 'juan';

--select * from EMPLEADOS where NOMBRE in ('Carlos', 'Juan');

--select E.APELLIDO, E.NOMBRE, S.DESCRIPCION from EMPLEADOS as E, SECTORES as S where e.ID_SECTOR = s.ID;
--select E.APELLIDO, E.NOMBRE, S.DESCRIPCION from EMPLEADOS as E left join SECTORES as S on E.ID_SECTOR = S.ID;

delete from EMPLEADOS where ID = 3;
select * from EMPLEADOS;
update EMPLEADOS set APELLIDO = '', NOMBRE = 'lalala' where APELLIDO = '';
