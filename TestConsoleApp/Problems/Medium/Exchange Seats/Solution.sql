-- Write your PostgreSQL query statement below
select
s.id,
coalesce(coalesce(s1.student, s2.student), s.student) as student
from seat s
left join
(
    select 
    (id - 1) as id,
    student
    from seat
    where id % 2 = 0
) 
as s1 on s1.id = s.id
left join
(
    select 
    (id + 1) as id,
    student
    from seat
    where id % 2 != 0
) 
as s2 on s2.id = s.id
order by s.id