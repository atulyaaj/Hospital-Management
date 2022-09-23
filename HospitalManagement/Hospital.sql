create database HospitalManagement

use HospitalManagement

create table admin(
AdminId int primary key,
AdminName varchar(100),
AdminEmail varchar(50),
AdminPassword varchar(50));

create table doctor(
DoctorId int primary key,
DoctorName varchar(50),
DoctorSpecialization varchar(50),
DoctorEmail varchar(50),
DoctorPassword varchar(50));

create table patient(
PatientId int primary key,
PatientName varchar(50),
PatientDob varchar(50),
PatientAge numeric(5),
PatientSex varchar(10),
PatientMobile varchar(10),
PatientEmail varchar(50),
PatientPassword varchar(50));

create table appointment(
AppointmentId int primary key,
AppointedRoom varchar(50),
AppointmentDate varchar(50),
PatientId int foreign key references patient(PatientId));


create table prescription(
MedicineId int primary key,
MedicineName varchar(100),
MedicineCost numeric(20),
PatientId int foreign key references patient(PatientId));


select a.appointedroom, a.appointmentdate from appointment a,patient p where p.patientid=a.patientid
and a.patientid=1


select pr.medicineid,pr.medicinename,pr.medicinecost from prescription pr,patient p
where p.patientid=pr.patientid
and pr.patientid=1

select * from prescription

insert into prescription values(10001,'Alensol D',250,1);

select * from patient
select * from appointment where patientid=1
select * from prescription