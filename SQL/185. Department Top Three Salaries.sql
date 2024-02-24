SELECT d.Name AS Department,e.Name AS Employee,Salary
FROM Employee e 
LEFT JOIN Department d
ON e.DepartmentId = d.Id
WHERE
(SELECT COUNT(DISTINCT Salary) FROM Employee t1
WHERE t1.DepartmentId = d.Id AND t1.Salary >= e.Salary) <= 3
AND d.Name IS NOT NULL
ORDER BY d.Id DESC;