xp_create_subdir 'C:\DataMiniMarket'
go
xp_create_subdir 'D:\Info'
go

create database MINIMARKET
     on Primary
     (name = 'MiniMarket01', filename = 'D:\Info\MiniMarket01.mdf',Size = 20MB,
     MaxSize = 40GB, filegrowth = 100MB),
	 (name = 'MiniMarket02', filename = 'C:\DataMiniMarket\MiniMarket02.ndf',Size = 20MB,
     MaxSize = 20GB, filegrowth = 100MB),
	 filegroup PRODUCTO
	 (name = 'Producto01', filename = 'D:\Info\Producto01.ndf',Size = 50MB, MaxSize = 10GB, filegrowth = 100MB),
	 (name = 'Producto02', filename = 'D:\Info\Producto02.ndf',Size = 50MB, MaxSize = 20GB, filegrowth = 100MB),
	 filegroup COMPRA
	 (name = 'Compra01', filename = 'D:\Info\Compra01.ndf',Size = 60MB, MaxSize = 10GB, filegrowth = 100MB),
	 (name = 'Compra02', filename = 'D:\Info\Compra02.ndf',Size = 80MB, MaxSize = 20GB, filegrowth = 100MB),
	 filegroup VENTA
	 (name = 'Venta01', filename = 'D:\Info\Venta01.ndf',Size = 80MB, MaxSize = 15GB, filegrowth = 100MB),
	 (name = 'Venta02', filename = 'D:\Info\Venta02.ndf',Size = 100MB, MaxSize = 10GB, filegrowth = 100MB)
	 log on
	 (name = 'TransaccionesLog01', filename = 'D:\Info\TransaccionesLog01.ldf', Size = 80MB, MaxSize = 20GB, filegrowth = 100MB),
	 (name = 'TransaccionesLog02', filename = 'D:\Info\TransaccionesLog02.ldf', Size = 80MB, MaxSize = 20GB, filegrowth = 100MB)
go

use MINIMARKET
go

if not exists
	(select name from sys.filegroups where name = 'ACCESO')
	begin
		alter database MINIMARKET add filegroup ACCESO
	end
go

if exists
	(select name from sys.filegroups where name = 'VENTA')
	begin
		alter database MINIMARKET modify filegroup VENTA name = DISTRIBUCION
	end
go

if not exists
	(select name from sys.database_files where name = 'Usuario')
	begin
		alter database MINIMARKET add file 
		(name = 'Usuario', filename = 'C:\DataMiniMarket\Usuario.ndf',Size = 60MB, MaxSize = 2GB, filegrowth = 100MB)
	to filegroup ACCESO
	end
go

if not exists
	(select name from sys.database_files where name = 'Permiso')
	begin
		alter database MINIMARKET add file 
		(name = 'Permiso', filename = 'C:\DataMiniMarket\Permiso.ndf',Size = 30MB, MaxSize = 2GB, filegrowth = 100MB)
	to filegroup ACCESO
	end
go

if not exists
	(select name from sys.database_files where name = 'Funcion')
	begin
		alter database MINIMARKET add file 
		(name = 'Funcion', filename = 'C:\DataMiniMarket\Funcion.ndf',Size = 20MB, MaxSize = 1GB, filegrowth = 100MB)
	to filegroup ACCESO
	end
go

if not exists
	(select name from sys.database_files where name = 'Registro01')
	begin
	alter database MINIMARKET add log file
		(name = 'Registro01', filename = 'D:\Info\Registro01.ldf')
	end
go

if not exists
	(select name from sys.schemas where name = 'dbMiniMarket')
	begin
		execute('create schema dbMiniMarket')
	end
go

if not exists
	(select name from sys.schemas where name = 'programaIngreso')
	begin
		execute('create schema programaIngreso')
	end
go

create table programaIngreso.Funcion(
	FuncionCodigo int Primary key not null identity(1,1),
	FuncionDescripcion nvarchar(25) not null,
	FuncionFechaRegistro date constraint FuncionFechaRegistroDF default getDate()	
	constraint FuncionFechaRegistroCK check (FuncionFechaRegistro <= getDate()),
	constraint FuncionDescripcionUQ unique (FuncionDescripcion),
	)
	on ACCESO
go

create table programaIngreso.Permiso(
	PermisoCodigo int Primary key not null identity(1,1),
	PermisoFuncionCodigo int,
	PermisoNombreMenu nvarchar(70),
	PermisoFechaRegistro date constraint PermisoFechaRegistroDF default getDate(),
	constraint PermisoFechaRegistroCK check (PermisoFechaRegistro <= getDate()),
	constraint PermisoFuncionFK foreign key (PermisoFuncionCodigo)
		references ProgramaIngreso.Funcion(FuncionCodigo)
	)
	on ACCESO
go

create table programaIngreso.Usuario(
	UsuarioDocumentoIdentidad nchar(8),
	UsuarioNombres nvarchar(70),
	UsuarioApellidoPaterno nvarchar(50),
	UsuarioApellidoMaterno nvarchar(50),
	UsuarioCorreo nvarchar(55),
	UsuarioClave nvarchar(15),
	UsuarioFuncionCodigo int,
	UsuarioEstado nchar(1) constraint UsuarioEstadoDF default 'A',
	UsuarioFechaRegistro date constraint UsuarioFechaRegistroDF default getDate(),
	constraint UsuarioPK primary key (UsuarioDocumentoIdentidad),
	constraint UsuarioFechaRegistroCK check (UsuarioFechaRegistro <= getDate()),
	constraint UsuarioEstadoCK check (UsuarioEstado = 'A' or UsuarioEstado = 'N'),
	constraint UsuarioCorreoUQ unique (UsuarioCorreo),
	constraint UsuarioFuncionFK foreign key (UsuarioFuncionCodigo)
		references programaIngreso.Funcion(FuncionCodigo)
	)
	on ACCESO
go

