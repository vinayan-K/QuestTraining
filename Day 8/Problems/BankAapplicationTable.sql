CREATE TABLE customers(
    id INT PRIMARY KEY IDENTITY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    phone_number VARCHAR(15) NOT NULL UNIQUE,
)


CREATE TABLE accounts(
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(50) NOT NULL,
    balance DECIMAL (15,2) NOT NULL,
    account_number VARCHAR(10) NOT NULL UNIQUE,
    customer_id INT ,
    
    CONSTRAINT FK_customer_id FOREIGN KEY(customer_id) REFERENCES customers(id) ON DELETE SET NULL
)


CREATE TABLE transactions(
    id INT PRIMARY KEY IDENTITY,
    transaction_type VARCHAR(50) NOT NULL,
    amount DECIMAL (15,2) NOT NULL,
    transaction_date DATETIME,
    description TEXT,
    account_id INT  ,
    
    CONSTRAINT FK_account_id FOREIGN KEY(account_id) REFERENCES accounts(id) ON DELETE SET NULL
    
)

CREATE TABLE transfers(
    id INT PRIMARY KEY IDENTITY,
    amount DECIMAL(15,2) NOT NULL,
    transaction_date DATETIME,
    from_account_id INT NOT NULL,
    to_account_id INT NOT NULL,
    
    CONSTRAINT FK_from_account_id FOREIGN KEY(from_account_id) REFERENCES accounts(id),
    CONSTRAINT FK_to_account_id FOREIGN KEY(to_account_id) REFERENCES accounts(id),
)

INSERT INTO customers ( first_name, last_name, email, phone_number) VALUES
( 'Alice', 'Smith', 'alice@example.com', '555-1234'),
( 'Bob', 'Johnson', 'bob@example.com', '555-5678'),
( 'Danny', 'Wilson', 'danny@example.com', '556-5678'),
( 'Charlie', 'Brown', 'charlie@example.com', '555-8765');

INSERT INTO accounts (customer_id,name, balance,account_number) VALUES
( 1, 'Alice Savings',  1500.00,'10001'),
( 2, 'Danny Checking', 2500.00,'23567'),
( 3, 'Bob Savings',  1000.00,'48230'),
( 4, 'Charlie Checking', 3000.00,'75694');

INSERT INTO transactions ( account_id, transaction_type, amount, transaction_date) VALUES
( 1, 'deposit', 1000.00, '2023-02-15'),
( 2, 'withdrawal', 1000.00, '2023-02-15'),
( 3, 'deposit', 1000.00, '2023-02-15'),
( 4, 'withdrawal', 1000.00, '2023-03-10');

UPDATE accounts 
SET balance = balance + 1000.00 
WHERE id = 1; 

INSERT INTO transactions (account_id, transaction_type, amount, transaction_date) 
VALUES (1, 'deposit', 1000.00, GETDATE());

UPDATE accounts 
SET balance = balance - 1000.00 
WHERE id = 2; 

INSERT INTO transactions (account_id, transaction_type, amount, transaction_date) 
VALUES (2, 'withdrawal', 1000.00, GETDATE());

UPDATE accounts 
SET balance = balance + 1000.00 
WHERE id = 3; 

INSERT INTO transactions (account_id, transaction_type, amount, transaction_date) 
VALUES (3, 'deposit', 1000.00, GETDATE());

UPDATE accounts 
SET balance = balance - 1000.00 
WHERE id = 4; 

INSERT INTO transactions (account_id, transaction_type, amount, transaction_date) 
VALUES (4, 'withdrawal', 1000.00, GETDATE());

INSERT INTO transfers (from_account_id, to_account_id, amount, transaction_date) VALUES
( 2, 1, 1000.00, '2023-03-25');
 
UPDATE accounts 
SET balance = balance - 1000.00  
WHERE id = 2;  

UPDATE accounts 
SET balance = balance + 1000.00 
WHERE id = 1;  

INSERT INTO transactions (account_id, transaction_type, amount, transaction_date,description) 
VALUES (2, 'transfer_out', 1000.00, GETDATE(),'Transfer out to account 2');  

INSERT INTO transactions (account_id, transaction_type, amount, transaction_date,description) 
VALUES (1, 'transfer_in', 1000.00, GETDATE(),'Transfer from account 1');  

UPDATE customers
SET first_name = 'Jane',
    last_name = 'Wilson'
WHERE id = 1 ;



SELECT
    customers.id AS customer_id,
    customers.first_name AS Name,
    accounts.id AS account_id,
    accounts.account_number AS account_number,
    accounts.balance AS Balance,
    transactions.amount AS Amount,
    transactions.transaction_date AS Date,
    transactions.transaction_type AS transaction_type,
    transactions.description AS Description
    
FROM accounts
INNER JOIN transactions ON accounts.id = transactions.account_id
INNER JOIN customers ON accounts.customer_id = customers.id
WHERE accounts.id = 2;