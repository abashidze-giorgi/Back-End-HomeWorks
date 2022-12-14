
-- WorldEvents

-- 1 გამოიტანეთ ევროპაში გამართულ მოვლენების რაოდენობა;

select * from Event
select * from [dbo].[Continent]

select count([EventName]) from [dbo].[Event]
join [dbo].[Country] on [dbo].[Event].CountryID = [dbo].[Country].[CountryID]
join [dbo].[Continent] on [dbo].[Country].[ContinentID] = [dbo].[Continent].[ContinentID]
where [dbo].[Continent].[ContinentName] = 'Europe'

-- 2 გამოიტანეთ აფრიკაში ყველაზე ადრე გამართული მოვლენის თარიღი;

select min( [dbo].[Event].[EventDate]) from [dbo].[Event]
join [dbo].[Country] on [dbo].[Event].CountryID = [dbo].[Country].[CountryID]
join [dbo].[Continent] on [dbo].[Country].[ContinentID] = [dbo].[Continent].[ContinentID]
where [dbo].[Continent].[ContinentName] = 'Africa'

-- 3 გამოიტანეთ ჩრდილოეთ და სამხრეთ ამერიკაში არსებული ქვეყნების რაოდენობა;

select count([dbo].[Country].CountryName) from [dbo].[Country]
join [dbo].[Continent] on [dbo].[Country].ContinentID = [dbo].[Continent].ContinentID
where [dbo].[Continent].ContinentName in ('South America', 'North America')

-- 4 გამოიტანეთ ახალ წელს გამართული ეკონომიკასთან დაკავშირებული მოვლენების რაოდენობა;
select * from [dbo].[Category]
select * from [dbo].[Event]
select * from [dbo].[Continent]

select count([dbo].[Event].EventName) from [dbo].[Event]
join [dbo].[Category] on [dbo].[Event].[CategoryID] = [dbo].[Category].[CategoryID]
where day([dbo].[Event].EventDate) = 31 and MONTH([dbo].[Event].EventDate) = 12 or
day([dbo].[Event].EventDate) = 1 and MONTH([dbo].[Event].EventDate) = 1

-- 5 გამოიტანეთ ევროპაში ყველაზე გვიან გამართული, სპორტის კატეგორიასთან დაკავშირებული მოვლენის თარიღი.
select max([dbo].[Event].[EventDate]) from [dbo].[Event]
join [dbo].[Country] on [dbo].[Event].CountryID = [dbo].[Country].CountryID
join [dbo].[Category] on [dbo].[Event].CategoryID = [dbo].[Category].CategoryID
join [dbo].[Continent] on [dbo].[Country].ContinentID = [dbo].[Continent].ContinentID
where [dbo].[Continent].ContinentName = 'Europe' and
[dbo].[Category].CategoryName = 'Sports'