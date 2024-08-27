-- Write your PostgreSQL query statement below
select author_id as id from views where author_id = viewer_id group by author_id order by id asc

--select distinct author_id as id from views where author_id = viewer_id order by id asc