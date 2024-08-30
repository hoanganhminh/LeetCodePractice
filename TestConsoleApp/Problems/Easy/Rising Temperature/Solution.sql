-- Write your PostgreSQL query statement below
select w1.id 
from weather w1 
join weather w2 on w2.recordDate = w1.recordDate - 1
where w1.temperature > w2.temperature