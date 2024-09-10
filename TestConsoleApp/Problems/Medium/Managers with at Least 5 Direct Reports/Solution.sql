-- Write your PostgreSQL query statement below
select e2.name
from employee e1
join employee e2 on e2.id = e1.managerId
group by e2.id, e2.name
having count(*) >= 5