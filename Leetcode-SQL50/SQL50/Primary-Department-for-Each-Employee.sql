/*
Table: Employee
+---------------+---------+
| Column Name   |  Type   |
+---------------+---------+
| employee_id   | int     |
| department_id | int     |
| primary_flag  | varchar |
+---------------+---------+
(employee_id, department_id) is the primary key for this table.
employee_id is the id of the employee.
department_id is the id of the department to which the employee belongs.
primary_flag is an ENUM of type ('Y', 'N'). If the flag is 'Y', the department is the primary department for the employee. 
If the flag is 'N', the department is not the primary.

Employees can belong to multiple departments. When the employee joins other departments, they need to decide which department is their primary department. 
Note that when an employee belongs to only one department, their primary column is 'N'.

Write an SQL query to report all the employees with their primary department. For employees who belong to one department, report their only department.
Return the result table in any order.
*/

WITH CTE AS (
    SELECT employee_id
    FROM Employee
    GROUP BY employee_id
    HAVING COUNT(primary_flag) = 1
)

SELECT employee_id, department_id
FROM Employee
WHERE employee_id in (
    SELECT *
    FROM CTE
) OR primary_flag = 'Y'
