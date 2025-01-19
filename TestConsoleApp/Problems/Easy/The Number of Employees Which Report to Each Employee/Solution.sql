-- Write your PostgreSQL query statement below
select e.reports_to as employee_id, e2.name, count(e.age) as reports_count, round(avg(e.age), 0) as average_age
from employees e
join employees e2 on e2.employee_id = e.reports_to
where e.reports_to is not null
group by e.reports_to, e2.name
order by e.reports_to