-- Create Users table
CREATE TABLE Users (
    userid INT PRIMARY KEY,
    username NVARCHAR(50),
    email NVARCHAR(100),
    usertype NVARCHAR(50),
    password NVARCHAR(50)
);
GO
-- Create Donors table
CREATE TABLE Donors (
    donorid INT PRIMARY KEY,
    bloodgroup NVARCHAR(5),
    contact NVARCHAR(20),
    userid INT,
    FOREIGN KEY (userid) REFERENCES Users(userid)
);
GO
-- Insert data into Users table
INSERT INTO Users (userid, username, email, usertype, password)
VALUES
    (2, 'Ali_Riaz1', 'Ali_Riaz1@gmail.com', 'user', 'hello@123'),
    (3, 'Ahmed', 'Ahmed@gmail.com', 'user', '123456'),
    (4, 'sara', 'sara@gmail.com', 'user', 'qwerty'),
    (1002, 'e.g: Ali_Riaz1', 'Ali_Riaz1@gmail.com', 'user', 'hello@123'),
    (1003, 'admin', 'Admin@gmail.com', 'staff', 'hello@123'),
    (1004, 'amna', 'amna@gmail.com', 'user', 'asdfgh'),
    (1005, 'aman', 'hello123@gmail.com', 'user', '123456789'),
    (1006, 'Abd', 'Abd@gmail.com', 'user', 'hello'),
    (1007, 'admin', 'admin@gmail.com', 'user', '123456'),
    (1008, 'john', 'john1@gmail.com', 'user', 'hello@123');
	GO
-- Insert data into Donors table
INSERT INTO Donors (donorid, bloodgroup, contact, userid)
VALUES
    (4, 'O+', '0300-1234567', 4),
    (10, 'A+', '0334-2345678', 1005),
    (16, 'AB+', '0300-1234567', 2),
    (18, 'AB-', '0300-0987654', 1004),
    (20, 'B-', '0300-1234567', 3),
    (1011, 'O+', '0300-0987654', 1002),
    (1012, 'B-', '0300-0234567', 1003),
    (1013, 'AB-', '0300-0987654', 1006),
    (1014, 'B+', '0300-0987654', 1007),
    (1015, 'B-', '0300-0987654', 1008);

	GO






create table blooddonations(
donationid int primary key identity(1,1),
donorid int foreign key references donors(donorid) not null,
donationdate datetime not null,
expirydate datetime not null,
currstatus varchar(15) check (currstatus in('used','unused','expired')),
quantity decimal (5,2) not null,
medicalnotes text
)
GO
--select * from blooddonations
--delete from donors where userid = '1002'
--select * from donors
--select * from users

-- Inserting 20 rows into the blooddonations table
INSERT INTO blooddonations (donorid, donationdate, expirydate, currstatus, quantity, medicalnotes)
VALUES 
    (10, '2024-03-01', '2024-04-01', 'used', 10.5, 'Medical notes 1')
    ,
    (16, '2024-03-02', '2024-04-02', 'unused', 12.3, 'Medical notes 2'),
    (18, '2024-03-03', '2024-04-03', 'expired', 8.7, 'Medical notes 3'),
    (20, '2024-03-04', '2024-04-04', 'used', 9.2, 'Medical notes 4'),
    (1011, '2024-03-05', '2024-04-05', 'unused', 11.8, 'Medical notes 5'),
    (1011, '2024-03-06', '2024-04-06', 'expired', 7.6, 'Medical notes 6'),
    (1011, '2024-03-07', '2024-04-07', 'used', 13.4, 'Medical notes 7')
    ,
    (10, '2024-03-08', '2024-04-08', 'unused', 6.9, 'Medical notes 8'),
    (20, '2024-03-09', '2024-04-09', 'expired', 10.1, 'Medical notes 9'),
    (4, '2024-03-10', '2024-04-10', 'used', 8.3, 'Medical notes 10'),
    (18, '2024-03-11', '2024-04-11', 'unused', 11.2, 'Medical notes 11'),
    (16, '2024-03-12', '2024-04-12', 'expired', 9.5, 'Medical notes 12'),
    (1011, '2024-03-13', '2024-04-13', 'used', 12.6, 'Medical notes 13'),
    (10, '2024-03-14', '2024-04-14', 'unused', 8.8, 'Medical notes 14'),
    (10, '2024-03-15', '2024-04-15', 'expired', 7.4, 'Medical notes 15'),
    (4, '2024-03-16', '2024-04-16', 'used', 10.9, 'Medical notes 16'),
    (16, '2024-03-17', '2024-04-17', 'unused', 11.7, 'Medical notes 17'),
    (18, '2024-03-18', '2024-04-18', 'expired', 9.8, 'Medical notes 18'),
    (20, '2024-03-19', '2024-04-19', 'used', 7.9, 'Medical notes 19'),
    (4, '2024-03-20', '2024-04-20', 'unused', 12.1, 'Medical notes 20');
