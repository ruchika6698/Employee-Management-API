use [EmployeeDetails]
CREATE TABLE AddEmployee
(
  ID INT NOT NULL PRIMARY KEY,
  EmployeeName varchar(50),
  Username varchar(50),
  Password varchar(50),
  Gender varchar(50),
  City varchar(50),
  EmailID varchar(50),
  Designation varchar(50),
  WorkingExperience varchar(50),
);
INSERT INTO AddEmployee VALUES ('1','Rasika Pawar','Rasika.Pawar','rasika9854','Female','Pune','Rasika.Pawar@gmail.com','Software Developer','3')
select * from AddEmployee