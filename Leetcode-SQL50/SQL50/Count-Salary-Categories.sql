/*
Table: Accounts
+-------------+------+
| Column Name | Type |
+-------------+------+
| account_id  | int  |
| income      | int  |
+-------------+------+
account_id is the primary key for this table.
Each row contains information about the monthly income for one bank account.
 
Write an SQL query to report the number of bank accounts of each salary category. The salary categories are:

"Low Salary": All the salaries strictly less than $20000.
"Average Salary": All the salaries in the inclusive range [$20000, $50000].
"High Salary": All the salaries strictly greater than $50000.
The result table must contain all three categories. If there are no accounts in a category, then report 0.

Return the result table in any order.
*/

SELECT
    'Low Salary' [Category],
    ISNULL(COUNT(IIF(income < 20000,account_id,NULL)),0) [accounts_count]
FROM
    Accounts
UNION ALL
SELECT
    'Average Salary' [Category],
    ISNULL(COUNT(IIF(income BETWEEN  20000 AND 50000,account_id,NULL)),0) [accounts_count]
FROM
    Accounts
UNION ALL
SELECT
    'High Salary' [Category],
    ISNULL(COUNT(IIF(income > 50000,account_id,NULL)),0) [accounts_count]
FROM
    Accounts
