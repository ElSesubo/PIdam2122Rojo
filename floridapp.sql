CREATE DATABASE floridapp CHARACTER SET UTF8;

USE floridapp;

CREATE TABLE usuario(
nif VARCHAR(9) NOT NULL,
correo VARCHAR(45) NOT NULL,
contraseña VARCHAR(45) NOT NULL,
nombre VARCHAR(45) NOT NULL,
apellido VARCHAR(45) NOT NULL,
tel INT (9) NOT NULL,
profesor BOOL NOT NULL,
administrador BOOL NOT NULL,
cocina BOOL NOT NULL,
biblioteca BOOL NOT NULL,
alumno BOOL NOT NULL,
PRIMARY KEY(nif));

CREATE TABLE portatil(
id INT NOT NULL AUTO_INCREMENT,
reservado BOOL NOT NULL,
devuelto BOOL NOT NULL,
PRIMARY KEY (id));

CREATE TABLE pedido(
id INT NOT NULL AUTO_INCREMENT,
llevar BOOL NOT NULL,
nifusu VARCHAR(9) NOT NULL,
hora_pedido TIME NOT NULL,
recogido BOOL NOT NULL,
preparado BOOL NOT NULL,
PRIMARY KEY(id),
FOREIGN KEY (nifusu) REFERENCES usuario(nif) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE pecera(
id INT NOT NULL AUTO_INCREMENT,
reservado BOOL NOT NULL,
PRIMARY KEY(id));

CREATE TABLE ciclo(
id INT NOT NULL AUTO_INCREMENT,
nombre VARCHAR(10) NOT NULL,
curso INT NOT NULL,
clase VARCHAR(10) NOT NULL,
horario TIME NOT NULL,
presencialidad VARCHAR(45) NOT NULL,
nifusu VARCHAR(9) NOT NULL,
PRIMARY KEY(id),
FOREIGN KEY (nifusu) REFERENCES usuario(nif) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE mesa_cafeteria(
num INT NOT NULL AUTO_INCREMENT,
reservado BOOL NOT NULL,
PRIMARY KEY (num));

CREATE TABLE reserva_portatil(
id INT NOT NULL AUTO_INCREMENT,
hora_reserva TIME NOT NULL,
id_portatil INT NOT NULL,
id_user VARCHAR(9) NOT NULL,
PRIMARY KEY(id),
FOREIGN KEY (id_portatil) REFERENCES portatil(id),
FOREIGN KEY (id_user) REFERENCES usuario(nif));

CREATE TABLE reserva_pecera(
id INT NOT NULL AUTO_INCREMENT,
hora_reserva TIME NOT NULL,
id_pecera INT NOT NULL,
id_user VARCHAR(9) NOT NULL,
PRIMARY KEY (id),
FOREIGN KEY (id_pecera) REFERENCES pecera(id),
FOREIGN KEY (id_user) REFERENCES usuario(nif));

CREATE TABLE reservar_profesor(
id INT NOT NULL AUTO_INCREMENT,
hora_reserva TIME NOT NULL,
ocupado BOOL NOT NULL,
id_user VARCHAR(9) NOT NULL,playlist
nif_profesor VARCHAR(9) NOT NULL,
PRIMARY KEY(id),
FOREIGN KEY(id_user) REFERENCES usuario(nif),
FOREIGN KEY(nif_profesor) REFERENCES usuario(nif));

CREATE TABLE reserva_mesa_cafeteria(
id INT NOT NULL AUTO_INCREMENT,
hora_reserva TIME NOT NULL,
num_mesa INT NOT NULL,
id_user VARCHAR(9) NOT NULL,
PRIMARY KEY (id),
FOREIGN KEY (num_mesa) REFERENCES mesa_cafeteria(num),
FOREIGN KEY (id_user) REFERENCES usuario(nif));