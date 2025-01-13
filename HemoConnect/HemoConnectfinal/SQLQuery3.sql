select * from appointments
select * from users 
select * from donors
select * from blooddonations

INSERT INTO users (username, email, usertype, password) VALUES
('Alex', 'alex@example.com', 'user', 'password21'),
('Beth', 'beth@example.com', 'user', 'password22'),
('Chris', 'chris@example.com', 'user', 'password23'),
('Diana', 'diana@example.com', 'user', 'password24'),
('Eric', 'eric@example.com', 'user', 'password25'),
('Fiona', 'fiona@example.com', 'user', 'password26'),
('Gary', 'gary@example.com', 'user', 'password27'),
('Helen', 'helen@example.com', 'user', 'password28'),
('Ian', 'ian@example.com', 'user', 'password29'),
('Julia', 'julia@example.com', 'user', 'password30'),
('Kevin', 'kevin@example.com', 'user', 'password31'),
('Linda', 'linda@example.com', 'user', 'password32'),
('Mark', 'mark@example.com', 'user', 'password33'),
('Nancy', 'nancy@example.com', 'user', 'password34'),
('Oscar', 'oscar@example.com', 'user', 'password35'),
('Paul', 'paul@example.com', 'user', 'password36'),
('Rachel', 'rachel@example.com', 'user', 'password37'),
('Simon', 'simon@example.com', 'user', 'password38'),
('Tina', 'tina@example.com', 'user', 'password39'),
('Vincent', 'vincent@example.com', 'user', 'password40');



INSERT INTO donors(bloodgroup,contact,userid) VALUES
('O+', '0300-1234567', 1017),
('A+', '0334-2345678', 1018),
('AB+', '0300-1234567', 1019),
('AB-', '0300-0987654', 1020),
('B-', '0300-1234567', 1021),
('O+', '0300-0987654', 1022),
('B-', '0300-0234567', 1023),
('AB-', '0300-0987654', 1024),
('B+', '0300-0987654', 1025),
('B-', '0300-0987654', 1026),
('O+', '0300-1234567', 1027),
('A+', '0334-2345678', 1028),
('AB+', '0300-1234567', 1029),
('AB-', '0300-0987654', 1030),
('B-', '0300-1234567', 1031),
('O+', '0300-0987654', 1032),
('B-', '0300-0234567', 1033),
('AB-', '0300-0987654', 1034),
('B+', '0300-0987654', 1035),
('B-', '0300-0987654', 1036);


