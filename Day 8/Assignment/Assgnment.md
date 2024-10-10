### Exact Numerics

-   **TINYINT**: 1-byte integer, range from 0 to 255.
-   **SMALLINT**: 2-byte integer, range from -32,768 to 32,767.
-   **INT**: 4-byte integer, range from -2,147,483,648 to 2,147,483,647.
-   **BIGINT**: 8-byte integer, range from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
-   **BIT**: 1-bit integer, can hold 0, 1, or NULL.
-   **DECIMAL(p, s)**: Fixed precision and scale numeric data type. `p` is the total number of digits, and `s` is the number of digits to the right of the decimal point.
-   **NUMERIC(p, s)**: Synonym for DECIMAL.
-   **MONEY**: 8-byte currency type, ranges from -2^63 to 2^63 - 1, with four decimal places.
-   **SMALLMONEY**: 4-byte currency type, ranges from -214,748.3648 to 214,748.3647.

### Approximate Numerics

-   **FLOAT**: Approximate numeric data type for floating point numbers. The storage size varies based on the precision specified.
-   **REAL**: 4-byte approximate numeric data type, similar to FLOAT but with less precision.

### Date and Time

-   **DATE**: Stores date values only (year, month, day).
-   **TIME**: Stores time values only (hour, minute, second).
-   **DATETIME**: Combines date and time, with a range from 1753 to 9999.
-   **DATETIMEOFFSET**: Includes time zone information.
-   **SMALLDATETIME**: Similar to DATETIME but with a smaller range and less precision (from 1900 to 2079).

### Character Strings

-   **CHAR(n)**: Fixed-length non-Unicode character string.
-   **VARCHAR(n)**: Variable-length non-Unicode character string.
-   **TEXT**: Variable-length non-Unicode string for large amounts of text.

### Unicode Character Strings

-   **NCHAR(n)**: Fixed-length Unicode character string.
-   **NVARCHAR(n)**: Variable-length Unicode character string.
-   **NTEXT**: Variable-length Unicode string for large amounts of text.

### Binary Strings

-   **BINARY(n)**: Fixed-length binary data.
-   **VARBINARY(n)**: Variable-length binary data.
-   **IMAGE**: Variable-length binary data for large objects.

### Other Data Types

-   **CURSOR**: Reference to a set of rows returned by a query.
-   **GEOGRAPHY**: For storing geospatial data.
-   **GEOMETRY**: For storing geometric data.
-   **HIERARCHYID**: Used for representing hierarchical data.
-   **JSON**: Stores JSON (JavaScript Object Notation) data.
-   **ROWVERSION**: Automatically generated binary number for version-stamping table rows.
-   **SQL_VARIANT**: Data type that can store values of various types.
-   **TABLE**: Used for storing a result set in a variable.
-   **UNIQUEIDENTIFIER**: 16-byte globally unique identifier (GUID).
-   **XML**: Stores XML data.

