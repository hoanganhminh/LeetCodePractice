-- Write your PostgreSQL query statement below
select
t.transaction_date,
coalesce(odd_sum, 0) as odd_sum,
coalesce(even_sum, 0) as even_sum
from transactions t
left join 
(
    select
    transaction_date,
    sum(amount) as odd_sum
    from transactions
    where amount % 2 != 0
    group by transaction_date
) as t1 on t.transaction_date = t1.transaction_date
left join 
(
    select
    transaction_date,
    sum(amount) as even_sum
    from transactions
    where amount % 2 = 0
    group by transaction_date
) as t2 on t.transaction_date = t2.transaction_date
group by t.transaction_date, odd_sum, even_sum
order by t.transaction_date