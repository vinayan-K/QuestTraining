--CREATE TABLE patientslist (
--    id INT IDENTITY PRIMARY KEY,
--    first_name VARCHAR(50) NOT NULL,
--    last_name VARCHAR(50) NOT NULL,
--    gender CHAR(6) CHECK (gender IN ('M', 'F', 'Other')), 
--    age INT CHECK (age > 0 AND age < 120),
--    phone_number VARCHAR(15),
--    email VARCHAR(100) UNIQUE NOT NULL,
--    appointment_date DATE CHECK (appointment_date >= GETDATE()),
--    appointment_time TIME NOT NULL,
--    reason_for_visit VARCHAR(255) NOT NULL,
--    doctor_name VARCHAR(100) NOT NULL,
--    created_at DATETIME2 DEFAULT GETDATE() 
--);

INSERT INTO patientslist (first_name, last_name, gender, age, phone_number, email, appointment_date, appointment_time, reason_for_visit, doctor_name) VALUES
('John', 'Doe', 'M', 30, '123-456-7890', 'john.doe@example.com', GETDATE() + 1, '09:00', 'Routine check-up', 'Dr. Smith'),
('Jane', 'Smith', 'F', 25, '234-567-8901', 'jane.smith@example.com', GETDATE() + 2, '10:30', 'Flu symptoms', 'Dr. Johnson'),
('Alex', 'Johnson', 'Other', 40, '345-678-9012', 'alex.johnson@example.com', GETDATE() + 3, '11:15', 'Dental cleaning', 'Dr. Lee'),
('Emily', 'Davis', 'F', 35, '456-789-0123', 'emily.davis@example.com', GETDATE() + 4, '14:00', 'Follow-up visit', 'Dr. Williams'),
('Michael', 'Brown', 'M', 50, '567-890-1234', 'michael.brown@example.com', GETDATE() + 5, '15:45', 'Annual physical', 'Dr. Brown');

