-- Write your PostgreSQL query statement below
select e.name as "Employee"
from Employee e
join Employee e2 on e.managerId = e2.id
where e.salary > e2.salary