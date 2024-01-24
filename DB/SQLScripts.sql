--create schema
create database DB;

--insert after code first
insert into DB.dbo.Users (userName,userRole,userPassword) values ('admin',2,'admin');

insert into DB.dbo.Monedas (monedaName) values ('Pesos')
insert into DB.dbo.Monedas (monedaName) values ('Dolar')

insert into DB.dbo.Proveedors(proveedorName) values ('Axosnet')
insert into DB.dbo.Proveedors(proveedorName) values ('Microsoft')

insert into DB.dbo.Reciboes(proveedorID, monedaID,date,	comentario,	monto,userID) values (1,2,GETDATE(),'Datos',50.0,1);

