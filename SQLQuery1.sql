USE [PapeleriaObligatorio];
GO
-- Insertando datos de prueba en la tabla Articulos
INSERT INTO [dbo].[Articulos] (Nombre, Codigo, Descripcion, Precio)
VALUES 
('Cuaderno A4', 'CUA4', 'Cuaderno tama�o A4 con 100 hojas', 3.50),
('Bol�grafo Azul', 'BOLAZ', 'Bol�grafo de tinta azul', 0.50),
('L�piz HB', 'LAPHB', 'L�piz grafito HB', 0.25),
('Goma de Borrar', 'GOMA1', 'Goma de borrar blanca', 0.30),
('Marcador Permanente', 'MARKP', 'Marcador permanente negro', 1.20),
('Resaltador Amarillo', 'RESA', 'Resaltador amarillo', 0.80),
('Tijeras', 'TIJ', 'Tijeras de acero inoxidable', 2.00),
('Pegamento en Barra', 'PEGB', 'Pegamento en barra 20g', 0.75),
('Cartulina Blanca', 'CARB', 'Cartulina blanca tama�o A3', 0.50),
('Grapadora', 'GRAP', 'Grapadora met�lica', 5.00),
('Cinta Adhesiva', 'CINT', 'Cinta adhesiva transparente', 1.00),
('Corrector L�quido', 'CORL', 'Corrector l�quido blanco', 1.25),
('Carpeta Archivadora', 'CARP', 'Carpeta archivadora con anillas', 4.50),
('Rotulador Rojo', 'ROTR', 'Rotulador de tinta roja', 0.70),
('Bloc de Notas', 'BLON', 'Bloc de notas adhesivas', 1.50),
('Papel Fotocopia A4', 'PAPA4', 'Papel de fotocopia tama�o A4', 3.00),
('Calculadora Cient�fica', 'CALC', 'Calculadora cient�fica con funciones avanzadas', 15.00),
('Regla 30cm', 'REG30', 'Regla de pl�stico 30 cm', 0.50),
('Comp�s', 'COMP', 'Comp�s met�lico', 2.00),
('Estuche', 'EST', 'Estuche escolar', 3.00),
('Mochila Escolar', 'MOCH', 'Mochila escolar con compartimentos', 25.00),
('Cuaderno de Bocetos', 'CUAB', 'Cuaderno de bocetos tama�o A4', 4.00),
('Pegamento L�quido', 'PEGL', 'Pegamento l�quido 100ml', 1.00),
('Sacapuntas', 'SAC', 'Sacapuntas met�lico', 0.50),
('L�pices de Colores', 'LAPC', 'Set de 12 l�pices de colores', 3.00),
('Agenda 2024', 'AGEN24', 'Agenda a�o 2024', 7.00),
('Plastilina', 'PLAS', 'Set de plastilina de colores', 2.50),
('Pinceles', 'PINC', 'Set de pinceles para pintar', 3.50),
('Tempera', 'TEMP', 'Set de temperas de colores', 4.00),
('Paleta para Pintar', 'PALP', 'Paleta de pl�stico para mezclar pintura', 1.50),
('Portaminas', 'PORT', 'Portaminas con 3 minas de repuesto', 2.50),
('Minas 0.5mm', 'MIN05', 'Set de minas 0.5mm para portaminas', 1.00),
('Borrador para Pizarra', 'BORP', 'Borrador de fieltro para pizarra blanca', 1.25),
('Marcadores para Pizarra', 'MARP', 'Set de 4 marcadores para pizarra blanca', 5.00),
('Tiza Blanca', 'TIZB', 'Caja de tiza blanca', 1.00),
('Tiza de Colores', 'TIZC', 'Caja de tiza de colores', 1.50),
('Carpetas de Pl�stico', 'CARPP', 'Set de 10 carpetas de pl�stico transparentes', 3.00),
('Archivador Met�lico', 'ARCHM', 'Archivador met�lico de 4 cajones', 50.00),
('Cajas de Archivo', 'CAJAR', 'Set de 5 cajas de archivo', 10.00),
('Rotulador Permanente', 'ROTP', 'Rotulador permanente negro', 1.00),
('Pluma Estilogr�fica', 'PLUM', 'Pluma estilogr�fica con cartuchos', 12.00),
('Cartuchos de Tinta', 'CART', 'Set de 5 cartuchos de tinta para pluma', 2.00),
('Cuaderno de Matem�ticas', 'CUAM', 'Cuaderno cuadriculado para matem�ticas', 3.00),
('Libreta de Notas', 'LIBN', 'Libreta de notas tama�o A6', 2.00),
('Set de Geometr�a', 'SETG', 'Set de geometr�a con regla, comp�s y transportador', 3.50),
('Plastilina de Colores', 'PLACO', 'Set de plastilina de colores', 2.50),
('Tijeras de Punta Redonda', 'TIJR', 'Tijeras de punta redonda para ni�os', 1.50),
('Cinta Correctora', 'CINC', 'Cinta correctora', 2.00),
('Papel de Embalar', 'PAPEM', 'Rollo de papel de embalar', 3.00),
('Papel de Regalo', 'PAPRG', 'Rollo de papel de regalo', 2.00),
('Envoltorio para Libros', 'ENVL', 'Set de 10 envoltorios para libros', 5.00),
('Caja de L�pices', 'CAJAL', 'Caja de 24 l�pices de colores', 6.00),
('Archivador de Palanca', 'ARCHP', 'Archivador de palanca tama�o A4', 4.00),
('Bolsa de Pl�stico', 'BOLP', 'Bolsa de pl�stico con cierre herm�tico', 1.50),
('Bol�grafo Negro', 'BOLN', 'Bol�grafo de tinta negra', 0.50),
('Bol�grafo Rojo', 'BOLR', 'Bol�grafo de tinta roja', 0.50),
('Marcador Fluorescente', 'MARF', 'Marcador fluorescente', 1.00),
('Papel Mantequilla', 'PAPM', 'Rollo de papel mantequilla', 2.50),
('Libreta de Dibujo', 'LIBD', 'Libreta de dibujo tama�o A4', 4.00),
('Separadores de Cartulina', 'SEPC', 'Set de 10 separadores de cartulina', 1.50),
('Cinta Adhesiva de Doble Cara', 'CINDC', 'Cinta adhesiva de doble cara', 3.00),
('Estuche de L�pices', 'ESTL', 'Estuche con 24 l�pices de colores', 10.00),
('Carpeta con Separadores', 'CARSE', 'Carpeta con separadores tama�o A4', 5.00),
('Archivador A-Z', 'ARCHAZ', 'Archivador A-Z tama�o A4', 6.00),
('Set de Sobres', 'SETS', 'Set de 50 sobres blancos', 3.00),
('Borrador de Pl�stico', 'BORPL', 'Borrador de pl�stico blanco', 0.30),
('Grapas', 'GRAPA', 'Caja de grapas', 1.00),
('Cuaderno de Espiral', 'CUAE', 'Cuaderno de espiral tama�o A5', 2.50),
('Bloc de Dibujo', 'BLOD', 'Bloc de dibujo tama�o A3', 5.00),
('Papel Crep�', 'PAPC', 'Set de 10 hojas de papel crep�', 2.00),
('Bol�grafo Verde', 'BOLV', 'Bol�grafo de tinta verde', 0.50),
('Cuaderno de M�sica', 'CUAMU', 'Cuaderno de m�sica con pentagramas', 3.50);

