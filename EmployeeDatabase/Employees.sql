use [EmployeeDetails]
CREATE TABLE Employees
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
INSERT INTO Employees VALUES ('Rajesh Sharma','Rajesh.sharma','rajesh9854','Male','Pune','Rajesh.sharma@gmail.com','Software Developer','2')
INSERT INTO Employees VALUES ('Meena Pawar','Meena.pawar','Meena12378','Female','Mumbai','Meena.pawar@gmail.com','Software Tester ','2')
INSERT INTO Employees VALUES ('Sakshi Patil','sakshi.patil','sakshi12577','Female','Banglore','sakshi.patil@gmail.com','Project Manager','5')
INSERT INTO Employees VALUES ('Ramesh Pathak','ramesh.pathak','ramesh3467','Male','Mumbai','ramesh.pathak@gmail.com','Software Developer','3')
INSERT INTO Employees VALUES ('Bhumika Rane','bhumika.rane','bhumika3746','Female','Pune','bhumika.rane@gmail.com','Automation Engineer','3')
INSERT INTO Employees VALUES ('Rakesh Mane','rakesh.mane','rakesh.mane','Male','Haiderabad','rakesh.mane@gmail.com','Graduate Trainee','1')
INSERT INTO Employees VALUES ('Durga Thakur','durga.thakur','durga7454','Female','Kolkata','durga.thakur@gmail.com','Software Developer','4')
INSERT INTO Employees VALUES ('Shweta Shinde','shweta.shinde','shweta34634','Female','Mumbai','shweta.shinde@gmail.com','Software Tester','3')
INSERT INTO Employees VALUES ('Vishal Deore','vishal.Deore','vishal45468','Male','Nashik','vishal.Deore@gmail.com','Automation Engineer','4')
INSERT INTO Employees VALUES ('Rugved Riaz','rugved.riaz','rugved454656','Male','Mumbai','rugved.riaz@gmail.com','Project Manager','6')
select * from Employees