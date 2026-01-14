CREATE DATABASE IF NOT EXISTS exercice_table_2;

USE exercice_table_2;

CREATE TABLE IF NOT EXISTS Utilisateurs (
id_utilisateurs INT PRIMARY KEY AUTO_INCREMENT,
nom_utilisateur VARCHAR (50),
email VARCHAR (50),
date_inscription DATE,
pays VARCHAR (50)
);


CREATE TABLE IF NOT EXISTS Chansons (
id_chansons INT PRIMARY KEY AUTO_INCREMENT,
titre VARCHAR (50),
artiste VARCHAR (50),
album VARCHAR (50),
duree DECIMAL,
genre VARCHAR (50),
annee_sortie INT
);


CREATE TABLE IF NOT EXISTS Playlists (
id_playlist INT PRIMARY KEY AUTO_INCREMENT,
nom_playlist VARCHAR (50),
id_utilisateur INT,
FOREIGN KEY (id_utilisateur) REFERENCES Utilisateurs (id_utilisateurs),
date_creation DATE
);