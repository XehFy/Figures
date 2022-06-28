SELECT p.Name, c.Name FROM Products AS p
LEFT JOIN Products_Categories AS pc 
ON p.product_id = pc.product
LEFT JOIN Categories AS c
ON pc.category = c.category_id
