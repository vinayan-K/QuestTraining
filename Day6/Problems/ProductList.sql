--CREATE TABLE products(
--id BIGINT IDENTITY PRIMARY KEY,
--name VARCHAR(100) NOT NULL,
--description TEXT,
--price DECIMAL(10,2) NOT NULL CHECK (price > 0),
--stock_quantity INT NOT NULL DEFAULT 0 CHECK (stock_quantity >= 0 ),
--catagory_id INT NOT NULL,
--created_at DATETIME2 DEFAULT GETDATE(),
--updated_at DATETIME2 DEFAULT GETDATE()
--)

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