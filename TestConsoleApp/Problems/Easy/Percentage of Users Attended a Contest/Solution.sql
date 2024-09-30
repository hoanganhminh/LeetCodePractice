-- Write your PostgreSQL query statement below
select 
contest_id,
round((count(user_id)::decimal / (select count(user_id) from users)) * 100, 2) as percentage 
from register
group by contest_id
order by percentage desc, contest_id asc
