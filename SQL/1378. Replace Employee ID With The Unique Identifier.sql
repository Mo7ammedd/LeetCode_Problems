SELECT EUNI.unique_id, E.name
FROM Employees E
left JOIN EmployeeUNI EUNI ON E.id = EUNI.id;
