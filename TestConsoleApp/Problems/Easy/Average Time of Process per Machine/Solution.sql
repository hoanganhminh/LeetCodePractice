-- Write your PostgreSQL query statement below
select 
a1.machine_id,
round(avg(a2.timestamp - a1.timestamp)::decimal, 3) as processing_time
from Activity a1
join Activity a2 on a1.machine_id = a2.machine_id and a1.process_id = a2.process_id and a1.activity_type != a2.activity_type
where a1.activity_type = 'start'
group by a1.machine_id;