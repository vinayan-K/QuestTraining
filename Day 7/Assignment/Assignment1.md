**SELECT**

The `SELECT` statement is fundamental to querying databases. It retrieves data from one or more tables. You can specify particular columns or use * to select all columns. Additionally, you can use functions like `DISTINCT` to remove duplicate results.
Example: `SELECT DISTINCT column1, column2 FROM table_name;`

**WHERE**

The `WHERE` clause is essential for filtering records based on conditions. It supports various operators like `=, <>, >, <, LIKE, IN, BETWEEN`, and more. This allows for precise data retrieval.
Example: 

    SELECT * FROM table_name
    WHERE column1 = 'value' AND column2 > 10;

**ORDER BY**

 The `ORDER BY` clause sorts the results returned by a `SELECT` statement. You can specify ascending (`ASC`) or descending (`DESC`) order. Sorting can be done based on multiple columns.
  Example: `SELECT * FROM table_name ORDER BY column1 ASC, column2 DESC;`

**INSERT INTO**

 The `INSERT INTO` statement is used to add new rows of data. You can insert a single row or multiple rows at once. The values must match the data types defined for the respective columns. 
 Example:   `INSERT INTO table_name (column1, column2) VALUES ('value1', 'value2');`

**UPDATE**

 The `UPDATE` statement modifies existing records. It’s crucial to use the `WHERE` clause to avoid updating all records unintentionally. You can update one or more columns simultaneously.
Example: 

    UPDATE table_name SET column1 = 'new_value', column2 = 'another_value' 	                        WHERE   condition;

**DELETE**

 The `DELETE` statement removes rows from a table. Like `UPDATE`, it’s important to use the `WHERE` clause to specify which rows to delete, as omitting it will delete all records in the table. 
 Example: `DELETE FROM table_name WHERE column1 = 'value';`

**CREATE**

 The `CREATE` statement is used to create new database objects. For tables, you define the columns, their data types, and any constraints (like PRIMARY KEY, NOT NULL). Example: 

    CREATE TABLE table_name ( id INT PRIMARY KEY, name VARCHAR(100) NOT NULL, created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP );

**DROP**
 The `DROP` statement permanently removes database objects. Be cautious, as this action cannot be undone. You can drop tables, databases, indexes, etc. 
 Example: `DROP TABLE table_name; DROP DATABASE database_name`;

**SUBQUERY**

 A `SUBQUERY` (or inner query) is a query within another SQL query. Subqueries can return single or multiple values and are often used in `SELECT`, `INSERT`, `UPDATE`, and `DELETE` statements.
Example: 

    SELECT column1 FROM table_name WHERE column2 IN (SELECT column2 FROM another_table WHERE condition);

**FUNCTIONS**

 SQL functions can be built-in or user-defined. Built-in functions perform calculations or data manipulations, while user-defined functions allow you to encapsulate complex operations. Common built-in functions include:

 - Aggregate functions:  
    COUNT()
The `COUNT()` function returns the number of rows that match a specified condition. It can count all rows or count non-null values in a specific column.
    SUM()
The `SUM()` function calculates the total sum of a numeric column
    AVG()
The `AVG()` function computes the average value of a numeric column
MIN()
The `MIN()` function returns the smallest value in a specified column.
 MAX()
The `MAX()` function returns the largest value in a specified column.

 - String functions: 
     CONCAT()
    The `CONCAT()` function is used to concatenate two or more strings into one. It can     take multiple string arguments and combines them together.
    SUBSTRING()
The `SUBSTRING()` function extracts a part of a string based on a starting position and a specified length.
LENGTH()
The `LENGTH()` function returns the number of characters in a string, which can be useful for validation or data analysis

   
  

 - -Date functions: 
  NOW()
The `NOW()` function returns the current date and time based on the server’s timezone.
DATEDIFF()
The `DATEDIFF()` function calculates the difference between two dates, returning the result as the number of days between them.
DATE_FORMAT()
The `DATE_FORMAT()` function formats a date value according to a specified format. This is useful for displaying dates in a user-friendly format.

**TRUNCATE**

The `TRUNCATE` statement is used to delete all rows from a table quickly, without logging individual row deletions. It’s faster than the `DELETE` statement because it doesn’t generate individual row delete logs.
Example:`TRUNCATE TABLE employees;`

**JOINS**
`Joins` are used to combine rows from two or more tables based on related columns. The main types of joins are:

-   `INNER JOIN`: Returns records with matching values in both tables.
- `LEFT JOIN` (or LEFT OUTER JOIN): Returns all records from the left table and the matched records from the right table. If there’s no match, NULL values are returned for columns from the right table.
- `RIGHT JOIN` (or RIGHT OUTER JOIN): Returns all records from the right table and the matched records from the left table. If there’s no match, NULL values are returned for columns from the left table.
- `FULL JOIN` (or FULL OUTER JOIN): Returns records when there’s a match in either left or right table records. Non-matching rows will contain NULL values.

 **GROUP BY**

The `GROUP BY` clause groups rows that have the same values in specified columns into summary rows, like aggregating data.
Example:

    SELECT department, COUNT(*) AS employee_count 
    FROM employees 
    GROUP BY department;

**HAVING**

The `HAVING` clause is used to filter records after aggregation, similar to how `WHERE` filters records before aggregation.
Example:

    SELECT department, COUNT(*) AS employee_count 
    FROM employees 
    GROUP BY department 
    HAVING employee_count > 10;

 **ALTER**

The `ALTER` statement is used to modify an existing database object, such as a table.
Example:`ALTER TABLE table_name ADD column_name datatype;`

 **DISTINCT**

The `DISTINCT` keyword is used to return unique values from a column, eliminating duplicates in the result set.
Example:`SELECT DISTINCT job_title FROM employees;`

 **CREATE INDEX**

An index improves the speed of data retrieval operations on a database table. However, it can slow down data insertion, updates, and deletions.
Example:`CREATE INDEX idx_last_name ON employees (last_name);`

**VIEW**

A view is a virtual table based on the result of a SQL query. It can simplify complex queries and enhance security.
Example:

    CREATE VIEW active_employees AS 
    SELECT * FROM employees WHERE status = 'active';
#### Limitations of Views

-   Performance: Views can be slower than base tables since they may involve complex queries or joins.
-   Updatability: Not all views are updatable. For instance, if a view contains aggregations or joins, you might not be able to update it directly.
-   Schema Changes: Changes to the underlying tables can affect the view’s validity and performance.
-   Security: While views can limit access to specific columns, if not configured properly, they may expose sensitive data.








