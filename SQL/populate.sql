DELETE FROM ProductCategories;
DELETE FROM Products;
DELETE FROM Categories;

-- Categories
INSERT INTO Categories([CatKey], [Name]) VALUES ('category1', 'Category 1');
INSERT INTO Categories([CatKey], [Name]) VALUES ('category2', 'Category 2');
INSERT INTO Categories([CatKey], [Name]) VALUES ('category3', 'Category 3');
INSERT INTO Categories([CatKey], [Name]) VALUES ('category4', 'Category 4');

-- Products
INSERT INTO Products([ProdKey], [Name]) VALUES('prod1', 'Product 1');
INSERT INTO Products([ProdKey], [Name]) VALUES('prod2', 'Product 2');
INSERT INTO Products([ProdKey], [Name]) VALUES('prod3', 'Product 3');
INSERT INTO Products([ProdKey], [Name]) VALUES('prod4', 'Product 4');

-- Product N:M Category
INSERT INTO ProductCategories([ProdKey], [CatKey]) VALUES('prod1', 'category1');
INSERT INTO ProductCategories([ProdKey], [CatKey]) VALUES('prod1', 'category2');
INSERT INTO ProductCategories([ProdKey], [CatKey]) VALUES('prod2', 'category1');
INSERT INTO ProductCategories([ProdKey], [CatKey]) VALUES('prod2', 'category2');
INSERT INTO ProductCategories([ProdKey], [CatKey]) VALUES('prod2', 'category3');
INSERT INTO ProductCategories([ProdKey], [CatKey]) VALUES('prod3', 'category2');