--use TSQL2012

select * from Production.Categories
select * from Production.Products
select * from Production.Suppliers
select * from HR.Employees
select * from Sales.Orders
select * from Sales.Customers
select * from Sales.OrderDetails
select * from Sales.Shippers



-- TSQL2012 
-- JOIN

--1
/*
გამოიტანეთ ლონდონელი და მადრიდელი კლიენტების გვარი, სახელი, ქალაქი და შეკვეთების თარიღები; 
*/
select contactname, city, Sales.Orders.orderdate		--, orderid as OrderId
from Sales.Customers
inner join Sales.Orders on Sales.Orders.custid = Sales.Orders.custid  where 
city in ('Madrid', 'London') 

-- 2
/*
გამოიტანეთ იმ პროდუქტების სახელწოდება ზედა რეგისტრში, ფასი და კატეგორია, რომელთა ფასი 20-დან 40-მდეა; 
*/
select UPPER(Products.productname), unitprice,  categoryname
from Production.Products
inner join Production.Categories on Products.categoryid = Categories.categoryid where
unitprice between 20 and 40

--3
/*
გამოიტანეთ გაყიდვების მენეჯერების გვარი, სახელი და შეკვეთების იდენტიფიკატორი (orderid), რომელსაც Sales Manager მოემსახურნენ. გამოიტანეთ მხოლოდ 50 -ზე მეტი წონის შეკვეთები; 
*/
select * from HR.Employees
select * from Sales.Orders

select lastname, firstname, orderid, freight as FREIGHT
from HR.Employees 
inner join  Sales.Orders on HR.Employees.empid = Orders.empid
where  freight > 50 and title = 'Sales Manager'

--4
/*
გამოიტანეთ შეკვეთის თარიღი, კლიენტის გვარი, სახელი, ქალაქი და მისამართი იმ შეკვეთებისათვის, რომლებიც გაკეთდა 2007 წელს ამერიკული კომპანიის მიერ; 
*/
select * from Sales.Orders

select orderdate, Sales.Customers.contactname, Customers.city, Customers.address
from Sales.Orders
inner join Sales.Customers on Orders.custid = Customers.custid 
where  YEAR( orderdate) = 2007 and shipcountry = 'USA'


-- 5
/*
გამოიტანეთ იმ ქალაქების სახელები, სადაც მოხდა კომპანიის თანამშრომელ Cameron -ის 
მიღებული შეკვეთების ტრანსპორტირება. მიღებულ ვირტუალურ ცხრილში ქალაქების სახელები არ განმეორდეს;
*/
select * from HR.Employees
select * from Sales.Orders

select shipcity
from Sales.Orders 
inner join HR.Employees on Orders.empid = Employees.empid 
where Employees.lastname = 'Cameron'  group by shipcity order by shipcity

--6
/*
გამოიტანეთ გადამზიდავი კომპანიების მიერ გერმანიაში და ავსტრიაში ტრანსპორტირებული შეკვეთების id (orderid), ასევე ქვეყანა და ქალაქი, სადაც მოხდა შეკვეთის ტრანსპორტირება; 
*/
select * from Sales.Orders

select orderid, shipcountry, shipcity from Sales.Orders 
where shipcountry in ('Germany', 'Austria')


--7
/*
გამოიტანეთ სრული მონაცემები ტოკიოდან (Tokyo) მოწოდებული იმ პროდუქტების შესახებ, რომლებზეც მოქმედებს ფასდაკლება; 
*/
select * from Production.Products
inner join Production.Suppliers on Products.supplierid = Suppliers.supplierid
where city = 'Tokyo'

--8
/*
გამოიტანეთ იაპონიიდან მოწოდებული ზღვის პროდუქტების და სასმელების დასახელებები კატეგორიის სახელწოდებებთან ერთად; 
*/
select * from Production.Categories

select Production.Products.productname, categoryname
from Production.Products
inner join Production.Categories on Products.categoryid = Categories.categoryid
where Categories.categoryid = 1 or Categories.categoryid = 8 

--9
/*
გამოიტანეთ კომპანიის თანამშრომლების სახელი და გვარი და გადამზიდავი კომპანიების სახელწოდებები, 
რომლებმაც 2007 წელს გადაზიდეს შეკვეთები, რომლებსაც მოემსახურნენ სარა დევისი (Sara Davis) და მარია ქემერონი (Maria Cameron); 
*/
select * from hr.Employees
select * from Sales.Orders


select Employees.firstname as FullName, HR.Employees.lastname, Sales.Shippers.companyname
from hr.Employees
inner join Sales.Orders on Sales.Orders.shipperid = shipperid
join Sales.Shippers on orders.shipperid = Shippers.shipperid 
where Employees.firstname in ('Sara','Maria') and lastname in ('Davis', 'Cameron') and
YEAR(orders.orderdate) = 2007         -- group by HR.Employees.firstname, lastname  -- ეს არ გამოდის


--10
/*
გამოიტანეთ ამერიკელი მწარმოებლების მიერ წარმოებული იმ პროდუქტების 
სახელწოდებები და კატეგორიები, რომლებიც არ მიეკუთვნება ზღვის პროდუქტების და წვენების კატეგორიას; 
*/
select * from Production.Categories

select Production.Products.productname, Production.Categories.categoryname
from Production.Products
join Production.Categories on Products.categoryid = Categories.categoryid
where Categories.categoryid != 1 and Categories.categoryid != 8


--11
/*
გამოიტანეთ შეკვეთის ნომერი, კომპანიის თანამშრომლის გვარი, სახელი და საცხოვრებელი ქალაქი, 
კლიენტის სახელი და გვარი იმ შეკვეთებისათვის, რომლის კლიენტი და კომპანიის თანამშრომელი ცხოვრობენ ერთ ქალაქში;
*/
select Sales.Orders.orderid, HR.Employees.lastname, HR.Employees.firstname, Hr.Employees.city,
Sales.Customers.contactname
from Sales.Orders
join Sales.Customers on Sales.Orders.custid = Customers.custid
join Hr.Employees on Sales.Orders.empid = Employees.empid
where Employees.city = Customers.city


--12
/*
გამოიტანეთ იმ კლიენტების სახელი და გვარი, რომლებმაც შეუკვეთეს სასმელები (Beverages) 
ან რძის პროდუქტები (Dairy Products). ერთი და იგივე კლიენტის სახელი და გვარი გამოიტანეთ მხოლოდ ერთხელ. 
*/
select * from Sales.Orders
select * from Sales.OrderDetails
select * from [Production].[Categories]

select distinct Sales.Customers.contactname
from Sales.Customers
inner join Sales.Orders on Sales.Customers.custid = Orders.custid
inner join Sales.OrderDetails on Sales.Orders.orderid = OrderDetails.orderid
inner join Production.Products on Sales.OrderDetails.productid = OrderDetails.productid
where Production.Products.categoryid = 1 or Production.Products.categoryid = 4
order by contactname