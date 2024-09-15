-- Write your PostgreSQL query statement below
select name as customers
from customers c
left join orders o on o.customerid = c.id
where customerid is null