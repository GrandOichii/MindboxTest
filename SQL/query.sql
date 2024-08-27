SELECT Products.Name as Product, ISNULL(Categories.Name, '') as Category
FROM ProductCategories
RIGHT JOIN Products
ON ProductCategories.ProdKey = Products.ProdKey
LEFT JOIN Categories
ON ProductCategories.CatKey = Categories.CatKey;