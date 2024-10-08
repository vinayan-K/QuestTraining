--create table users
--(id bigint identity,
--first_name varchar(50) not null,
--last_name varchar(50) not null,
--username varchar(25)not null,
--email varchar(100) not null,
--phone_number varchar(20),
--dob datetime,
--password_hash varchar(250),
--about text
--)

--ALTER TABLE users
--ADD CONSTRAINT PK_user_id PRIMARY KEY (id);

--ALTER TABLE users
--ADD CONSTRAINT uq_username UNIQUE (username);

--ALTER TABLE users
--ADD CONSTRAINT uq_email UNIQUE (email);

--CREATE INDEX ix_phone ON users(phone_number);

--ALTER TABLE users
--ADD CONSTRAINT ck_phone CHECK (LEN(phone_number) BETWEEN 7 AND 20);

--ALTER TABLE users
--ADD CONSTRAINT ck_dob CHECK (dob < GETDATE());


--INSERT INTO users (id, username, email, phone_number, dob) VALUES
--(1, 'alice_smith', 'alice.smith@example.com', '1234567', '2000-01-15'),
--(2, 'bob_johnson', 'bob.johnson@example.com', '2345678', '1995-05-20'),
--(3, 'charlie_brown', 'charlie.brown@example.com', '3456789', '1998-08-30'),
--(4, 'daisy_white', 'daisy.white@example.com', '4567890', '2001-02-25'),
--(5, 'ethan_green', 'ethan.green@example.com', '5678901', '1997-11-11'),
--(6, 'fiona_clark', 'fiona.clark@example.com', '6789012', '1999-04-18'),
--(7, 'george_miller', 'george.miller@example.com', '7890123', '1996-09-05'),
--(8, 'hannah_lee', 'hannah.lee@example.com', '8901234', '2002-07-22'),
--(9, 'ian_wilson', 'ian.wilson@example.com', '9012345', '1994-12-12'),
--(10, 'jasmine_taylor', 'jasmine.taylor@example.com', '0123456', '2003-03-15');




