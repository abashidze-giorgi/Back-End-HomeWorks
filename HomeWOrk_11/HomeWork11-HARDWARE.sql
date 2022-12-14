use Hardware

-- subquery HARDWARE


-- 1
/*
გამოიტანეთ იმ პროდუქტების სახელწოდება და ღირებულება, რომელთა მწარმოებელი
არის Hewlett-Packard;
*/
select * from dbo.Products
select * from [dbo].[Manufacturers]

select Name, Price from dbo.Products
where ManufacturerId = (
	select ManufacturerId from dbo.Manufacturers where
	Name = 'Hewlett-Packard'
)


--2 
/*
გამოიტანეთ იმ პროდუქტების სახელწოდება და ღირებულება, რომლებიც არ უწარმოებია
Fujitsu -ს;
*/
select * from dbo.Products
select * from [dbo].[Manufacturers]

select Name, Price from dbo.Products

where ManufacturerId != (
	select ManufacturerId from dbo.Manufacturers where
	Name = 'Fujitsu'
)

-- 3
/*
გამოიტანეთ იმ პროდუქტების სახელწოდება და ღირებულება, რომელთა მწარმოებელი
არის Sony, Fujitsu, IBM ან Intel;
*/
select * from dbo.Products
select * from [dbo].[Manufacturers]


select Name, Price from dbo.Products
where ManufacturerId  = (
	select ManufacturerId from dbo.Manufacturers where
	Name = 'Sony'
) or ManufacturerId = (
	select ManufacturerId from dbo.Manufacturers where
	Name = 'Fujitsu'
) or ManufacturerId = (
	select ManufacturerId from dbo.Manufacturers where
	Name = 'IBM'
) or ManufacturerId = (
	select ManufacturerId from dbo.Manufacturers where
	Name = 'Intel'
)

-- 4
/*
გამოიტანეთ იმ კომპანიების სახელწოდებები, რომლებმაც აწარმოეს 200 -ზე უფრო მაღალი
ღირებულების მქონე პროდუქტები;
*/

select distinct [dbo].[Manufacturers].Name
from [dbo].[Manufacturers]
join [dbo].[Products] on dbo.Manufacturers.ManufacturerId = [dbo].[Manufacturers].ManufacturerId
where [dbo].[Products].[Price] > 200 order by [dbo].[Manufacturers].Name asc


-- 5
/*
გამოიტანეთ იმ პროდუქტების სახელწოდება და ღირებულება, რომლებსაც არ აწარმოებს Genius და Dell
*/

select [dbo].[Products].[Name], [dbo].[Products].[Price]
from [dbo].[Products]
inner join [dbo].[Manufacturers] on [dbo].[Products].[ManufacturerId] = [dbo].[Manufacturers].[ManufacturerId]
where [dbo].[Products].[Name] not in ('Dell', 'Genius')
-- 6
/*
გამოიტანეთ იმ მწარმოებელთა რაოდენობა, რომლებიც აწარმოებენ drive -ებს
*/

--select distinct COUNT([dbo].[Manufacturers].[Name])
--from [dbo].[Manufacturers]
--join 

select * from [dbo].[Products]

select COUNT([dbo].[Products].[ManufacturerId]) as 'Count'
from [dbo].[Products] where Name like ('%drive')


-- 7
/*
გამოიტანეთ Intel -ის მიერ წარმოებული იმ პროდუქტების რაოდენობა, რომელთა ფასი აღემატება Intel -ის მიერ წარმოებული პროდუქტების საშუალო ფასს.
*/
select Count([dbo].[Products].[Name])
from [dbo].[Products] 
join [dbo].[Manufacturers] on [dbo].[Products].[ManufacturerId] = [dbo].[Manufacturers].[ManufacturerId]
where [dbo].[Manufacturers].[Name] = 'Intel' and [dbo].[Products].[Price] > (
	select AVG([dbo].[Products].[Price])
	from [dbo].[Products] 
	join [dbo].[Manufacturers] on [dbo].[Products].[ManufacturerId] = [dbo].[Manufacturers].[ManufacturerId]
	where [dbo].[Manufacturers].[Name] = 'Intel'
)

