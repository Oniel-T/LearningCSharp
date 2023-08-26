--#Stored Procedure vs Function
--SP allows DML but function doesn't
--function returns one value but SP can return multiple values


-- # ROW_NUMBER VS RANK VS DENSE_RANK
--SYNTAX - ROW_NUMBER() OVER(order by salary)
--ROW_NUMBER                                        RANK                                                 DENSE_RANK
--name    salary  row_number                        name    salary  rank                                 name    salary  dense_rank
--Jackob  7000    1					                        Jackob  7000    1			                               Jackob  7000    1
--Peter   5000    2					                        Peter   5000    2			                               Peter   5000    2
--John    4000    3					                        John    4000    3			                               John    4000    3
--Shane   3000    4					                        Shane   3000    4			                               Shane   3000    4
--Rick    3000    5					                        Rick    3000    4			                               Rick    3000    4
--Sid     1000    6                                 Sid     1000    6                                    Sid     1000    5

--PARTITION
--SYNTAX - MAX(victories) OVER (PARTITION BY weight_class)
--Works like Group by clause but will show all records rather than grouping i.e. rows shown while selection will be same to existing rows in table
--name		weight_class		victories		MAX(victories) OVER (PARTITION BY weight_class)
--Steve		56							20					20
--Uriah		56							5						20

--CTE Recursive
--Used when a specific part of sql needs to be reused.
WITH cte AS (
	select 1 as numb
	UNION ALL
	select numb+1 from cte where cte.numb < 10
)
select * from cte;