INSERT INTO blooddonations(donorid, donationdate, expirydate, currstatus, quantity, medicalnotes)
VALUES
(10, '2024-03-01', '2024-04-01', 'used', 10.50, 'Medical notes 1'),
(16, '2024-03-02', '2024-04-02', 'unused', 12.30, 'Medical notes 2'),
(18, '2024-03-03', '2024-04-03', 'expired', 8.70, 'Medical notes 3'),
(20, '2024-03-04', '2024-04-04', 'used', 9.20, 'Medical notes 4'),
(1011, '2024-03-05', '2024-04-05', 'unused', 11.80, 'Medical notes 5'),
(1011, '2024-03-06', '2024-04-06', 'expired', 7.60, 'Medical notes 6'),
(1011, '2024-03-07', '2024-04-07', 'used', 13.40, 'Medical notes 7'),
(10, '2024-03-08', '2024-04-08', 'unused', 6.90, 'Medical notes 8'),
(20, '2024-03-09', '2024-04-09', 'expired', 10.10, 'Medical notes 9'),
(4, '2024-03-10', '2024-04-10', 'used', 8.30, 'Medical notes 10'),
-- Insert 40 more rows with unique data
(1012, '2024-03-11', '2024-04-11', 'unused', 11.20, 'Medical notes 11'),
(1013, '2024-03-12', '2024-04-12', 'expired', 9.50, 'Medical notes 12'),
(1014, '2024-03-13', '2024-04-13', 'used', 12.60, 'Medical notes 13'),
(10, '2024-03-14', '2024-04-14', 'unused', 8.80, 'Medical notes 14'),
(10, '2024-03-15', '2024-04-15', 'expired', 7.40, 'Medical notes 15'),
(4, '2024-03-16', '2024-04-16', 'used', 10.90, 'Medical notes 16'),
(16, '2024-03-17', '2024-04-17', 'unused', 11.70, 'Medical notes 17'),
(18, '2024-03-18', '2024-04-18', 'expired', 9.80, 'Medical notes 18'),
(20, '2024-03-19', '2024-04-19', 'used', 7.90, 'Medical notes 19'),
(4, '2024-03-20', '2024-04-20', 'unused', 12.10, 'Medical notes 20'),
(1015, '2024-03-21', '2024-04-21', 'used', 11.50, 'Medical notes 21'),
(1016, '2024-03-22', '2024-04-22', 'unused', 13.30, 'Medical notes 22'),
(1017, '2024-03-23', '2024-04-23', 'expired', 14.70, 'Medical notes 23'),
(1018, '2024-03-24', '2024-04-24', 'used', 9.60, 'Medical notes 24'),
(1019, '2024-03-25', '2024-04-25', 'unused', 8.20, 'Medical notes 25'),
(1020, '2024-03-26', '2024-04-26', 'expired', 10.90, 'Medical notes 26'),
(1021, '2024-03-27', '2024-04-27', 'used', 12.30, 'Medical notes 27'),
(1022, '2024-03-28', '2024-04-28', 'unused', 11.20, 'Medical notes 28'),
(1023, '2024-03-29', '2024-04-29', 'expired', 8.90, 'Medical notes 29'),
(1024, '2024-03-30', '2024-04-30', 'used', 7.70, 'Medical notes 30'),
(1025, '2024-03-31', '2024-05-01', 'unused', 12.50, 'Medical notes 31'),
(1026, '2024-04-01', '2024-05-02', 'expired', 9.80, 'Medical notes 32'),
(1027, '2024-04-02', '2024-05-03', 'used', 11.30, 'Medical notes 33'),
(1028, '2024-04-03', '2024-05-04', 'unused', 13.20, 'Medical notes 34'),
(1029, '2024-04-04', '2024-05-05', 'expired', 14.60, 'Medical notes 35'),
(1030, '2024-04-05', '2024-05-06', 'used', 8.70, 'Medical notes 36'),
(1031, '2024-04-06', '2024-05-07', 'unused', 12.40, 'Medical notes 37'),
(1032, '2024-04-07', '2024-05-08', 'expired', 11.10, 'Medical notes 38')


-- Create the table
CREATE TABLE HospitalRequests (
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    HospitalName VARCHAR(100),
    City VARCHAR(50),
    BloodType VARCHAR(5),
    QuantityNeeded INT,
    Status VARCHAR(20)
);

-- Insert rows into the table
INSERT INTO HospitalRequests (HospitalName, City, BloodType, QuantityNeeded, Status)
VALUES
('Shaukat Khanum Hospital', 'Lahore', 'O+', 10, 'Pending'),
('Aga Khan University Hospital', 'Karachi', 'A-', 8, 'Urgent'),
('Jinnah Hospital', 'Lahore', 'B+', 15, 'Pending'),
('Indus Hospital', 'Karachi', 'O-', 12, 'Urgent'),
('Liaquat National Hospital', 'Karachi', 'AB+', 20, 'Urgent');

--delete from recipients
select * from recipients
select * from donors

INSERT INTO recipients (bloodtype, medicalhistory, userid) VALUES
('O+', 'History 1', 4),
('O-', 'History 2', 1005),
('AB+', 'History 3', 2),
('AB-', 'History 4', 1004),
('B-', 'History 5', 3),
('O+', 'History 6', 1002),
('B-', 'History 7', 1003),
('AB-', 'History 8', 1006),
('B+', 'History 9', 1007),
('B-', 'History 10', 1008),
('O+', 'History 11', 1017),
('A+', 'History 12', 1018),
('AB+', 'History 13', 1019),
('AB-', 'History 14', 1020),
('B-', 'History 15', 1021),
('O+', 'History 16', 1022),
('A-', 'History 17', 1023),
('AB-', 'History 18', 1024),
('B+', 'History 19', 1025),
('B-', 'History 20', 1026),
('O+', 'History 21', 1027),
('A+', 'History 22', 1028),
('AB+', 'History 23', 1029),
('AB-', 'History 24', 1030),
('A-', 'History 25', 1031),
('O+', 'History 26', 1032),
('B-', 'History 27', 1033),
('AB-', 'History 28', 1034),
('B+', 'History 29', 1035),
('B-', 'History 30', 1036),
('O+', 'History 31', 1037),
('A-', 'History 32', 1038),
('O+', 'History 33', 1039);

