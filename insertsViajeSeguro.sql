DELETE FROM Reservas;
DELETE FROM Cotizacions;
DELETE FROM Plans;
DELETE FROM Icons;
DELETE FROM Pasajeros;
DELETE FROM Regions;

INSERT INTO EstadoPagos (Nombre)
values
('Rechazado'),
('Procesando'),
('Aceptado');

INSERT INTO Icons (NombreIcono, CodigoIcono)
values
('Corona', 'fa-crown'),
('Gema', 'fa-gem'),
('Valija', 'fa-suitcase-rolling'),
('Spa', 'fa-spa'),
('Medico', 'fa-briefcase-medical'),
('Premio', 'fa-award'),
('Estrella', 'fa-star'),
('Trofeo', 'fa-trophy');

INSERT INTO Regions (Nombre, IconoNombre)
values
('América del Norte', 'NA'),
('América Central', 'CA'),
('América del Sur', 'SA'),
('Europa', 'EU'),
('Africa', 'AF'),
('Asia', 'AS'),
('Oceania', 'OC');

INSERT INTO Plans (CodigoPlan, Nombre, IconId, PrecioBaseDia)
values
('IB1','International Basic', 1, 282.6),
('PG1','Premium Gold', 2, 521.2),
('IG2','International Gold', 3, 482.0),
('IS3','Internacional Standard', 4, 199.5),
('UC1','Ultimate Cover', 5, 590.0),	
('CE1','Covid Ensurance', 6, 155.5)


INSERT INTO Pasajeros(Nombre, Apellido, Email, Telefono, Movil, CodigoID, TipoID, FechaNacimiento, FechaNacimiento_string, PaisNacionalidad, DireccionCalle, CodigoPostal, Ciudad, Estado, PaisResidencia, MenorDeEdad)
values
(
'Francisca',
'Cisneros',
'francisca_Cisneros78@hotmail.com ',
'928120957',
'55462121215',
'15812352J',
'DNI',
'1972-10-08 00:00:00.0000000', 
'08-10-1972',
'España',
'59081 Andrea Cuesta',
'08524',
'Haverhill',
'Galicia',
'Argentina',
0
),
(
'Guillermina',
'Rosas',
'guillermina.Rosas13@yahoo.com',
'971403766',
'32256562233',
'51159146Q',
'DNI',
'1990-07-18 00:00:00.0000000', 
'18-07-1990',
'Peru',
'847 Almanza Barrio',
'53524',
'Benjamínmouth',
'León',
'Peru',
0
),
(
'Ángela',
'Almonte',
'angela15@gmail.com',
'921067278',
'36558562233',
'37809308E',
'DNI',
'1971-06-07 00:00:00.0000000', 
'07-06-1971',
'Uruguay',
'221 Navarro Colonia',
'58321',
'San Luis Obispo',
'Balnaso',
'Argentina',
0
),
(
'Mercedes',
'Lebrón',
'mercedes_Lebrn@gmail.com',
'950623983',
'56566558233',
'72101167P',
'DNI',
'1982-04-17 00:00:00.0000000', 
'17-04-1982',
'Argentina',
'70026 Cervántez Bajada',
'SL885',
'Concepción Salvador',
'Baleares',
'Argentina',
0
),
(
'César',
'Guzmán',
'csar.Guzmn@hotmail.com',
'985857588',
'58885645455',
'88441814Y',
'DNI',
'1976-06-19 00:00:00.0000000', 
'19-06-1976',
'España',
'28528 Granado Riera',
'10317',
'Castellón',
'Principado de Asturias',
'España',
0
),
(
'Horacio',
'Valles',
'horacio.Valles57@yahoo.com',
'926688919',
'99658477412',
'24207917A',
'DNI',
'1957-01-22 00:00:00.0000000', 
'22-01-1957',
'Argentina',
'668 Lomeli Solar',
'90334',
'Reina',
'La Rioja',
'Argentina',
0
)

