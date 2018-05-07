-- Crear usuari per a accés local.

CREATE USER 'hospitaladmin'@'localhost' IDENTIFIED BY 'hospitaladmin';

-- Crear base de dades.

CREATE DATABASE hospitaldb
  DEFAULT CHARACTER SET utf8
  DEFAULT COLLATE utf8_general_ci;

-- Assignar permisos a l'usuari local sobre la base de dades.

GRANT SELECT, INSERT, UPDATE, DELETE ON hospitaldb.* TO 'hospitaladmin'@'localhost';

USE hospitaldb;

-- creació taula users.
CREATE TABLE users(
id_user INT(4) NOT NULL AUTO_INCREMENT,
nickname VARCHAR(40) NOT NULL,
password VARCHAR(40) NOT NULL,
rol VARCHAR(40) DEFAULT NULL,
PRIMARY KEY(`id_user`)
) ENGINE = InnoDB;


INSERT INTO users
(`id_user`, `nickname`, `password`, `rol`) VALUES
(1, 'admin', 'admin', 'administrador'),
(2, 'isabel', 'i6', 'administratiu'),
(3, 'pep', 'p3', 'personalsanitari'),
(4, 'laura', 'l5', 'personalsanitari'),
(5, 'susana', 's6', 'administrador'),
(6, 'ines', 'i4', 'personalsanitari'),
(7, 'juan', 'j4', 'direccio');



-- creació taula pacients.
CREATE TABLE pacients(
id_pacient INT(4) NOT NULL AUTO_INCREMENT,
nom VARCHAR(40) NOT NULL,
cognoms VARCHAR(40) NOT NULL,
adreça VARCHAR(60) DEFAULT NULL,
poblacio VARCHAR(40) DEFAULT NULL,
dni VARCHAR(9) DEFAULT NULL,
nhc VARCHAR(2) DEFAULT NULL,
PRIMARY KEY(`id_pacient`)
) ENGINE = InnoDB;


INSERT INTO pacients
(`id_pacient`, `nom`, `cognoms`, `adreça`, `poblacio`, `dni`, `nhc`) VALUES
(1, 'Judit', 'Sans Garcia', 'Avinguda Meridiana, 153', '08001 Barcelona', '12345678Z', '1'),
(2, 'Josep', 'Segura Andreu', 'Carrer Faristol, 11', '08008 Barcelona', '00000000T', '2'),
(3, 'Anna', 'Gutierrez Gonzalez', 'Plaça Otamendi, 5', '08940 Cornella', '22620599F', '3'),
(4, 'Ibrahim', 'Fatim', 'Carrer Molins, 4', 'Hospitalet', '21768220P', '4'),
(5, 'Luis', 'Sanchez Felosio', 'Carrer Mediterrani, 12', '08007 Barcelona', '79111401A', '5'),
(6, 'Lisandro', 'Garcia Dolosa', 'Carrer Jorda, 51', '08034 Hospitalet', '94747005T', '6');