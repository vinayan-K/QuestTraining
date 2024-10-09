
CREATE TABLE exams (
    exam_id BIGINT PRIMARY KEY,
    min_mark INT,
    max_mark INT
);

INSERT INTO exams (exam_id, min_mark, max_mark) VALUES
(1, 0, 100),
(2, 0, 100);


CREATE TABLE students (
   student_id BIGINT PRIMARY KEY,
   name VARCHAR(100),
   age INT,
   email VARCHAR(100)
);

INSERT INTO students (student_id, name, age, email) VALUES
(1, 'Alice', 20, 'alice@example.com'),
(2, 'Bob', 21, 'bob@example.com'),
(3, 'Charlie', 21, 'charlie@example.com'),
(4, 'David', 23, 'david@example.com'),
(5, 'Eva', 19, 'eva@example.com'),
(6, 'Frank', 24, 'frank@example.com'),
(7, 'Grace', 22, 'grace@example.com'),
(8, 'Hannah', 20, 'hannah@example.com'),
(9, 'Ian', 21, 'ian@example.com'),
(10, 'Jack', 23, 'jack@example.com');


CREATE TABLE subjects (
   subject_id INT PRIMARY KEY IDENTITY,
   subject_code VARCHAR(10),
   subject_name VARCHAR(100)
);


INSERT INTO subjects (subject_code, subject_name) VALUES
('CS101', 'Computer Science'),
('PHY101', 'Physics'),
('MA101', 'Mathematics');


CREATE TABLE marks (
   exam_id BIGINT,
   subject_id INT,
   mark INT,
   student_id BIGINT,
   id INT PRIMARY KEY IDENTITY,
   FOREIGN KEY (exam_id) REFERENCES exams(exam_id),
   FOREIGN KEY (subject_id) REFERENCES subjects(subject_id),
   FOREIGN KEY (student_id) REFERENCES students(student_id)
);


INSERT INTO marks (exam_id, subject_id, mark, student_id) VALUES 
(1,  3, 85, 1),
(1,  1, 75, 1),
(2,  2, 90, 2),
(1,  1, 90, 2),
(2,  2, 90, 3),
(1,  1, 90, 2),
(2,  3, 90, 2),
(1,  1, 90, 4),
(2,  3, 60, 3);


SELECT
    marks.student_id AS student_id,
    subjects.subject_name AS subject_name
FROM marks 
INNER JOIN students  ON marks.student_id = students.student_id
INNER JOIN subjects  ON marks.subject_id = subjects.subject_id;

SELECT
    marks.student_id AS student_id,
    subjects.subject_name AS subject_name,
    marks.mark AS marks_scored
FROM marks 
INNER JOIN subjects  ON marks.subject_id = subjects.subject_id
INNER JOIN students  ON marks.student_id = students.student_id
WHERE subjects.subject_name = 'Physics';

SELECT
    marks.student_id,
    students.name ,
    marks.subject_id,
    
    exams.exam_id AS attended_exam_id 
FROM students 
INNER JOIN marks  ON students.student_id = marks.student_id
INNER JOIN subjects ON subjects.subject_id = marks.subject_id
INNER JOIN exams  ON exams.exam_id = marks.exam_id
WHERE students.student_id = 2; 



 









