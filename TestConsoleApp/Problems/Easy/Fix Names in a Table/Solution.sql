-- Write your PostgreSQL query statement below
select user_id, left(upper(name), 1) || right(lower(name), -1) as name
from users
order by user_id