/*
Table: Weather
+---------------+---------+
| Column Name   | Type    |
+---------------+---------+
| id            | int     |
| recordDate    | date    |
| temperature   | int     |
+---------------+---------+
id is the primary key for this table.
This table contains information about the temperature on a certain day.

Write an SQL query to find all dates' Id with higher temperatures compared to its previous dates (yesterday).
Return the result table in any order.
*/

SELECT w.id
FROM Weather w, Weather pw
Where w.temperature > pw.temperature and 
      pw.recordDate = DATEADD(day, -1, w.recordDate)