-- Insertando datos de prueba en la tabla Clientes
INSERT INTO [dbo].[Clientes] (RazonSocial, Rut, NombreCliente_Nombre, NombreCliente_Apellido, Direccion_NombreCalle, Direccion_NumeroPuerta, Direccion_Ciudad, Direccion_DistanciaKm)
VALUES
('Papeler�a El Escriba', '12345678-9', 'Juan', 'P�rez', 'Calle Falsa', '123', 'Montevideo', 15.5),
('Oficinas Express', '87654321-0', 'Ana', 'Gonz�lez', 'Av. Libertador', '456', 'Salto', 200.0),
('Librer�a Central', '11223344-5', 'Carlos', 'Rodr�guez', 'Calle Real', '789', 'Paysand�', 250.0),
('La Oficina Moderna', '55667788-9', 'Laura', 'Fern�ndez', 'Calle Principal', '321', 'Maldonado', 120.0),
('Papeles y M�s', '99887766-5', 'Mar�a', 'L�pez', 'Avenida Siempreviva', '987', 'Rivera', 300.0),
('Librer�a Escolar', '44556677-8', 'Jos�', 'Garc�a', 'Calle Comercio', '654', 'Canelones', 50.0),
('Tienda de Papeler�a', '33445566-7', 'Luc�a', 'Mart�nez', 'Av. Central', '543', 'San Jos�', 80.0),
('El Mundo del Papel', '22334455-6', 'Luis', 'Hern�ndez', 'Calle 8 de Octubre', '210', 'Durazno', 160.0),
('Librer�a Estrella', '66778899-0', 'Marta', 'G�mez', 'Calle Nueva', '147', 'Colonia', 130.0),
('Papeler�a y Regalos', '88990011-2', 'Pedro', 'D�az', 'Avenida Principal', '369', 'Florida', 90.0);

