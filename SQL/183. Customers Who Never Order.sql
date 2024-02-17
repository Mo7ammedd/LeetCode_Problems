SELECT s.name AS Customers 
FROM Customers s
LEFT OUTER JOIN Orders o ON o.customerId = s.id
WHERE o.id IS NULL;