create table dbMiniMarket.Proveedor(
	ProveedorDocumentoIdentidad nchar(8),
	ProveedorRazonSocial nvarchar(30),
	ProveedorCorreo nvarchar(55),
	ProveedorTelefono nvarchar(9),
	ProveedorEstado nchar(1) constraint ProveedorEstadoDF default 'A',
	ProveedorFechaRegistro date constraint ProveedorFechaRegistroDF default getDate(),
	constraint ProveedorPK primary key (ProveedorDocumentoIdentidad),
	constraint ProveedorFechaRegistroCK check (ProveedorFechaRegistro <= getDate()),
	constraint ProveedorCorreoUQ unique (ProveedorCorreo),
	constraint ProveedorTelefonoUQ unique (ProveedorTelefono),
	constraint ProveedorEstadoCK check (ProveedorEstado = 'A' or ProveedorEstado = 'N')
	)
	on COMPRA
go

create table dbMiniMarket.Categoria(
	CategoriaId int Primary key not null identity(1,1),
	CategoriaDescripcion nvarchar(70),
	CategoriaEstado nchar(1) constraint CategoriaEstadoDF default 'A',
	CategoriaFechaRegistro date constraint CategoriaFechaRegistroDF default getDate(),
	constraint CategoriaFechaRegistroCK check (CategoriaFechaRegistro <= getDate()),
	constraint CategoriaEstadoCK check (CategoriaEstado = 'A' or CategoriaEstado = 'N')
	)
	on PRODUCTO
go

create table dbMiniMarket.Producto(
	ProductoCodigo nchar(5),
	ProductoDescripcion nvarchar(50),	
	ProductoMedida nvarchar(50),
	ProductoCategoriaId int,
	ProductoStock numeric(9,2) constraint ProductoStockDF default 0,
	ProductoPrecioCompra numeric(9,2) constraint ProductoPrecioCompraDF default 0,
	ProductoPrecioVenta numeric(9,2) constraint ProductoPrecioVentaDF default 0,
	ProductoValorStock as ProductoPrecioVenta * ProductoStock,
	ProductoEstado nchar(1) constraint ProductoEstadoDF default 'A',
	ProductoFechaRegistro date constraint ProductoFechaRegistroDF default getDate(),
	constraint ProductoPK primary key (ProductoCodigo),
	constraint ProductoDescripcionUQ unique (ProductoDescripcion),
	constraint ProductoPrecioCompraCK check (ProductoPrecioCompra>=0),
	constraint ProductoPrecioVentaCK check (ProductoPrecioVenta>=0),
	constraint ProductoStockCK check (ProductoStock>=0),
	constraint ProductoEstadoCK check (ProductoEstado = 'A' or ProductoEstado = 'N'),
	constraint ProductoFechaRegistroCK check (ProductoFechaRegistro <= getDate()),
	constraint ProductoCategoriaFK foreign key (ProductoCategoriaId)
		references dbMiniMarket.Categoria(CategoriaId)
	)
	on PRODUCTO
go

create table dbMiniMarket.Compra(
	CompraNumeroComprobante nchar(9),
	CompraTipoComprobante nvarchar(7),
	CompraUsuarioDocumentoIdentidad nchar(8),
	CompraProveedorDocumentoIdentidad nchar(8),
	CompraMontoTotal numeric(9,2) constraint CompraMontoTotalDF default 0,
	CompraFechaRegistro date constraint CompraFechaRegistroDF default getDate(),
	constraint CompraPK primary key (CompraNumeroComprobante),
	constraint CompraNumeroComprobanteCK unique (CompraNumeroComprobante),
	constraint CompraFechaRegistroCK check (CompraFechaRegistro <= getDate()),
	constraint CompraMontoTotalCK check (CompraMontoTotal>=0),
	constraint CompraUsuarioFK foreign key (CompraUsuarioDocumentoIdentidad)
		references programaIngreso.Usuario(UsuarioDocumentoIdentidad),
	constraint CompraProveedorDocumentoIdentidadFK foreign key (CompraProveedorDocumentoIdentidad)
		references dbMiniMarket.Proveedor(ProveedorDocumentoIdentidad),
	)
	on COMPRA
go

create table dbMiniMarket.DetalleCompra(
	DetalleCompraId int Primary key not null identity(1,1),
	DetalleCompraCompraNumeroComprobante nchar(9),
	DetalleCompraProductoCodigo nchar(5),
	DetalleCompraPrecioCompra numeric(9,2) constraint DetalleCompraPrecioCompraDF default 0,
	DetalleCompraPrecioVenta numeric(9,2) constraint DetalleCompraPrecioVentaDF default 0,
	DetalleCompraCantidad numeric(9,2) constraint DetalleCompraMontoTotalDF default 0,
	DetalleCompraCantidadPrecioCompra as DetalleCompraCantidad * DetalleCompraPrecioCompra,
	DetalleCompraFechaRegistro date constraint DetalleCompraFechaRegistroDF default getDate(),
	constraint DetalleCompraFechaRegistroCK check (DetalleCompraFechaRegistro <= getDate()),
	constraint DetalleCompraPrecioCompraCK check (DetalleCompraPrecioCompra>=0),
	constraint DetalleCompraPrecioVentaCK check (DetalleCompraPrecioVenta>=0),
	constraint DetalleCompraCantidadCK check (DetalleCompraCantidad>=0),
	constraint DetalleCompraCompraFK foreign key (DetalleCompraCompraNumeroComprobante)
		references dbMiniMarket.Compra(CompraNumeroComprobante),
	constraint DetalleCompraProductoFK foreign key (DetalleCompraProductoCodigo)
		references dbMiniMarket.Producto(ProductoCodigo),
	)
	on COMPRA
go

create table dbMiniMarket.Cliente(
	ClienteDocumentoIdentidad nchar(8),
	ClienteNombres nvarchar(70),
	ClienteApellidoPaterno nvarchar(50),
	ClienteApellidoMaterno nvarchar(50),
	ClienteCorreo nvarchar(55),
	ClienteTelefono nvarchar(9),
	ClienteEstado nchar(1) constraint ClienteEstadoDF default 'A',
	ClienteFechaRegistro date constraint ClienteFechaRegistroDF default getDate(),
	constraint ClientePK primary key (ClienteDocumentoIdentidad),
	constraint ClienteCorreoUQ unique (ClienteCorreo),
	constraint ClienteTelefonoUQ unique (ClienteTelefono),
	constraint ClienteEstadoCK check (ClienteEstado = 'A' or ClienteEstado = 'N')
	)
	on DISTRIBUCION
go

