use exercices_sql;

create database IF NOT EXISTS exercices_sql;

CREATE TABLE IF NOT EXISTS Students (
student_id INT PRIMARY KEY AUTO_INCREMENT,
first_name VARCHAR (50),
last_name VARCHAR (50),
date_of_birth DATE,
email VARCHAR (50)
);

CREATE TABLE IF NOT EXISTS Courses (
course_id INT PRIMARY KEY AUTO_INCREMENT,
course_name VARCHAR (50),
instructor VARCHAR (50),
start_date DATE,
end_date DATE
);

INSERT INTO Students (first_name, last_name, date_of_birth, email)
VALUES ("Dumont", "Bob", '1992-05-29', "bob.dumont@mail.com"),
("Dupont", "Bernard", '1958-10-14', "dupont.bernard@mail.com"),
("Toto", "Charles", '1947-05-18', "toto.charles@mail.com");

INSERT INTO Courses (course_id, course_name, instructor, start_date, end_date)
VALUES ("Anglais", "Bobby", '2025-10-29', '2025-12-31'),
("Maths", "Bernardo", '2025-10-29', '2025-12-31');
