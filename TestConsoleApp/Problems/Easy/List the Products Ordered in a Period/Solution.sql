-- Write your PostgreSQL query statement below
select 
p.product_name,
o.unit
from products p
join 
(
    select 
    product_id,
    sum(unit) as unit
    from orders
    where to_char(order_date, 'YYYY-MM') = '2020-02'
    group by product_id
    having sum(unit) >= 100
) as o on p.product_id = o.product_id