create table dbMiniMarket.Venta(
	VentaNumeroComprobante nchar(9),
	VentaTipoComprobante nvarchar(7),
	VentaUsuarioDocumentoIdentidad nchar(8),
	VentaClienteDocumentoIdentidad nchar(8),
	VentaClienteNombresApellidos nvarchar(70),
	VentaClienteApellidoPaterno nvarchar(50),
	VentaClienteApellidoMaterno nvarchar(50),
	VentaMontoPagoComprobante numeric(9,2) constraint VentaMontoPagoComprobanteDF default 0,
	VentaMontoVueltoComprobante numeric(9,2) constraint VentaMontoVueltoComprobanteDF default 0,
	VentaMontoTotalComprobante numeric(9,2) constraint VentaMontoTotalComprobanteDF default 0,
	VentaFechaRegistroComprobante date constraint VentaFechaRegistroComprobanteDF default getDate(),
	constraint VentaPK primary key (VentaNumeroComprobante),
	constraint VentaMontoPagoComprobanteCK check (VentaMontoPagoComprobante>=0),
	constraint VentaMontoVueltoComprobanteCK check (VentaMontoVueltoComprobante>=0),
	constraint VentaMontoTotalComprobanteCK check (VentaMontoTotalComprobante>=0),
	constraint VentaFechaRegistroComprobanteCK check (VentaFechaRegistroComprobante <= getDate()),
	constraint VentaUsuarioFK foreign key (VentaUsuarioDocumentoIdentidad)
		references programaIngreso.Usuario(UsuarioDocumentoIdentidad),
	constraint VentaClienteFK foreign key (VentaClienteDocumentoIdentidad)
		references dbMiniMarket.Cliente(ClienteDocumentoIdentidad)
	)
	on DISTRIBUCION
go

create table dbMiniMarket.DetalleVenta(
	DetalleVentaId int Primary key not null identity(1,1),
	DetalleVentaVentaNumeroComprobante nchar(9),
	DetalleVentaProductoCodigo nchar(5),
	DetalleVentaPrecioVenta numeric(9,2) constraint DetalleVentaPrecioVentaDF default 0,
	DetalleVentaCantidad numeric(9,2) constraint DetalleVentaCantidadDF default 0,
	DetalleVentaMontoTotal as DetalleVentaPrecioVenta * DetalleVentaCantidad,
	DetalleVentaFechaRegistro date constraint DetalleVentaFechaRegistroDF default getDate(),
	constraint DetalleVentaPrecioVentaCK check (DetalleVentaPrecioVenta>=0),
	constraint DetalleVentaCantidadCK check (DetalleVentaCantidad>=0),
	constraint DetalleVentaFechaRegistroCK check (DetalleVentaFechaRegistro <= getDate()),
	constraint DetalleVentaVentaFK foreign key (DetalleVentaVentaNumeroComprobante)
		references dbMiniMarket.Venta(VentaNumeroComprobante),
	constraint DetalleVentaProductoFK foreign key (DetalleVentaProductoCodigo)
		references dbMiniMarket.Producto(ProductoCodigo)
	)
	on DISTRIBUCION
go

select * from programaIngreso.Usuario 
go

insert into dbMiniMarket.Proveedor([ProveedorDocumentoIdentidad], [ProveedorRazonSocial], [ProveedorCorreo], [ProveedorTelefono], [ProveedorEstado], [ProveedorFechaRegistro]) values
	('84125658','Oliverio Juan','olir_d.s@hotmail.com','928721371','A','08/10/2022'),
	('75411225','Melissa Santos','melis@hotmail.com','974152258','A','08/10/2022'),
	('35966120','Juan José','juanjo@hotmail.com','955412230','N','08/10/2022'),
	('24455689','Pedro Suarez','esp@hotmail.com','987745521','N','08/10/2022')
go


insert into dbMiniMarket.Cliente([ClienteDocumentoIdentidad], [ClienteNombres], [ClienteApellidoPaterno], [ClienteApellidoMaterno], [ClienteCorreo], [ClienteTelefono], [ClienteEstado], [ClienteFechaRegistro])
values
('12345678','Oliver Diego','Saavedra','Valverde','oliver_d.s@gmail.com','123456789','A','08/10/2022'),
('87451224','Frank Jheferson','Santos','Yupanqui','a.s@gmail.com','187445519','A','08/10/2022'),
('25785418','Ximena','Rodriguez','Espinoza','Ximena.s@gmail.com','854451289','N','08/10/2022'),
('14155665','Wilmer','Salvatierra','Arriaga','wil_r@gmail.com','198544789','N','08/10/2022')
go

insert into programaIngreso.Funcion([FuncionDescripcion], [FuncionFechaRegistro])
values
('Administrador','2022-10-29'),
('Trabajador','2022-10-29'),
('Cliente','2022-10-29'),
('Proveedor','2022-10-29'),
('Analista','2022-10-29')
go

insert into programaIngreso.Permiso([PermisoFuncionCodigo], [PermisoNombreMenu], [PermisoFechaRegistro])
values
('1','MenuUsuario','2022-10-29'),
('1','MenuVentas','2022-10-29'),
('1','MenuCompras','2022-10-29'),
('1','MenuClientes','2022-10-29'),
('1','MenuProveedores','2022-10-29'),
('1','MenuReportes','2022-10-29'),
('1','MenuAcercaDe','2022-10-29'),
('1','MenuProductos','2022-10-30'),
('2','MenuVentas','2022-10-30'),
('2','MenuCompras','2022-10-30'),
('2','MenuClientes','2022-10-30'),
('2','MenuProveedores','2022-10-30'),
('2','MenuAcercaDe','2022-10-30'),
('2','MenuProductos','2022-10-30'),
('3','MenuProductos','2022-10-30'),
('3','MenuVentas','2022-10-30'),
('3','MenuAcercaDe','2022-10-30'),
('4','MenuProductos','2022-10-29'),
('4','MenuCompras','2022-10-29'),
('4','MenuAcercaDe','2022-10-29'),
('4','MenuProveedores','2022-10-30'),
('5','MenuReportes','2022-10-30')
go
select * from programaIngreso.Funcion
go

