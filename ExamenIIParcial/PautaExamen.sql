create database Tienda
go
create schema factura
go
use Tienda 
go

create table factura.cliente (
	idCliente int primary key not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50),
)

create table factura.producto(
	idProducto int primary key not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
)
create table factura.Venta(
	idVenta int primary key not null,
	fechaVenta date,
	precio int,
	cantidad int,
	idCliente int foreign key references factura.cliente(idCliente),
	idProducto int foreign key references factura.producto(idProducto)
)
--------------------------------ingresarClientes------------------------------------------------------
create procedure ingresarClientes
@idCliente int,
@nombre varchar(25),
@apellido varchar(25),
@direccion varchar(50)

AS
BEGIN
insert into factura.cliente (idCliente,nombre,apellido,direccion) values
(@idCliente, @nombre, @apellido, @direccion)
END
--------------------------------------------------------------------------------------
create procedure ingresarProducto 
@idProducto int,
@nombreProducto varchar(40),
@descripcion varchar(50)
AS
BEGIN
insert into factura.producto(idProducto,nombreProducto,descripcion) values
(@idProducto,@nombreProducto,@descripcion)
END
--------------------------------------------------------------------------------------
create procedure ingresarVenta 
@idventa int,
@fechaVenta date,
@precio int,
@cantidad int,
@idCliente int,
@idProducto int
AS
BEGIN
insert into factura.Venta(idVenta,fechaVenta,precio,cantidad,idCliente,idProducto) values
(@idVenta,@fechaVenta,@precio,@cantidad,@idCliente,@idProducto)
END






-----------------------------consultar----------------------------------------------------------------
-----------------------------consultarClientes---------------------------------------------------------


create procedure consultarClientes 
AS 
BEGIN
select cl.idCliente,CONCAT(cl.nombre ,' ',cl.apellido) as 'Nombre Completo',cl.direccion from factura.cliente as cl 
END



-------------------------------consultarClienteIndividual-------------------------------------------------------
create procedure consultarClienteIndividual(@idCliente int)
AS 
BEGIN
select cl.idCliente,CONCAT(cl.nombre ,' ',cl.apellido) as 'Nombre Completo',cl.direccion from factura.cliente as cl 
where cl.idCliente = @idCliente
END
------------------------------consultarTablaVentas --------------------------------------------------------
alter procedure consultarVentas 
AS 
BEGIN
select cl.idCliente as 'ID', CONCAT(cl.nombre ,' ',cl.apellido) as 'Nombre Completo', pr.nombreProducto, v.cantidad, v.precio,v.fechaVenta from factura.Venta as v
inner join factura.cliente as cl on v.idCliente= cl.idCliente  
inner join factura.producto as pr on v.idProducto =  pr.idProducto 
END
----------------------------consultarVentaIndividual----------------------------------------------------------


create procedure consultarVentaIndividual(@nombre varchar(25))
AS 
BEGIN
select CONCAT(cl.nombre ,' ',cl.apellido) as 'Nombre Completo', pr.nombreProducto, v.cantidad, v.precio,v.fechaVenta from factura.Venta as v
inner join factura.cliente as cl on cl.idCliente = v.idCliente
inner join factura.producto as pr on pr.idProducto = v.idProducto
where cl.nombre = @nombre
END
----------------------------consultarVentaIndividual----------------------------------------------------------


create procedure consultarVentaExiste(@idventa int)
AS 
BEGIN
select * from factura.Venta 
where factura.Venta.idVenta = @idventa
END
-------------------------------create procedure-------------------------------------------------------
create procedure consultarProductos 
AS 
BEGIN
select pr.idProducto,pr.nombreProducto as 'Nombre Producto',pr.descripcion from factura.producto as pr
END

-----------------------------consultarProductoIndividual---------------------------------------------------------
create procedure consultarProductoIndividual(@idproducto int)
AS 
BEGIN
select pr.idProducto,pr.nombreProducto as 'Nombre Producto',pr.descripcion from factura.producto as pr
where pr.idProducto = @idproducto
END
exec consultarProductoIndividual 1





----------------------------------actualizar----------------------------------------------------
----------------------------------actualizarTablaClientes----------------------------------------------------
create procedure actualizarClientes(
@idCliente int,
@nombre varchar(25),
@apellido varchar(25),
@direccion varchar(50)
)
AS
BEGIN
update factura.cliente set nombre = @nombre, apellido=@apellido, direccion=@direccion  
where idCliente = @idCliente
End
------------------------------actualizarProducto--------------------------------------------------------
create procedure actualizarProducto (
@idProducto int,
@nombreProducto varchar(40),
@descripcion varchar(50)
)
AS
BEGIN
update factura.producto set nombreProducto=@nombreProducto, descripcion = @descripcion 
where idProducto = @idProducto
End
---------------------------------actualizarVentas-----------------------------------------------------
create procedure actualizarVentas (
@idventa int,
@precio int,
@cantidad int,
@idProducto int
)
AS
BEGIN
update factura.Venta set precio = @precio, cantidad=@cantidad, idProducto=@idProducto  
where idVenta = @idventa
End

--------------------------------------------------------------------------------------
create procedure eliminarCliente(@idcliente int)
AS
BEGIN
delete from factura.cliente where idCliente = @idcliente
END
--------------------------------------------------------------------------------------
create procedure eliminarProducto(@idproducto int)
AS
BEGIN
delete from factura.producto where idProducto = @idproducto
END
--------------------------------------------------------------------------------------
 create procedure eliminarVenta(@idventa int)
AS
BEGIN
delete from factura.Venta where idVenta = @idventa
END
--------------------------------------------------------------------------------------
exec ingresarClientes 1,'Elmer','Chandia','San Juan'
exec ingresarClientes 2,'Sandra','Calderon','Pozo Azul'
exec ingresarClientes 3,'Abdiel','Giron','San Jose'
exec ingresarProducto 1,'Coca,Cola','Medio Litro'
exec ingresarProducto 2,'Pepsi','Medio Litro'
exec ingresarProducto 1,'Chetos','Grandes'
exec ingresarVenta 1,'2020-07-08',20,2,1,1
exec ingresarVenta 2,'2019-07-08',20,3,2,2
exec consultarVentas 
exec consultarVentaExiste 0
