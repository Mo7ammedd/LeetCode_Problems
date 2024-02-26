# Write your MySQL query statement below
SELECT origin.id AS Id 
FROM Weather AS origin LEFT JOIN Weather AS delay 
ON datediff(origin.recordDate, delay.recordDate) = 1 
WHERE origin.temperature > delay.temperature;