insert into programaIngreso.Usuario([UsuarioDocumentoIdentidad], [UsuarioNombres], [UsuarioApellidoPaterno], [UsuarioApellidoMaterno], [UsuarioCorreo], [UsuarioClave], [UsuarioFuncionCodigo], [UsuarioEstado], [UsuarioFechaRegistro])
values
('12345678','Jose Enrique','Suarez','Perez','josesuarez@ucvvirtual.edu.pe','TSm5bVqWMwxB5z','2','A','2002-10-30'),
('72689511','Jeysson Manuel','Sanchez','Rodrigez','jeysson_s.r@hotmail.com','Rb39cEXWbWoeGH','1','A','2002-10-29'),
('32754111','Ali Snu','Placido','Huerta','vapakeg992@covbase.com','f7fN7X9k35wS93','3','A','2002-10-29'),
('16714416','Jose Felix','Prieto','Montilla','toiddifronoffa@yopmail.com','whaGYMneTOrb','4','A','2002-10-29'),
('99850141','Jose Angel','Cervantes','Mosquera','lobeugramuka@yopmail.com','hvDjBNrNCFGg','5','N','2002-10-29')
go

insert into dbMiniMarket.Categoria([CategoriaDescripcion], [CategoriaEstado],[CategoriaFechaRegistro])
values
('Productos Enlatados','A','2002-10-30'),
('Productos Envasados','A','2002-10-30'),
('Productos Envasados','A','2002-10-30'),
('Moda Caballero','A','2002-10-30'),
('Moda Dama','A','2002-10-30'),
('Accesorios','A','2002-10-30'),
('Informatica','A','2002-10-30'),
('Juguetes','A','2002-10-30')
go

insert into dbMiniMarket.Producto([ProductoCodigo], [ProductoDescripcion], [ProductoMedida], [ProductoCategoriaId], [ProductoStock], [ProductoPrecioCompra], [ProductoPrecioVenta], [ProductoEstado])
values
('PR001','Gaseosa Pepsi','litros','2',30,10.20,15.50,'A'),
('PR002','Gaseosa Fanta','litros','2',10,10.00,12.50,'A'),
('PR003','Computadora ASUS','numerico','7',20,2800.00,3500.10,'A'),
('PR004','Pala de Arena','numerico','8',100,1.00,2.50,'A')
go

insert into dbMiniMarket.Venta([VentaNumeroComprobante], [VentaTipoComprobante], [VentaUsuarioDocumentoIdentidad], [VentaClienteDocumentoIdentidad], [VentaClienteNombresApellidos], [VentaClienteApellidoPaterno], [VentaClienteApellidoMaterno], [VentaMontoPagoComprobante], [VentaMontoVueltoComprobante], [VentaMontoTotalComprobante], [VentaFechaRegistroComprobante])
values
('123456789','Boleta','72689511','12345678','Oliver Diego','Saavedra','Valverde',190,90,100,'2020-10-30'),
('464646779','Factura','72689511','87451224','Frank Jheferson','Santos','Yupanqui',290,50,240,'2020-12-01'),

('512226779','Factura','72689511','87451224','Frank Jheferson','Santos','Yupanqui',290,50,240,'2022-12-01'),
('885511225','Boleta','72689511','14155665','Wilmer','Salvatierra','Arriaga',100,90,10,'2022-10-30')
go

insert into dbMiniMarket.Proveedor([ProveedorDocumentoIdentidad], [ProveedorRazonSocial], [ProveedorCorreo], [ProveedorTelefono], 
[ProveedorEstado], [ProveedorFechaRegistro])
values('72607128','Bebibas','Proveedor01@gmail.com','956783351','A','08/10/2022')
go

insert into dbMiniMarket.Producto([ProductoCodigo], [ProductoDescripcion], [ProductoMedida], [ProductoCategoriaId], [ProductoStock],
[ProductoPrecioCompra], [ProductoPrecioVenta], [ProductoEstado], [ProductoFechaRegistro])
values ('P0001','Mounster','ml','1',5,2,4,'A','2002-10-30')
GO
insert into dbMiniMarket.Compra([CompraNumeroComprobante], [CompraTipoComprobante], [CompraUsuarioDocumentoIdentidad],
[CompraProveedorDocumentoIdentidad], [CompraMontoTotal], [CompraFechaRegistro])
values ('N00000012','Boleta','12345678','72607128',40,'10/08/2022')
GO

insert into dbMiniMarket.DetalleCompra( [DetalleCompraCompraNumeroComprobante], [DetalleCompraProductoCodigo], 
[DetalleCompraPrecioCompra], [DetalleCompraPrecioVenta], [DetalleCompraCantidad], [DetalleCompraFechaRegistro])
values ('N00000012','P0001',5,2,3,'10/08/2022')
GO


-- =======================================================================
--							USUARIOS
-- =======================================================================
select * from programaIngreso.Usuario
go

Create or ALTER   procedure [dbo].[spUsuariosSinBorrados] As
		Select 
		[UsuarioDocumentoIdentidad], [UsuarioNombres], [UsuarioApellidoPaterno], 
		[UsuarioApellidoMaterno], [UsuarioCorreo], [UsuarioClave], [UsuarioFuncionCodigo], 
		[UsuarioEstado], [UsuarioFechaRegistro]
		from [programaIngreso].[Usuario] 
		where UsuarioEstado <> 'N'
go

Create or ALTER procedure [dbo].[spUsuariosBorrados] As
		Select 
		[UsuarioDocumentoIdentidad], [UsuarioNombres], [UsuarioApellidoPaterno], 
		[UsuarioApellidoMaterno], [UsuarioCorreo], [UsuarioClave], [UsuarioFuncionCodigo], 
		[UsuarioEstado], [UsuarioFechaRegistro]
		from [programaIngreso].[Usuario] 
		where UsuarioEstado <> 'A'
go

Create or alter procedure dbo.spPermisosUsuarios (@PermisoFuncionCodigo int)
	As
		Select 
			P.PermisoFuncionCodigo, P.PermisoNombreMenu
			from [programaIngreso].[Permiso]  As P
			where [PermisoFuncionCodigo] = @PermisoFuncionCodigo
			order by P.PermisoNombreMenu
go

