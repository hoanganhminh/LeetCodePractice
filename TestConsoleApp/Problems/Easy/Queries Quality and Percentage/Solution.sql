-- Write your PostgreSQL query statement below
select 
q.query_name, 
round(avg((q.rating::decimal / q.position::decimal)), 2) as quality, 
round((count(q1)::decimal / count(q)::decimal * 100), 2) as poor_query_percentage
from queries q
left join
(
    select 
    result,
    rating
    from queries
    where query_name is not null and rating < 3 
) as q1 on q1.result = q.result
where query_name is not null
group by q.query_name;