INSERT INTO Reservas(Codigo, TitularTarjeta,Tarjeta, EstadoPagoId, CantidadPasajeros, FechaEmision, FechaIda, FechaIda_string, FechaVuelta, FechaVuelta_string, CantidadDiasViaje, PlanId, OrigenId, DestinoId,    PrecioBase, RecargoPorcentaje, ImpuestosPorcentaje, Total, Activa, QrRuta, ReciboRuta, DocumentacionRuta)
values
('AB2202','Bernardi',5665, 3, 3 , '2021-09-03 00:00:00.0000000' ,'2021-09-18 00:00:00.0000000', '18-09-2021', '2021-09-24 00:00:00.0000000', '24-09-2021',7 , 1, 1, 2,		282.6, 0, 15,		5845.44, 1, '~/images/QRs/QRs_testimages.jpg', '~/images/receipts/receipts_testimages.jpg', '~/images/documentation/documentation_testimages.jpg' ),
('AF2375','Romanili',2234 ,1, 2 , '2021-09-03 00:00:00.0000000' ,'2021-10-01 00:00:00.0000000', '01-10-2021', '2021-10-17 00:00:00.0000000', '17-10-2021',17 ,2, 3, 2,		155.5, 10, 25,		15845.00, 1, '~/images/QRs/QRs_testimages.jpg', '~/images/receipts/receipts_testimages.jpg', '~/images/documentation/documentation_testimages.jpg' ),
('AB2204','Gomez',2233 ,1,1, '2021-09-04 00:00:00.0000000' ,'2021-10-05 00:00:00.0000000', '05-10-2021', '2021-10-16 00:00:00.0000000', '16-10-2021', 12 , 3, 7, 2,			590.0, 2, 10,		6658.66, 1, '~/images/QRs/QRs_testimages.jpg', '~/images/receipts/receipts_testimages.jpg', '~/images/documentation/documentation_testimages.jpg' ),
('C42205','Fernandez',3321 ,2,4, '2021-09-05 00:00:00.0000000' ,'2021-10-17 00:00:00.0000000', '17-10-2021', '2021-10-21 00:00:00.0000000', '21-10-2021', 5 , 4, 1, 6,		282.6, 0, 15,		3584.33, 1, '~/images/QRs/QRs_testimages.jpg', '~/images/receipts/receipts_testimages.jpg', '~/images/documentation/documentation_testimages.jpg' ),
('AB2206','Smith',6674 ,3,4, '2021-09-05 00:00:00.0000000' ,'2021-09-10 00:00:00.0000000', '10-09-2021', '2021-09-13 00:00:00.0000000', '13-09-2021', 4 , 5, 5, 5,			482.0, 0, 10,		56665.23, 1, '~/images/QRs/QRs_testimages.jpg', '~/images/receipts/receipts_testimages.jpg', '~/images/documentation/documentation_testimages.jpg' ),
('132202','Cantarin', 6663 ,1,4 ,'2021-09-06 00:00:00.0000000' ,'2021-10-02 00:00:00.0000000', '02-10-2021', '2021-10-14 00:00:00.0000000', '14-10-2021', 13 , 6, 4, 1,		282.6, 0, 10,		11245.22, 1, '~/images/QRs/QRs_testimages.jpg', '~/images/receipts/receipts_testimages.jpg', '~/images/documentation/documentation_testimages.jpg' ),
('AB2208','Fioro', 3321 ,3,1, '2021-09-06 00:00:00.0000000' ,'2021-10-04 00:00:00.0000000', '04-10-2021', '2021-10-06 00:00:00.0000000', '06-10-2021', 3 ,3, 1, 6,			521.2, 0, 0,		5335.85, 1, '~/images/QRs/QRs_testimages.jpg', '~/images/receipts/receipts_testimages.jpg', '~/images/documentation/documentation_testimages.jpg' ),
('AB2209','Fritz',9952 ,2,5 ,'2021-09-06 00:00:00.0000000' ,'2021-10-11 00:00:00.0000000', '11-10-2021', '2021-10-14 00:00:00.0000000', '14-10-2021', 4 , 2, 5, 3,			282.6, 0, 15,		22375.02, 1, '~/images/QRs/QRs_testimages.jpg', '~/images/receipts/receipts_testimages.jpg', '~/images/documentation/documentation_testimages.jpg' )


INSERT INTO Cotizacions (PasajeroId, CantidadDiasViaje, Total, ReservaId)
values
(1,7, 2274.93,1),
(2,4, 2397.52,1),
(3,14, 7512.26,1),
(4,20, 23274.93,2),
(5,3, 9552.13,2),
(6,4, 1244.86,3),
(1,5, 3232.93,4),
(2,4, 445.52,4),
(3,13, 7889.26,4),
(4,10, 4574.93,4),
(5,2, 8794.13,5),
(6,22, 32236.86,5),
(1,7, 2274.93,5),
(2,4, 2397.52,5),
(3,14, 7512.26,6),
(4,20, 23274.93,6),
(5,3, 9552.13,6),
(6,4, 1244.86,6),
(1,5, 3232.93,7),
(2,4, 445.52,8),
(3,13, 7889.26,8),
(4,10, 4574.93,8),
(5,2, 8794.13,8),
(6,22, 32236.86,8)