-- Usuarios Agregar
Create or alter procedure dbo.UsuariosAgregarRegistro (@UsuarioDocumentoIdentidad nchar(8), @UsuarioNombres nvarchar(70), 
	@UsuarioApellidoPaterno nvarchar(50), @UsuarioApellidoMaterno nvarchar(50), @UsuarioCorreo nvarchar(55), 
	@UsuarioClave nvarchar(15), @UsuarioFuncionCodigo int, @UsuarioEstado nchar(1), @UsuarioFechaRegistro date)
	with encryption
	As	
	insert into [programaIngreso].[Usuario]
	([UsuarioDocumentoIdentidad], [UsuarioNombres], [UsuarioApellidoPaterno], 
	[UsuarioApellidoMaterno], [UsuarioCorreo], [UsuarioClave], [UsuarioFuncionCodigo], 
	[UsuarioEstado], [UsuarioFechaRegistro])
	values
	(@UsuarioDocumentoIdentidad, @UsuarioNombres, @UsuarioApellidoPaterno, @UsuarioApellidoMaterno, @UsuarioCorreo, 
	@UsuarioClave, @UsuarioFuncionCodigo, @UsuarioEstado, @UsuarioFechaRegistro)
go

-- Usuarios Editar
Create or alter procedure dbo.UsuariosEditarRegistro (@UsuarioDocumentoIdentidad nchar(8), @UsuarioNombres nvarchar(70), 
	@UsuarioApellidoPaterno nvarchar(50), @UsuarioApellidoMaterno nvarchar(50), @UsuarioCorreo nvarchar(55), 
	@UsuarioClave nvarchar(15), @UsuarioFuncionCodigo int, @UsuarioEstado nchar(1), @UsuarioFechaRegistro date)
	with encryption
	As	
	update [programaIngreso].[Usuario] Set
	[UsuarioDocumentoIdentidad] = @UsuarioDocumentoIdentidad,
	[UsuarioNombres] = @UsuarioNombres, 
	[UsuarioApellidoPaterno] = @UsuarioApellidoPaterno, 
	[UsuarioApellidoMaterno] = @UsuarioApellidoMaterno, 
	[UsuarioCorreo] = @UsuarioCorreo, 
	[UsuarioClave] = @UsuarioClave,
	[UsuarioFuncionCodigo] = @UsuarioFuncionCodigo,
	[UsuarioEstado] = @UsuarioEstado,
	[UsuarioFechaRegistro] = @UsuarioFechaRegistro
	where [UsuarioDocumentoIdentidad] = @UsuarioDocumentoIdentidad
go

-- Usuarios Eliminar
Create or alter procedure dbo.spUsuarioEliminarRegistro (@UsuarioDocumentoIdentidad nchar(8))
	with encryption
	As	
	update [programaIngreso].[Usuario] Set
		[UsuarioEstado] = 'N'
	where [UsuarioDocumentoIdentidad] = @UsuarioDocumentoIdentidad
go

-- Usuarios Recuperar
Create or alter procedure dbo.spUsuarioRecuperarRegistro (@UsuarioDocumentoIdentidad nchar(8))
	with encryption
	As	
	update [programaIngreso].[Usuario] Set
		[UsuarioEstado] = 'A'
	where [UsuarioDocumentoIdentidad] = @UsuarioDocumentoIdentidad
go

-- =======================================================================
--							CLIENTES
-- =======================================================================

select * from dbMiniMarket.Cliente
go
--Procedimiento almacenado Clientes
Create or alter procedure spClientesListasSinBorrados
As
Select [ClienteDocumentoIdentidad], [ClienteNombres], [ClienteApellidoPaterno], [ClienteApellidoMaterno], [ClienteCorreo], [ClienteTelefono], [ClienteEstado], [ClienteFechaRegistro]
from dbMiniMarket.Cliente
where ClienteEstado <> 'N'
go
---------------------------------------
Create or alter procedure dbo.ClienteAgregarRegistro
(
@ClienteDocumentoIdentidad nchar(8),
@ClienteNombres nvarchar(70),
@ClienteApellidoPaterno nvarchar(50),
@ClienteApellidoMaterno  nvarchar(50),
@ClienteCorreo nvarchar(55),
@ClienteTelefono nvarchar(9),
@ClienteEstado nchar(1),
@ClienteFechaRegistro  date
)
with encryption
As
insert into dbMiniMarket.Cliente
([ClienteDocumentoIdentidad], [ClienteNombres], [ClienteApellidoPaterno], [ClienteApellidoMaterno], 
[ClienteCorreo], [ClienteTelefono], [ClienteEstado], [ClienteFechaRegistro])
values 
(@ClienteDocumentoIdentidad,
@ClienteNombres,
@ClienteApellidoPaterno, 
@ClienteApellidoMaterno, 
@ClienteCorreo, 
@ClienteTelefono,
@ClienteEstado,
@ClienteFechaRegistro)
go
--------------------------
Create or alter procedure dbo.ClienteEditarRegistro
(
@ClienteDocumentoIdentidad nchar(8),
@ClienteNombres nvarchar(70),
@ClienteApellidoPaterno nvarchar(50),
@ClienteApellidoMaterno  nvarchar(50),
@ClienteCorreo nvarchar(55),
@ClienteTelefono nvarchar(9),
@ClienteEstado nchar(1),
@ClienteFechaRegistro  date
)
with encryption
As
update dbMiniMarket.Cliente
set

[ClienteNombres]=@ClienteNombres, 
[ClienteApellidoPaterno]=@ClienteApellidoPaterno, 
[ClienteApellidoMaterno]=@ClienteApellidoMaterno, 
[ClienteCorreo]=@ClienteCorreo, 
[ClienteTelefono]=@ClienteTelefono, 
[ClienteEstado]=@ClienteEstado,
[ClienteFechaRegistro]=@ClienteFechaRegistro

where [ClienteDocumentoIdentidad]=@ClienteDocumentoIdentidad
go
----------------------------------
Create or alter procedure dbo.spClientesEliminarRegistro
	(
	@ClienteDocumentoIdentidad nchar(11)
	)
	with encryption
	As	
	update dbMiniMarket.Cliente
	Set
		[ClienteEstado] = 'N'
	where [ClienteDocumentoIdentidad]=@ClienteDocumentoIdentidad
go
-----------------------------------
Create or alter procedure dbo.spClientesRecupararRegistro
(
	@ClienteDocumentoIdentidad nchar(11)
	)
	with encryption
	As	
	update dbMiniMarket.Cliente
	Set
		[ClienteEstado] = 'A'
	where [ClienteDocumentoIdentidad]=@ClienteDocumentoIdentidad
