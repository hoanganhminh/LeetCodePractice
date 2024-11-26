-- Write your PostgreSQL query statement below
select * from users
where mail ~ '^[a-zA-Z]{1,}([a-zA-Z0-9._-]*)+@leetcode[.]com$';