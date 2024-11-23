-- Write your PostgreSQL query statement below
select
to_char(t.trans_date, 'YYYY-MM') as month,
t.country, 
count(t.trans_date) as trans_count, 
count(t2) approved_count, 
sum(t.amount) as trans_total_amount, 
coalesce(sum(t2.amount), 0) approved_total_amount
from transactions t
left join
(
    select
    id,
    amount
    from transactions
    where state like 'approved'
) as t2 on t.id = t2.id
group by month, t.country;