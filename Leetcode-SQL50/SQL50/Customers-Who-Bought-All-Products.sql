/*
Table: Customer
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| customer_id | int     |
| product_key | int     |
+-------------+---------+
There is no primary key for this table. It may contain duplicates. customer_id is not NULL.
product_key is a foreign key to Product table.
 
Table: Product
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| product_key | int     |
+-------------+---------+
product_key is the primary key column for this table.
 
Write an SQL query to report the customer ids from the Customer table that bought all the products in the Product table.
Return the result table in any order.
*/

SELECT customer_id
FROM Customer
GROUP BY customer_id
Having COUNT(DISTINCT product_key) in (
    SELECT COUNT(DISTINCT product_key)
    FROM Product
)
