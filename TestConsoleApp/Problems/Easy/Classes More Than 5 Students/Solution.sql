-- Write your PostgreSQL query statement below
select class
from courses
group by class
having count(*) >= 5