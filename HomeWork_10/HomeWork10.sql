-- Students

-- 1
select * from Students where DoB > '1990-12-31';
-- 2
select Firstname, Lastname, (YEAR (GETDATE())- YEAR(Dob)) as Age from Students 
where Country In('Georgia', 'Libya');
-- 3
insert into Students (Lastname, Firstname, Dob, Email, Quiz1, Quiz2, MiddleTest, FinalTest, Country)
values ('Deacon', 'Crosby', '1997-05-06', 'MyMail@MyMail.com', 2, 4, 24, null, 'Georgia');
-- 4 
select TOP 5 with TIES Middletest, Firstname, Lastname from Students order by
MiddleTest ASC;
-- 5
delete from Students 
    where FinalTest = 19 
	select * from Students output;
-- 6
update Students set FinalTest = 0 where MiddleTest = 1
select * from Students output;

-- Persons
--
Select * from Persons;
--
select Lastname, Country from Persons;
-- 1
select * from Persons where PrivateId like ('163%');
-- 2
select * from Persons where Lastname = City;
-- 3
select * from Persons where Country in('Canada', 'Monaco');
-- 4
select Firstname, Lastname, PrivateId from Persons 
where Email is null
-- 5
select * from Persons where Country in ('Turkey', 'Spain') and
Salary between 1000 and 3000;
-- 6
select WorkPlace from Persons where WorkPlace like ('%llc%') or
WorkPlace like ('%pc%') or WorkPlace like ('%llp%')
-- 7 ვერ გავაკეთე
select Email as Onedot from Persons where Email  like ('%.%')

-- მოკლედ, უნდა ავიღოთ მეილიე len, შემდეგ ავიღოთ ისევ მეილი და  replace გავუკეთოთ '.' - '' -ზე და ამის len()-ც
-- მივიღოთ ამ სიგრძეების სხვაობა და გავიგებთ, რამდენი წერტილია მეილში.
-- უნდა გამოვქაცხადოთ (declare)- სავარაუდოდ, თავშივე, ახალი კოლონა და ამ კოლონაში
-- შევიტანოთ თუ ორი წერტილია, შესაბამისი ტექსტი და თუ ერთი, მაშნ ერთის შესაბამისი ტექსტი.
-- :)

-- 8
select * from Persons where PINcode like ('%51')
-- 9
select Country, AVG(Salary) FROM Persons as AVG group by Country
order by Country



