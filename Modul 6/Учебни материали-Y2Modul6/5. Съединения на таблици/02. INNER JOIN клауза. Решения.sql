USE `softuni`;

-- 01. addresses with towns
SELECT `e`.`first_name`, `e`.`last_name`, `t`.`name`, `a`.`address_text` 
FROM `employees` AS `e`
INNER JOIN `addresses` AS `a` ON `a`.`address_id` = `e`.`address_id`
INNER JOIN `towns` AS t ON `t`.`town_id` = `a`.`town_id`
ORDER BY `e`.`first_name`, `e`.`last_name`
LIMIT 5;

-- 02. Employeees Hired After
SELECT `e`.`first_name`, `e`.`last_name`, `e`.`hire_date`, `d`.`name` 
FROM `employees` AS `e` 
INNER JOIN `departments` AS `d` ON `d`.`department_id` = `e`.`department_id`
WHERE date(`e`.`hire_date`) > '19990101' AND `d`.`name` IN ('Sales', 'Finance')
ORDER BY `e`.`hire_date`;

-- 03. Employees with Project
SELECT `e`.`employee_id`, `e`.`first_name`, `p`.`name` 
FROM `employees` AS `e`
INNER JOIN `employees_projects` AS `ep` ON `ep`.`employee_id` = `e`.`employee_id`
INNER JOIN `projects` AS `p` ON `p`.`project_id` = `ep`.`project_id`
WHERE date(`p`.`start_date`) > '2002-08-13' AND `p`.`end_date` IS NULL
ORDER BY `e`.`first_name`, `p`.`name`
LIMIT 5;

-- 04. Employee Summary
SELECT
    `e`.`employee_id`, 
    concat(`e`.`first_name`, ' ', `e`.`last_name`) as `employee_name`, 
    concat(`m`.`first_name`, ' ', `m`.`last_name`) as `manager_name`,
    `d`.`name` as `department_name` 
FROM `employees` AS `e`
INNER JOIN `employees` AS `m` ON `m`.`employee_id` = `e`.`manager_id`
INNER JOIN `departments` AS `d` ON `d`.`department_id` = `e`.`department_id`
ORDER BY `e`.`employee_id`
LIMIT 5;

USE `geography`;

-- 05. Highest Peak in Bulgaria
SELECT `c`.`country_code`, `m`.`mountain_range`, `p`.`peak_name`, `p`.`elevation` 
FROM `countries` AS `c`
INNER JOIN `mountains_countries` AS `mc` ON `mc`.`country_code` = `c`.`country_code`
INNER JOIN `mountains` AS `m` ON `m`.`id` = `mc`.`mountain_id`
INNER JOIN `peaks` AS `p` ON `p`.`mountain_id` = `m`.`id`
WHERE `c`.`country_name` = 'Bulgaria' AND `p`.`elevation` > 2835
ORDER BY `elevation` DESC;

-- 06. Mointain Ranges
SELECT `c`.`country_code`, `c`.`country_name`, `m`.`mountain_range` 
FROM `countries` AS `c`
INNER JOIN `mountains_countries` AS `mc` ON `mc`.`country_code` = `c`. `country_code`
INNER JOIN `mountains` AS `m` ON `mc`.`mountain_id` = `m`.`id`
WHERE c.`country_name` IN ('United States', 'Russia', 'Bulgaria')
ORDER BY c.`country_code`, `m`.`mountain_range`;


