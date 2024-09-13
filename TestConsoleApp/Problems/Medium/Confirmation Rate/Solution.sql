-- Write your PostgreSQL query statement below
select t1.user_id, (round(COALESCE(t2.count, 0) / t1.count::decimal, 2)) as confirmation_rate
from
(
    select s.user_id, count(s.user_id)
    from signups s
    left join confirmations c on c.user_id = s.user_id
    group by s.user_id
) as t1
left join 
(
    select c.user_id, count(c.action)
    from confirmations c
    where c.action = 'confirmed'
    group by c.user_id, c.action
) as t2 on t1.user_id = t2.user_id