go
---------------------
create or alter procedure dbo.spClientesListadoBorrados
	with encryption
	As
		select
			[ClienteDocumentoIdentidad], 
			[ClienteNombres], 
			[ClienteApellidoPaterno], 
			[ClienteApellidoMaterno]

			from dbMiniMarket.Cliente As P
			where [ClienteEstado] = 'N'
go



--Fin Clientes
------------------------------------------------------------------------------


-- =======================================================================
--							PROVEEDOR
-- =======================================================================

select * from dbMiniMarket.Proveedor
go
--Procedimiento almacenado Provedor
Create or alter procedure spProveedoresListasSinBorrados
As
Select [ProveedorDocumentoIdentidad], [ProveedorRazonSocial], [ProveedorCorreo], [ProveedorTelefono], [ProveedorEstado], [ProveedorFechaRegistro] 
from dbMiniMarket.Proveedor
where ProveedorEstado <> 'N'
go
--Provedor Fin
select name from sys.database_files
go
----------------------------------
Create or alter procedure dbo.ProvedorAgregarRegistro
(
@ProveedorDocumentoIdentidad nchar(8),
@ProveedorRazonSocial nvarchar(30),
@ProveedorCorreo nvarchar(55),
@ProveedorTelefono nvarchar(9),
@ProveedorEstado nchar(1),
@ProveedorFechaRegistro Date
)
with encryption
As
insert into dbMiniMarket.Proveedor
([ProveedorDocumentoIdentidad], [ProveedorRazonSocial], [ProveedorCorreo], 
[ProveedorTelefono], [ProveedorEstado], [ProveedorFechaRegistro])
values 
(@ProveedorDocumentoIdentidad,
@ProveedorRazonSocial,
@ProveedorCorreo, 
@ProveedorTelefono, 
@ProveedorEstado, 
@ProveedorFechaRegistro)
go
--------------------------------
Create or alter procedure dbo.ProvedorEditarRegistro
(
@ProveedorDocumentoIdentidad nchar(8),
@ProveedorRazonSocial nvarchar(30),
@ProveedorCorreo nvarchar(55),
@ProveedorTelefono nvarchar(9),
@ProveedorEstado nchar(1),
@ProveedorFechaRegistro Date
)
with encryption
As
update dbMiniMarket.Proveedor
set

[ProveedorRazonSocial]=@ProveedorRazonSocial,
[ProveedorCorreo]=@ProveedorCorreo, 
[ProveedorTelefono]=@ProveedorTelefono,
[ProveedorEstado]=@ProveedorEstado, 
[ProveedorFechaRegistro]=@ProveedorFechaRegistro

where [ProveedorDocumentoIdentidad]=@ProveedorDocumentoIdentidad
go
----------------------
Create or alter procedure dbo.spProvedoresEliminarRegistro
	(
	@ProveedorDocumentoIdentidad nchar(8)
	)
	with encryption
	As	
	update dbMiniMarket.Proveedor
	Set
		[ProveedorEstado] = 'N'
	where [ProveedorDocumentoIdentidad] = @ProveedorDocumentoIdentidad
go
---------------------------------
Create or alter procedure dbo.spProvedoresRecupararRegistro
	(
	@ProveedorDocumentoIdentidad nchar(8)
	)
	with encryption
	As	
	update dbMiniMarket.Proveedor
	Set
		[ProveedorEstado] = 'A'
	where [ProveedorDocumentoIdentidad] = @ProveedorDocumentoIdentidad
go
------------------------------------------
create or alter procedure dbo.spProductosListadoBorrados
	with encryption
	As
		select
			[ProveedorDocumentoIdentidad], [ProveedorRazonSocial],
			[ProveedorCorreo], [ProveedorTelefono]
			from dbMiniMarket.Proveedor As P
			where ProveedorEstado = 'N'
go

-- =======================================================================
--							CATEGORIAS
-- =======================================================================

Create or ALTER   procedure [dbo].[spCategoriasListadoSinBorrados]
	As
		Select [CategoriaId], [CategoriaDescripcion], [CategoriaEstado], [CategoriaFechaRegistro]
			from dbMiniMarket.Categoria
			where CategoriaEstado <> 'N'
go

select * from dbMiniMarket.Categoria
go

Create or ALTER   procedure [dbo].[spCategoriasSinBorrados] As
		Select 
		[CategoriaId], [CategoriaDescripcion], [CategoriaEstado], [CategoriaFechaRegistro]
		from [dbMiniMarket].[Categoria]
		where CategoriaEstado <> 'N'
go

Create or ALTER procedure [dbo].[spCategoriasBorrados] As
		Select 
		[CategoriaId], [CategoriaDescripcion], [CategoriaEstado], [CategoriaFechaRegistro]
		from [dbMiniMarket].[Categoria]
		where CategoriaEstado <> 'A'
go

-- Categorias Agregar
Create or alter procedure dbo.CategoriasAgregarRegistro (

	@CategoriaDescripcion nvarchar(70),
	@CategoriaEstado nchar(1),
	@CategoriaFechaRegistro date
	)
	with encryption
	As	
	insert into [dbMiniMarket].[Categoria]
	([CategoriaDescripcion], [CategoriaEstado], [CategoriaFechaRegistro])
	values
	(@CategoriaDescripcion,	@CategoriaEstado, @CategoriaFechaRegistro)
go

-- Categorias Editar
Create or alter procedure dbo.CategoriasEditarRegistro (
	@CategoriaId int,
	@CategoriaDescripcion nvarchar(70),
	@CategoriaEstado nchar(1),
	@CategoriaFechaRegistro date)
	with encryption
	As	
	update [dbMiniMarket].[Categoria] Set
	[CategoriaDescripcion] = @CategoriaDescripcion, 
	[CategoriaEstado] = @CategoriaEstado, 
	[CategoriaFechaRegistro] = @CategoriaFechaRegistro
	where [CategoriaId] = @CategoriaId
go

-- Usuarios Eliminar
Create or alter procedure dbo.spCategoriaEliminarRegistro (@CategoriaId int)
	with encryption
	As	
	update [dbMiniMarket].[Categoria] Set
		[CategoriaEstado] = 'N'
	where [CategoriaId] = @CategoriaId
go

-- Usuarios Recuperar
Create or alter procedure dbo.spCategoriaRecuperarRegistro (@CategoriaId int)
	with encryption
	As	
	update [dbMiniMarket].[Categoria] Set
		[CategoriaEstado] = 'A'
	where [CategoriaId] = @CategoriaId
