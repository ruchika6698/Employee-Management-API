use [EmployeeDetails]
CREATE TABLE EmployeeList
(
  ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  EmployeeName varchar(50),
  Username varchar(50),
  Gender varchar(50),
  City varchar(50),
  EmailID varchar(50),
  Designation varchar(50),
  WorkingExperience varchar(50)
);
INSERT INTO EmployeeList VALUES ('Rajesh Sharma','Rajesh.sharma','Male','Pune','Rajesh.sharma@gmail.com','Software Developer','2')
INSERT INTO EmployeeList VALUES ('Meena Pawar','Meena.pawar','Female','Mumbai','Meena.pawar@gmail.com','Software Tester ','2')
INSERT INTO EmployeeList VALUES ('Sakshi Patil','sakshi.patil','Female','Banglore','sakshi.patil@gmail.com','Project Manager','5')
INSERT INTO EmployeeList VALUES ('Ramesh Pathak','ramesh.pathak','Male','Mumbai','ramesh.pathak@gmail.com','Software Developer','3')
INSERT INTO EmployeeList VALUES ('Bhumika Rane','bhumika.rane','Female','Pune','bhumika.rane@gmail.com','Automation Engineer','3')
INSERT INTO EmployeeList VALUES ('Rakesh Mane','rakesh.mane','Male','Haiderabad','rakesh.mane@gmail.com','Graduate Trainee','1')
INSERT INTO EmployeeList VALUES ('Durga Thakur','durga.thakur','Female','Kolkata','durga.thakur@gmail.com','Software Developer','4')
INSERT INTO EmployeeList VALUES ('Shweta Shinde','shweta.shinde','Female','Mumbai','shweta.shinde@gmail.com','Software Tester','3')
INSERT INTO EmployeeList VALUES ('Vishal Deore','vishal.Deore','Male','Nashik','vishal.Deore@gmail.com','Automation Engineer','4')
INSERT INTO EmployeeList VALUES ('Rugved Riaz','rugved.riaz','Male','Mumbai','rugved.riaz@gmail.com','Project Manager','6')
select * from EmployeeList