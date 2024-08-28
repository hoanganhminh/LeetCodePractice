-- Write your PostgreSQL query statement below
select 
customer_id, 
count(customer_id) as count_no_trans 
from visits v 
left join transactions t on t.visit_id = v.visit_id 
where t.visit_id is null 
group by customer_id