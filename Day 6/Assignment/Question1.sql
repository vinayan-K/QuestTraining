
--CREATE TABLE courses (
--    course_id INT PRIMARY KEY,
--    course_name VARCHAR(255) NOT NULL,
--    student_id INT,
--    course_fee DECIMAL(10, 2)
--);


--INSERT INTO courses (course_id, course_name, student_id, course_fee) VALUES
--(1, 'course1', 1, 150),
--(2, 'course1', 2, 150),
--(3, 'course2', 3, 200),
--(4, 'course2', 4, 200),
--(5, 'course2', 5, 200),
--(6, 'course4', 6, 120),
--(7, 'course4', 7, 120),
--(8, 'course5', 8, 100),
--(9, 'course6', 9, 180);

SELECT course_name, COUNT(student_id) AS total_students_enrolled
FROM courses
GROUP BY course_name;

SELECT course_name, SUM(course_fee) AS total_fees_collected
FROM courses
GROUP BY course_name;

SELECT course_name, COUNT(student_id) AS total_students_enrolled
FROM courses
GROUP BY course_name
ORDER BY total_students_enrolled DESC


