CREATE DATABASE IF NOT EXISTS exercice_table_1;

use exercice_table_1;

CREATE TABLE IF NOT EXISTS Livres (
id_livre INT PRIMARY KEY AUTO_INCREMENT,
titre VARCHAR (50),
auteur VARCHAR (50),
annee_publication INT,
genre VARCHAR (50),
exemplaires_disponibles INT
);

CREATE TABLE IF NOT EXISTS Membres (
id_membre INT PRIMARY KEY AUTO_INCREMENT,
nom VARCHAR (50),
prenom VARCHAR (50),
date_naissance INT,
adresse VARCHAR (50),
email VARCHAR(50),
telephone VARCHAR(10)
);




