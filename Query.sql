CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name TEXT
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name TEXT
);

CREATE TABLE ProductsCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
);

INSERT INTO Products
VALUES
	(1, 'Synology RX1217'),
	(2, 'AMD Ryzen 5 5600X'),
	(3, 'SAMSUNG 980 SSD 1TB M.2'),
	(4, 'Epson Expression Home XP-4100'),
	(5, 'SAMSUNG 34-Inch SJ55W'),
	(6, 'Galaxy S Pen'),
	(7, 'TP-Link AC1750 Smart WiFi Router');



INSERT INTO Categories
VALUES
	(1, 'Computer Components'),
	(2, 'Data Storage'),
	(3, 'Printers'),
	(4, 'Scanners'),
	(5, 'Monitors'),
	(6, 'Servers');


INSERT INTO ProductsCategories
VALUES
	(1, 6),
	(2, 1),
	(3, 1),
	(3, 2),
	(4, 3),
	(5, 5);

SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductsCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;