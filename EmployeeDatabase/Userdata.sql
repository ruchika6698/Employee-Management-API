CREATE TABLE Userdata
(
  ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  EmployeeName varchar(50),
  Username varchar(50),
  Password varchar(50),
  Gender varchar(50),
  City varchar(50),
  EmailID varchar(50),
  Designation varchar(50),
  WorkingExperience varchar(50),
);
INSERT INTO Userdata VALUES ('Rajesh Sharma','Rajesh.sharma','rajesh9854','Male','Pune','Rajesh.sharma@gmail.com','Software Developer','2')
INSERT INTO Userdata VALUES ('Meena Pawar','Meena.pawar','Meena12378','Female','Mumbai','Meena.pawar@gmail.com','Software Tester ','2')
select * from Userdata