--CREATE TABLE user1(
--		id INT PRIMARY KEY IDENTITY,
--		first_name VARCHAR(50) NOT NULL,
--		last_name VARCHAR(50) NOT NULL,
--		email VARCHAR(100) NOT NULL UNIQUE,
--		age INT NOT NULL DEFAULT 18,
--		)

INSERT INTO user1 (first_name, last_name, email, age) VALUES
('User', '1', 'user1@gmail.com', 20),
('User', '2', 'user2@gmail.com', 30),
('User', '3', 'user3@gmail.com', 25),
('User', '4', 'user4@gmail.com', 27),
('User', '5', 'user5@gmail.com', 28);
