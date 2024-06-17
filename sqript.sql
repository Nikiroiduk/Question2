SELECT Products.Name AS 'Имя продукта', Categories.Name AS 'Имя категории'
FROM Products
LEFT JOIN ProductsCategories ON Products.ID = ProductsCategories.ProductID
LEFT JOIN Categories ON ProductsCategories.CategoryID = Categories.ID;