go

-- =============================================================================
--				PARA PONER PROVEEDORES EN LOS REPORTES COMPRAS	
-- =============================================================================

-- Proveedores para ComboBox

Create or alter procedure dbo.spProveedoresReporteCompras
	As
		Select 
			P.ProveedorDocumentoIdentidad, P.ProveedorRazonSocial
			from dbMiniMarket.Proveedor As P
			order by ProveedorRazonSocial
go

-- =============================================================================
--				PARA PONER CLIENTES EN LOS REPORTES VENTAS	
-- =============================================================================


-- Clientes para ComboBox

Create or alter procedure dbo.spClientesReporteVentas
	As
		Select 
			P.ClienteDocumentoIdentidad, P.ClienteNombres
			from dbMiniMarket.Cliente As P
			order by ClienteNombres
go

-- =============================================================================
--				PARA VERIFICAR LA LISTA DE VENTAS	
-- =============================================================================

Create or alter procedure dbo.spListaDeVentas
	As
		Select 
			[VentaNumeroComprobante], [VentaTipoComprobante], [VentaUsuarioDocumentoIdentidad], [VentaClienteDocumentoIdentidad], [VentaClienteNombresApellidos], [VentaClienteApellidoPaterno], [VentaClienteApellidoMaterno], [VentaMontoPagoComprobante], [VentaMontoVueltoComprobante], [VentaMontoTotalComprobante], [VentaFechaRegistroComprobante]
			from dbMiniMarket.Venta
			order by VentaTipoComprobante
go


-- =======================================================================
--							PRODUCTO
-- =======================================================================
select*from dbMiniMarket.Producto
go
-- Categoria para ComboBox
use MINIMARKET
go
Create or alter procedure dbo.spCategoriaListaSinBorradosProducto
	As
		Select CategoriaId
			from dbMiniMarket.Categoria
go

-- Productos Agregar
Create or alter procedure dbo.ProductoAgregarRegistro
	(
	@ProductoCodigo nchar(5), 
	@ProductoDescripcion nvarchar(50), 
	@ProductoMedida nvarchar(50), 
	@ProductoCategoriaId int,
	@ProductoStock numeric(9,2),
	@ProductoPrecioCompra numeric(9,2),
	@ProductoPrecioVenta numeric(9,2),
	@ProductoEstado nchar(1),
	@ProductoFechaRegistro Date
	)
	with encryption
	As	
	insert into dbMiniMarket.Producto
	([ProductoCodigo], [ProductoDescripcion], [ProductoMedida], [ProductoCategoriaId], [ProductoStock],
	[ProductoPrecioCompra], [ProductoPrecioVenta], [ProductoEstado], [ProductoFechaRegistro])
	values
	(@ProductoCodigo,@ProductoDescripcion,@ProductoMedida,@ProductoCategoriaId,@ProductoStock,@ProductoPrecioCompra,@ProductoPrecioVenta,
	@ProductoEstado,@ProductoFechaRegistro)
go

use MINIMARKET
go
select*from dbMiniMarket.Producto
go
-- Productos Editar
Create or alter procedure dbo.ProductoEditarRegistro
	(
	@ProductoCodigo nchar(5), 
	@ProductoDescripcion nvarchar(50), 
	@ProductoMedida nvarchar(50), 
	@ProductoCategoriaId int,
	@ProductoStock numeric(9,2),
	@ProductoPrecioCompra numeric(9,2),
	@ProductoPrecioVenta numeric(9,2),
	@ProductoEstado nchar(1),
	@ProductoFechaRegistro Date
	)
	with encryption
	As	
	update dbMinimarket.Producto
	Set
	[ProductoDescripcion] = @ProductoDescripcion, 
	[ProductoMedida] = @ProductoMedida, 
	[ProductoCategoriaId] = @ProductoCategoriaId, 
	[ProductoStock] = @ProductoStock, 
	[ProductoPrecioCompra] = @ProductoPrecioCompra,
	[ProductoPrecioVenta] = @ProductoPrecioVenta,
	[ProductoEstado] = @ProductoEstado,
	[ProductoFechaRegistro] = @ProductoFechaRegistro
	where [ProductoCodigo] = @ProductoCodigo
go

-- Productos Eliminar
Create or alter procedure dbo.spProductoEliminarRegistro
	(
	@ProductoCodigo nchar(5)
	)
	with encryption
	As	
	delete from dbMiniMarket.Producto
	where [ProductoCodigo] = @ProductoCodigo
go

-- MOSTRAR
Create or alter procedure [dbo].[spProductoListasSinBorrados]
	As
		Select [ProductoCodigo], [ProductoDescripcion], [ProductoMedida], [ProductoCategoriaId], [ProductoStock], 
		[ProductoPrecioCompra], [ProductoPrecioVenta], [ProductoEstado], [ProductoFechaRegistro]
			from dbMiniMarket.Producto

go
-- ---

-- Productos Buscar Codigo
Create or alter procedure dbo.spProductoBuscarCodigoRegistro
	(
	@ProductoCodigo nchar(5)
	)
	with encryption
	As
	select*from dbMiniMarket.Producto where [ProductoCodigo] = @ProductoCodigo
go

-- Productos Buscar Descripcion
Create or alter procedure dbo.spProductoBuscarDescripcionRegistro
	(
	@ProductoDescripcion nvarchar(50)
	)
	with encryption
	As
	select*from dbMiniMarket.Producto where [ProductoDescripcion] = @ProductoDescripcion
go

-- =======================================================================
--							COMPRA
-- =======================================================================

-- Usuarios para ComboBox
Create or alter procedure dbo.spUsuarioListaSinBorradosCompra
	As
		Select [UsuarioDocumentoIdentidad]
		from programaIngreso.Usuario
go

-- Proveedores para ComboBox
Create or alter procedure dbo.psProveedorListaSinBorradosCompra
	As
		Select [ProveedorDocumentoIdentidad]
		from dbMiniMarket.Proveedor
go

