CREATE TABLE bloodtransfusions (
    transfusionid INT IDENTITY(1,1) PRIMARY KEY,
    donationid INT NOT NULL,
    recipientid int NOT NULL,
	bloodtype VARCHAR(3) CHECK (BloodType IN ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-')) NOT NULL,
	quantity DECIMAL(5,2) NOT NULL,
    purpose TEXT NOT NULL,
	tranfusiondate datetime not null,
    FOREIGN KEY (donationid) REFERENCES blooddonations(donationid),
	FOREIGN KEY (recipientid) REFERENCES recipients(recipientid)
);

-- Table for storing appointment scheduling information
CREATE TABLE appointments (
    appointmentid INT IDENTITY(1,1) PRIMARY KEY,
    donorid INT NOT NULL,
    appointmentdate DATETIME NOT NULL,
    confirmationstatus VARCHAR(20) CHECK (confirmationstatus IN ('pending', 'confirmed', 'cancelled')) NOT NULL,
    FOREIGN KEY (donorid) REFERENCES donors(donorid)
);



CREATE TABLE recipients (
recipientID INT IDENTITY(1,1) PRIMARY KEY,
 userid INT NOT NULL,
 bloodtype VARCHAR(3) CHECK (BloodType IN ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-')) NOT NULL,
 medicalhistory TEXT,
 FOREIGN KEY (userid) REFERENCES users(userid)

);

select * from donors

-- Insert 20 rows into the appointments table
INSERT INTO appointments (donorid, appointmentdate, confirmationstatus)
VALUES
    (10, '2024-03-25 10:00:00', 'confirmed'),
    (20, '2024-03-26 11:30:00', 'confirmed'),
    (1013, '2024-03-27 13:00:00', 'pending'),
    (4, '2024-03-28 14:30:00', 'confirmed'),
    (1011, '2024-03-29 16:00:00', 'cancelled'),
    (1012, '2024-03-30 09:00:00', 'confirmed'),
    (16, '2024-04-01 10:30:00', 'confirmed'),
    (18, '2024-04-02 12:00:00', 'confirmed'),
    (20, '2024-04-03 13:30:00', 'cancelled'),
    (10, '2024-04-04 15:00:00', 'confirmed'),
    (1011, '2024-04-05 16:30:00', 'pending'),
    (1012, '2024-04-06 09:30:00', 'confirmed'),
    (1013, '2024-04-07 11:00:00', 'confirmed'),
    (1014, '2024-04-08 12:30:00', 'confirmed'),
    (1015, '2024-04-09 14:00:00', 'confirmed'),
    (16, '2024-04-10 15:30:00', 'cancelled'),
    (10, '2024-04-11 16:00:00', 'confirmed'),
    (18, '2024-04-12 09:30:00', 'confirmed'),
    (4, '2024-04-13 11:00:00', 'pending'),
    (20, '2024-04-14 12:30:00', 'confirmed');