-- Insertando datos de prueba en la tabla Configuraciones
INSERT INTO [dbo].[Configuraciones] (Nombre, Valor)
VALUES
('DescuentoMayoreo', 10),
('Impuesto', 21),
('EnvioGratis', 50),
('StockMinimo', 5),
('TiempoEntrega', 7),
('HoraCierre', 18),
('HoraApertura', 9),
('DiasDeTrabajo', 5),
('NumeroMaximoPedidos', 100),
('PromocionMes', 20),
('Tope', 60),
('PageSize', 10);

-- Insertando datos de prueba en la tabla Usuarios
INSERT INTO [dbo].[Usuarios] (Email, Password, PasswordSinEncript, NombreCompleto_Nombre, NombreCompleto_Apellido, Discriminator)
VALUES
('juan.perez@escriba.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Juan', 'P�rez', 'Encargado'),
('ana.gonzalez@oficinas.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Ana', 'Gonz�lez', 'Encargado'),
('carlos.rodriguez@libreria.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Carlos', 'Rodr�guez', 'Encargado'),
('laura.fernandez@moderna.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Laura', 'Fern�ndez', 'Encargado'),
('maria.lopez@papeles.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Mar�a', 'L�pez', 'Encargado'),
('jose.garcia@escolar.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Jos�', 'Garc�a', 'Encargado'),
('lucia.martinez@papeleria.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6!', 'Admin1234!', 'Luc�a', 'Mart�nez', 'Encargado'),
('luis.hernandez@mundo.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Luis', 'Hern�ndez', 'Encargado'),
('marta.gomez@estrella.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Marta', 'G�mez', 'Encargado'),
('pedro.diaz@regalos.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Pedro', 'D�az', 'Encargado'),
('andres.sosa@correo.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Andr�s', 'Sosa', 'Administrador'),
('paula.mendez@empresa.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Paula', 'M�ndez', 'Administrador'),
('roberto.alvarez@negocios.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Roberto', '�lvarez', 'Administrador'),
('veronica.torres@personal.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Ver�nica', 'Torres', 'Administrador'),
('martin.lopez@proyectos.com', '5ce41ada64f1e8ffb0acfaafa622b141438f3a5777785e7f0b830fb73e40d3d6', 'Admin1234!', 'Mart�n', 'L�pez', 'Administrador');


-- Insertando datos de prueba en la tabla TipoMovimientos
INSERT INTO [dbo].[TipoMovimientos] (Nombre, TipoMovStock)
VALUES
('Entrada', 2),
('Salida', 1),
('Devoluci�n', 2),
('Venta', 1),
('Transferencia', 1),
('Donaci�n', 1),
('Destrucci�n', 1),
('Producci�n', 2),
('Reparaci�n', 2);

