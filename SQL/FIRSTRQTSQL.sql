create database if not exists my_bdd;

use my_bdd;

DROP table User;

CREATE TABLE if not exists User (
id INT PRIMARY KEY AUTO_INCREMENT,
nom VARCHAR (50) NOT NULL,
prenom VARCHAR (50) UNIQUE,
age INT DEFAULT(18),
CONSTRAINT Check_age CHECK (age >= 18)
);


CREATE TABLE Command (
id INT primary key auto_increment,
prix DOUBLE NOT NULL,
id_user INT NOT NULL,
FOREIGN KEY (id_user) REFERENCES User(id)
);



/*
ALTER TABLE User
ADD telephone VARCHAR(10);

ALTER TABLE User
MODIFY prenom VARCHAR(100);

ALTER TABLE User 
CHANGE nom nom_user VARCHAR(30);

ALTER TABLE User 
DROP age;
*/