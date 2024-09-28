-- Write your PostgreSQL query statement below
select
p.product_id,
coalesce(round(sum(units * price)::decimal / sum(units)::decimal, 2), 0) as average_price
from prices p
left join unitssold u on p.product_id = u.product_id and purchase_date between start_date AND end_date
group by p.product_id