-- Insertando datos de prueba en la tabla Pedidos
INSERT INTO [dbo].[Pedidos] (ClienteId, Fecha, FechaPrometida, Anulado, Discriminator)
VALUES
(1, '2024-06-01 10:00:00', '2024-06-10 10:00:00', 0, 'PedidoComun'),
(2, '2024-06-02 11:00:00', '2024-06-11 11:00:00', 0, 'PedidoComun'),
(3, '2024-06-03 12:00:00', '2024-06-12 12:00:00', 0, 'PedidoComun'),
(4, '2024-06-04 13:00:00', '2024-06-13 13:00:00', 0, 'PedidoExpress'),
(5, '2024-06-05 14:00:00', '2024-06-14 14:00:00', 0, 'PedidoExpress'),
(6, '2024-06-06 15:00:00', '2024-06-15 15:00:00', 0, 'PedidoComun'),
(7, '2024-06-07 16:00:00', '2024-06-16 16:00:00', 0, 'PedidoComun'),
(8, '2024-06-08 17:00:00', '2024-06-17 17:00:00', 0, 'PedidoExpress'),
(9, '2024-06-09 18:00:00', '2024-06-18 18:00:00', 0, 'PedidoComun'),
(10, '2024-06-10 19:00:00', '2024-06-19 19:00:00', 0, 'PedidoExpress');

-- Insertando datos de prueba en la tabla Movimientos
INSERT INTO [dbo].[Movimientos] (FechaMovimiento, ArticuloId, TipoMovimientoId, CantUnidades, EmailUsuario)
VALUES
('2023-06-01 10:00:00', 1, 1, 50, 'juan.perez@escriba.com'),
('2023-06-02 11:00:00', 2, 2, 20, 'ana.gonzalez@oficinas.com'),
('2023-06-03 12:00:00', 3, 1, 30, 'carlos.rodriguez@libreria.com'),
('2023-06-04 13:00:00', 4, 2, 10, 'laura.fernandez@moderna.com'),
('2024-06-05 14:00:00', 5, 1, 40, 'maria.lopez@papeles.com'),
('2024-06-06 15:00:00', 6, 2, 15, 'jose.garcia@escolar.com'),
('2024-06-07 16:00:00', 7, 1, 25, 'lucia.martinez@papeleria.com'),
('2024-06-08 17:00:00', 8, 2, 12, 'luis.hernandez@mundo.com'),
('2024-06-09 18:00:00', 9, 1, 35, 'marta.gomez@estrella.com'),
('2024-06-10 19:00:00', 10, 2, 22, 'pedro.diaz@regalos.com'),
('2024-06-11 10:00:00', 11, 1, 45, 'juan.perez@escriba.com'),
('2024-06-12 11:00:00', 12, 2, 18, 'ana.gonzalez@oficinas.com'),
('2024-06-13 12:00:00', 13, 1, 32, 'carlos.rodriguez@libreria.com'),
('2024-06-14 13:00:00', 14, 2, 14, 'laura.fernandez@moderna.com'),
('2024-06-15 14:00:00', 15, 1, 38, 'maria.lopez@papeles.com'),
('2024-06-16 15:00:00', 16, 2, 16, 'jose.garcia@escolar.com'),
('2024-06-17 16:00:00', 17, 1, 27, 'lucia.martinez@papeleria.com'),
('2024-06-18 17:00:00', 18, 2, 13, 'luis.hernandez@mundo.com'),
('2024-06-19 18:00:00', 19, 1, 34, 'marta.gomez@estrella.com'),
('2024-06-20 19:00:00', 20, 2, 21, 'pedro.diaz@regalos.com'),
('2024-06-21 10:00:00', 21, 1, 49, 'juan.perez@escriba.com'),
('2024-06-22 11:00:00', 22, 2, 20, 'ana.gonzalez@oficinas.com'),
('2025-06-23 12:00:00', 23, 1, 31, 'carlos.rodriguez@libreria.com'),
('2025-06-24 13:00:00', 24, 2, 11, 'laura.fernandez@moderna.com'),
('2025-06-25 14:00:00', 25, 1, 41, 'maria.lopez@papeles.com'),
('2025-06-26 15:00:00', 26, 2, 17, 'jose.garcia@escolar.com'),
('2025-06-27 16:00:00', 27, 1, 29, 'lucia.martinez@papeleria.com'),
('2025-06-28 17:00:00', 28, 2, 13, 'luis.hernandez@mundo.com'),
('2025-06-29 18:00:00', 29, 1, 36, 'marta.gomez@estrella.com'),
('2025-06-30 19:00:00', 30, 2, 19, 'pedro.diaz@regalos.com');
