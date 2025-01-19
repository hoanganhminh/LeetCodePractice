-- Write your PostgreSQL query statement below
select e.employee_id, department_id
FROM employee e
left join 
(
    select employee_id, 'Y' as primary_flag
    FROM employee
    group by employee_id
    having count(employee_id) = 1
) as e2 on e.employee_id = e2.employee_id
where e.primary_flag = 'Y' or  e2.primary_flag = 'Y'