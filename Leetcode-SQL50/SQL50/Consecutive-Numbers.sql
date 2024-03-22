/*
Table: Logs
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| id          | int     |
| num         | varchar |
+-------------+---------+
id is the primary key for this table.
id is an autoincrement column.

Write an SQL query to find all numbers that appear at least three times consecutively.
Return the result table in any order.
*/

SELECT DISTINCT l1.num ConsecutiveNums
FROM Logs l1 JOIN Logs l2
ON l1.id = l2.id + 1
JOIN Logs l3
ON l2.id = l3.id + 1
WHERE l1.num = l2.num AND l2.num = l3.num
