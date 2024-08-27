-- Write your PostgreSQL query statement below
select name from customer
where referee_id is null or referee_id != 2;

/*
select name from (
    select name, COALESCE(referee_id, 0) as referee_id from customer
) where referee_id != 2
*/