-- Write your PostgreSQL query statement below
SELECT results
FROM 
(
    select min(u.name) as results
    from
    (
        select u.name, count(mr.rating)
        from movierating mr
        join users u on u.user_id = mr.user_id
        group by u.name
    ) as u
    group by u.count 
    ORDER BY max(u.count) desc, min(u.name)
    limit 1  
)
UNION ALL
(
    select min(m.title)
    from
    (
        select m.title, avg(rating)
        from movierating mr
        join movies m on m.movie_id = mr.movie_id
        where to_char(mr.created_at, 'YYYY-MM') = '2020-02'
        group by m.title
    ) as m
    group by m.avg
    ORDER BY m.avg desc
    limit 1
)