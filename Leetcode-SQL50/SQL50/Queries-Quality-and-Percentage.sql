/*
Table: Queries
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| query_name  | varchar |
| result      | varchar |
| position    | int     |
| rating      | int     |
+-------------+---------+
There is no primary key for this table, it may have duplicate rows.
This table contains information collected from some queries on a database.
The position column has a value from 1 to 500.
The rating column has a value from 1 to 5. Query with rating less than 3 is a poor query.
 
We define query quality as:
The average of the ratio between query rating and its position.

We also define poor query percentage as:
The percentage of all queries with rating less than 3.

Write an SQL query to find each query_name, the quality and poor_query_percentage.
Both quality and poor_query_percentage should be rounded to 2 decimal places.
Return the result table in any order.
*/

SELECT query_name, 
   ROUND(avg(rating * 1.0 / position), 2) quality, 
   ROUND( 100 * 1.0 * SUM(case when rating < 3 then 1 else 0 end) / COUNT(query_name), 2) as poor_query_percentage
FROM Queries
GROUP BY query_name
