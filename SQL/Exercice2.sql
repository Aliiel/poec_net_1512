CREATE DATABASE IF NOT EXISTS exercice_2;

USE exercice_2;

/*
CREATE TABLE IF NOT EXISTS Films (
id_film INT PRIMARY KEY AUTO_INCREMENT,
titre VARCHAR (100),
annee_sortie INT
);


CREATE TABLE IF NOT EXISTS Acteurs (
id_film INT,
id_acteur INT PRIMARY KEY AUTO_INCREMENT,
nom VARCHAR (50),
FOREIGN KEY (id_film) REFERENCES Films(id_film)
);


INSERT INTO Films (titre, annee_sortie)
VALUES ("Film A", 2010),
("Film B", 2015),
("Film C", 2020);


INSERT INTO Acteurs (nom, id_film)
VALUES ("Acteur 1", 1),
("Acteur 2", 1),
("Acteur 3", 2),
("Acteur 4", 2),
("Acteur 5", 3);

*/

SELECT a.nom, f.titre 
FROM Acteurs AS a
INNER JOIN Films as f ON a.id_film = f.id_film;

