-- Write your PostgreSQL query statement below
select
a.sell_date,
count(*) as num_sold,
string_agg(a.product, ',' order by a.product) as products
from 
(
    select distinct
    sell_date,
    product
    from activities
    order by sell_date
) as a
group by a.sell_date
