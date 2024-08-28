-- Write your PostgreSQL query statement below
select product_name, year, price from product p join sales s on s.product_id = p.product_id