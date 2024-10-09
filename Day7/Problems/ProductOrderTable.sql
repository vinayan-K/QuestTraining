CREATE TABLE products(
id BIGINT IDENTITY PRIMARY KEY,
name VARCHAR(100) NOT NULL,
description TEXT,
price DECIMAL(10,2) NOT NULL CHECK (price > 0),
stock_quantity INT NOT NULL DEFAULT 0 CHECK (stock_quantity >= 0 ),
catagory_id INT NOT NULL,
created_at DATETIME2 DEFAULT GETDATE(),
updated_at DATETIME2 DEFAULT GETDATE()
)
INSERT INTO products (name, description, price, stock_quantity, catagory_id) VALUES
('Laptop', 'A high-performance laptop for gaming and work.', 999.99, 50, 1),
('Smartphone', 'Latest model smartphone with advanced features.', 699.99, 100, 1),
('Headphones', 'Noise-cancelling over-ear headphones.', 199.99, 75, 2),
('Smartwatch', 'Fitness tracker with smart notifications.', 149.99, 30, 3),
('Tablet', 'Portable tablet for work and entertainment.', 349.99, 60, 1),
('Monitor', '27-inch 4K UHD monitor.', 399.99, 20, 2),
('Keyboard', 'Mechanical keyboard with customizable keys.', 129.99, 80, 4),
('Mouse', 'Wireless gaming mouse with high precision.', 89.99, 55, 4),
('Printer', 'All-in-one printer with scanning and copying.', 199.99, 25, 5),
('Router', 'Wi-Fi router with high-speed connectivity.', 79.99, 40, 6);


CREATE TABLE userlist1 (
    id BIGINT IDENTITY PRIMARY KEY,
   first_name VARCHAR(50) NOT NULL,
   last_name VARCHAR(50) NOT NULL,
   username VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20),
    dob DATETIME,
    password_hash VARCHAR(250),
    about TEXT
);

ALTER TABLE userlist1
ADD CONSTRAINT uq_username UNIQUE (username);

ALTER TABLE userlist1
ADD CONSTRAINT uq_email UNIQUE (email);

CREATE INDEX ix_phone ON userlist1(phone_number);

ALTER TABLE userlist1
ADD CONSTRAINT ck_phone CHECK (LEN(phone_number) BETWEEN 7 AND 20);

ALTER TABLE userlist1
ADD CONSTRAINT ck_dob CHECK (dob < GETDATE());

INSERT INTO userlist1 (first_name,last_name, username, email, phone_number, dob) VALUES
('user' ,'1','user_1','user1@mail.com','12366345','8-10-2002'),
('user' ,'2','user_2','user2@mail.com','123996345','8-10-2003'),
('user' ,'3','user_3','user3@mail.com','123976345','8-10-2004'),
('user' ,'4','user_4','user4@mail.com','121996345','8-10-2006'),
('user' ,'5','user_5','user5@mail.com','123996245','8-10-2001');


CREATE TABLE orders(
	id BIGINT PRIMARY KEY IDENTITY,
	quantity INT NOT NULL DEFAULT 1,
	product_id BIGINT  NOT NULL,
	user_id BIGINT  NOT NULL

	CONSTRAINT FK_orders_product_id
	FOREIGN KEY (product_id) REFERENCES products(id),

	CONSTRAINT FK_orders_user_id
	FOREIGN KEY (user_id) REFERENCES userlist1(id)
	)
INSERT INTO orders VALUES
	  (1,3,1),
	  (1,6,2),
	  (1,5,1),
	  (1,3,4),
	  (1,8,2);
	  
	  
	  SELECT 
    orders.id AS order_id,
    orders.quantity,
    products.id AS product_id,
    products.name,
    products.price
   
FROM orders
INNER JOIN
products 
ON orders.product_id = products.id;

SELECT 
    orders.id AS order_id,
    orders.quantity,
    products.id AS product_id,
    products.name,
    products.price,
    userlist1.first_name,
    userlist1.last_name

FROM orders
INNER JOIN products 
ON orders.product_id = products.id
INNER JOIN userlist1 
ON orders.user_id = userlist1.id;

SELECT 
    orders.id AS order_id,
    orders.quantity,
    products.id AS product_id,
    products.name,
    products.price

FROM orders
LEFT JOIN
products 
ON orders.product_id = products.id;

SELECT 
    orders.id AS order_id,
    orders.quantity,
    products.id AS product_id,
    products.name,
    products.price
   
FROM orders
RIGHT JOIN
products 
ON orders.product_id = products.id;