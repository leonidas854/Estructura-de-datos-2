CREATE TABLE movimientos_inventario(id_movimiento VARCHAR(30) PRIMARY KEY,
id_producto varchar(30),id_local varchar(30),tipo_movimiento varchar(50),
cantidad int not null,fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
id_usuario varchar(30),comentario TEXT,Foreign key(id_usuario) references 
usuarios(id_usuario));