ALTER TABLE users
ADD age int;

UPDATE users
SET age = ABS(CHECKSUM(NEWID())) % (80 - 18 + 1) + 18
WHERE age IS NULL;



select * from bloodtransfusions


INSERT INTO blooddonations(donorid, donationdate, expirydate, currstatus, quantity, medicalnotes)
VALUES
(10, '2024-05-01', '2024-05-01', 'used', 10.50, 'Medical notes 1'),
(16, '2024-05-02', '2024-05-02', 'unused', 12.30, 'Medical notes 2'),
(18, '2024-05-03', '2024-05-03', 'expired', 8.70, 'Medical notes 3'),
(20, '2024-05-04', '2024-05-04', 'used', 9.20, 'Medical notes 4'),
(1011, '2024-05-05', '2024-05-05', 'unused', 11.80, 'Medical notes 5'),
(1011, '2024-05-06', '2024-05-06', 'expired', 7.60, 'Medical notes 6'),
(1011, '2024-05-07', '2024-05-07', 'used', 13.40, 'Medical notes 7'),
-- Insert 40 more rows with unique data
(1012, '2024-05-08', '2024-05-08', 'unused', 11.20, 'Medical notes 11'),
(1013, '2024-05-09', '2024-05-09', 'expired', 9.50, 'Medical notes 12'),
(1014, '2024-05-10', '2024-05-10', 'used', 12.60, 'Medical notes 13'),
(10, '2024-04-11', '2024-05-11', 'unused', 8.80, 'Medical notes 14'),
(10, '2024-04-12', '2024-05-12', 'expired', 7.40, 'Medical notes 15'),
(4, '2024-04-13', '2024-05-13', 'used', 10.90, 'Medical notes 16'),
(16, '2024-04-14', '2024-05-14', 'unused', 11.70, 'Medical notes 17'),
(18, '2024-04-15', '2024-05-15', 'expired', 9.80, 'Medical notes 18'),
(20, '2024-04-16', '2024-05-16', 'used', 7.90, 'Medical notes 19'),
(4, '2024-04-17', '2024-05-17', 'unused', 12.10, 'Medical notes 20'),
(1015, '2024-04-18', '2024-05-18', 'used', 11.50, 'Medical notes 21'),
(1016, '2024-04-19', '2024-05-19', 'unused', 13.30, 'Medical notes 22'),
(1017, '2024-04-20', '2024-05-20', 'expired', 14.70, 'Medical notes 23'),
(1018, '2024-04-21', '2024-05-21', 'used', 9.60, 'Medical notes 24'),
(1019, '2024-04-22', '2024-05-22', 'unused', 8.20, 'Medical notes 25'),
(1020, '2024-04-23', '2024-05-23', 'expired', 10.90, 'Medical notes 26'),
(1021, '2024-04-24', '2024-05-24', 'used', 12.30, 'Medical notes 27'),
(1022, '2024-04-25', '2024-05-25', 'unused', 11.20, 'Medical notes 28'),
(1023, '2024-04-26', '2024-05-26', 'expired', 8.90, 'Medical notes 29'),
(1024, '2024-04-27', '2024-05-27', 'used', 7.70, 'Medical notes 30'),
(1025, '2024-04-28', '2024-05-28', 'unused', 12.50, 'Medical notes 31'),
(1026, '2024-04-29', '2024-05-29', 'expired', 9.80, 'Medical notes 32'),
(1027, '2024-04-30', '2024-05-30', 'used', 11.30, 'Medical notes 33'),
(1028, '2024-05-01', '2024-05-31', 'unused', 13.20, 'Medical notes 34'),
(1029, '2024-05-02', '2024-06-01', 'expired', 14.60, 'Medical notes 35'),
(1030, '2024-05-03', '2024-06-02', 'used', 8.70, 'Medical notes 36'),
(1031, '2024-05-04', '2024-06-03', 'unused', 12.40, 'Medical notes 37'),
(1032, '2024-05-05', '2024-06-04', 'expired', 11.10, 'Medical notes 38');
