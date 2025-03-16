CREATE DATABASE StaffRecord;

USE StaffRecord;

CREATE TABLE Staff(
Staff_ID varchar(50) PRIMARY KEY,
Staff_Name varchar(50),
Salary int,
Department varchar(50)
);

INSERT INTO Staff(Staff_ID, Staff_Name, Salary, Department) VALUES
('S001', 'Aung Tun', 200000, 'Admin'),
('S002', 'Khin Hnin', 140000, 'Admin'),
('S003', 'Kyaw Tint', 300000, 'Admin'),
('S004', 'Wai Min', 190000, 'Admin'),
('S005', 'Su Myat', 310000, 'Admin'),
('S006', 'Khaing Thidar', 250000, 'Admin');