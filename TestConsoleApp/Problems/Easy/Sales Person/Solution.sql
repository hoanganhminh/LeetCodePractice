-- Write your PostgreSQL query statement below
select s.name
from salesperson s
left join
(
    select o.sales_id
    from orders o
    join company c on c.com_id = o.com_id
    where c.name like 'RED'
) as o on s.sales_id = o.sales_id
where o.sales_id is null