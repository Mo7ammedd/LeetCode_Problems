/*
Table: Users
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| user_id     | int     |
| user_name   | varchar |
+-------------+---------+
user_id is the primary key for this table.
Each row of this table contains the name and the id of a user.

Table: Register
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| contest_id  | int     |
| user_id     | int     |
+-------------+---------+
(contest_id, user_id) is the primary key for this table.
Each row of this table contains the id of a user and the contest they registered into.
 
Write an SQL query to find the percentage of the users registered in each contest rounded to two decimals.
Return the result table ordered by percentage in descending order. In case of a tie, order it by contest_id in ascending order.
*/

Declare @cnt int = (SELECT COUNT(*) total_users FROM Users)

SELECT contest_id,
       ROUND(COUNT(user_id) * 1.0/ @cnt * 100, 2) percentage
FROM Register
GROUP BY contest_id
ORDER BY percentage desc, contest_id
