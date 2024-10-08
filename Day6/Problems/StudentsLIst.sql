--CREATE TABLE students(
--		id INT PRIMARY KEY IDENTITY,
--		name VARCHAR(50) NOT NULL,	
--		email VARCHAR(100) NOT NULL UNIQUE,
--		class INT NOT NULL DEFAULT 1,
--		)

--INSERT INTO students (name, email, class) VALUES
--('Alice Smith', 'alice.smith@example.com', '1'),
--('Bob Johnson', 'bob.johnson@example.com', '2'),
--('Charlie Brown', 'charlie.brown@example.com', '3'),
--('Daisy White', 'daisy.white@example.com', '4'),
--('Ethan Green', 'ethan.green@example.com', '5'),
--('Fiona Clark', 'fiona.clark@example.com', '2'),
--('George Miller', 'george.miller@example.com', '3'),
--('Hannah Lee', 'hannah.lee@example.com', '5'),
--('Ian Wilson', 'ian.wilson@example.com', '3'),
--('Jasmine Taylor', 'jasmine.taylor@example.com', '2');

--SELECT * FROM students;
--SELECT id ,name FROM students where id = 10;
--SELECT id ,name FROM students where email = 'jasmine.taylor@example.com';
--SELECT id ,name FROM students where id >= 10 and id <=15;
--SELECT id ,name FROM students ORDER BY name ASC;
--SELECT id ,name FROM students ORDER BY name DESC;
--SELECT id ,name FROM students where class =1 OR class = 5;
--SELECT id ,name FROM students WHERE class IN ('1', '3');
--SELECT class, count(id) FROM students GROUP BY class;
--SELECT class, count(id) as count_of_students FROM students GROUP BY class
--SELECT id ,name as full_name,class as grade FROM students ;
--SELECT class, count(id) as [count] FROM students GROUP BY class HAVING count(id) < 2;
--SELECT TOP 5 id ,name ,class FROM students ;
--SELECT id ,name FROM students ORDER BY id OFFSET 5 ROWS FETCH NEXT 3 ROWS ONLY;

--SELECT name,LEN(name) as name_length FROM students;
--SELECT count(id) as total_students  FROM students;
--SELECT count(id),SUM(class) as sum_of_classes FROM students;
--SELECT count(id),MIN(class) as min_of_classes FROM students;
--SELECT count(id),MAX(class) as max_of_classes FROM students;
SELECT count(id),AVG(class) as avg_of_classes FROM students;