-- Compra Agregar
Create or alter procedure dbo.CompraAgregarRegistro
	(
	@CompraNumeroComprobante nchar(9), 
	@CompraTipoComprobante nvarchar(7),
	@CompraUsuarioDocumentoIdentidad nchar(8), 
	@CompraProveedorDocumentoIdentidad nchar(8),
	@CompraFechaRegistro Date
	)
	with encryption
	As	
	insert into dbMiniMarket.Compra
	([CompraNumeroComprobante], [CompraTipoComprobante], [CompraUsuarioDocumentoIdentidad],
	[CompraProveedorDocumentoIdentidad], [CompraFechaRegistro])
	
	values
	(@CompraNumeroComprobante,@CompraTipoComprobante,@CompraUsuarioDocumentoIdentidad,
	@CompraProveedorDocumentoIdentidad,@CompraFechaRegistro)
go

-- Compra Editar
Create or alter procedure dbo.CompraEditarRegistro
	(
	@CompraNumeroComprobante nchar(9), 
	@CompraTipoComprobante nvarchar(7),
	@CompraUsuarioDocumentoIdentidad nchar(8), 
	@CompraProveedorDocumentoIdentidad nchar(8),
	@CompraMontoTotal numeric(9,2),
	@CompraFechaRegistro Date
	)
	with encryption
	As	
	update dbMinimarket.Compra
	Set
	[CompraTipoComprobante] = @CompraTipoComprobante, 
	[CompraUsuarioDocumentoIdentidad] = @CompraUsuarioDocumentoIdentidad, 
	[CompraProveedorDocumentoIdentidad] = @CompraProveedorDocumentoIdentidad, 
	[CompraMontoTotal] = @CompraMontoTotal,
	[CompraFechaRegistro] = @CompraFechaRegistro
	where [CompraNumeroComprobante] = @CompraNumeroComprobante
go

-- Compra Eliminar
Create or alter procedure dbo.spCompraEliminarRegistro
	(
	@CompraNumeroComprobante nchar(9)
	)
	with encryption
	As	
	delete from dbMiniMarket.Compra
	where [CompraNumeroComprobante] = @CompraNumeroComprobante
go

-- MOSTRAR
Create or alter procedure [dbo].[spCompraListasSinBorrados]
	As
		Select [CompraNumeroComprobante], [CompraTipoComprobante], [CompraUsuarioDocumentoIdentidad],
		[CompraProveedorDocumentoIdentidad], [CompraMontoTotal], [CompraFechaRegistro]
			from dbMiniMarket.Compra
go

-------
Create or alter procedure dbo.CompraRegistroMonto
(
	@CompraNumeroComprobante nchar(9),
	@CompraMontoTotal numeric(9,2)
)
with encryption
As
update dbMiniMarket.Compra
set
[CompraMontoTotal]=[CompraMontoTotal]+@CompraMontoTotal
where [CompraMontoTotal]=@CompraNumeroComprobante
go


-- =======================================================================
--							DETALLE COMPRA
-- =======================================================================

select*from dbMiniMarket.DetalleCompra
go

-- Compra para ComboBox
Create or alter procedure dbo.spCompraListaSinBorradosDetalleCompra
	As
		Select CompraNumeroComprobante
			from dbMiniMarket.Compra
go
--Producto para ComboBox
Create or alter procedure dbo.spProductoListaSinBorrarDetalle
	As
		Select ProductoCodigo,ProductoPrecioCompra,ProductoPrecioVenta
		from dbMiniMarket.Producto
go

-- Detalle Compra Agregar
Create or alter procedure dbo.DetalleCompraAgregarRegistro
	(
	@DetalleCompraId int, 
	@DetalleCompraCompraNumeroComprobante nchar(9),
	@DetalleCompraProductoCodigo nchar(5),
	@DetalleCompraPrecioCompra numeric(9,2),
	@DetalleCompraPrecioVenta numeric(9,2),
	@DetalleCompraCantidad numeric(9,2),
	@DetalleCompraFechaRegistro date
	)
	with encryption
	As	
	insert into dbMiniMarket.DetalleCompra
	([DetalleCompraId], [DetalleCompraCompraNumeroComprobante], [DetalleCompraProductoCodigo], [DetalleCompraPrecioCompra], 
	[DetalleCompraPrecioVenta], [DetalleCompraCantidad],[DetalleCompraFechaRegistro])
	
	values
	(@DetalleCompraId,@DetalleCompraCompraNumeroComprobante,@DetalleCompraProductoCodigo,
	@DetalleCompraPrecioCompra,@DetalleCompraPrecioVenta,@DetalleCompraCantidad,@DetalleCompraFechaRegistro)
go


-- Detalle Compra Editar
Create or alter procedure dbo.DetalleCompraEditarRegistro
	(
	@DetalleCompraId int, 
	@DetalleCompraCompraNumeroComprobante nchar(9),
	@DetalleCompraProductoCodigo nchar(5),
	@DetalleCompraPrecioCompra numeric(9,2),
	@DetalleCompraPrecioVenta numeric(9,2),
	@DetalleCompraCantidad numeric(9,2),
	@DetalleCompraFechaRegistro date
	)
	with encryption
	As	
	update dbMinimarket.DetalleCompra
	Set
	[DetalleCompraCompraNumeroComprobante] = @DetalleCompraCompraNumeroComprobante, 
	[DetalleCompraProductoCodigo] = @DetalleCompraProductoCodigo, 
	[DetalleCompraPrecioCompra] = @DetalleCompraPrecioCompra,
	[DetalleCompraPrecioVenta] = @DetalleCompraPrecioVenta,
	[DetalleCompraFechaRegistro] = @DetalleCompraFechaRegistro
	where [DetalleCompraId] = @DetalleCompraId
go


-- Detalle Compra Eliminar
Create or alter procedure dbo.spDetalleCompraEliminarRegistro
	(
	@DetalleCompraId int
	)
	with encryption
	As	
	delete from dbMiniMarket.DetalleCompra
	where [DetalleCompraId] = @DetalleCompraId
go


-- MOSTRAR
Create or alter procedure [dbo].[spDetalleCompraListasSinBorrados]
	As
		Select [DetalleCompraId], [DetalleCompraCompraNumeroComprobante], [DetalleCompraProductoCodigo], [DetalleCompraPrecioCompra],
		[DetalleCompraPrecioVenta], [DetalleCompraCantidad], [DetalleCompraCantidadPrecioCompra], [DetalleCompraFechaRegistro]
			from dbMiniMarket.DetalleCompra
go


