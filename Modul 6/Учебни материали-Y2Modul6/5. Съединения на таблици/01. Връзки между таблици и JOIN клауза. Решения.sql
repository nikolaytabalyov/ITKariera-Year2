USE `softuni`;

-- 01. Employee Address
SELECT `e`.`employee_id`, `e`.`job_title`, `e`.`address_id`, `a`.`address_text` 
FROM `employees` AS `e`
JOIN `addresses` AS `a` ON `a`.`address_id` = `e`.`address_id`
ORDER BY `a`.`address_id`
LIMIT 5;

-- 02. Sales Employee
SELECT `e`.`employee_id`, `e`.`first_name`, `e`.`last_name`, `d`.`name` 
FROM `employees` AS `e`
JOIN `departments` AS `d` ON `d`.`department_id` = `e`.`department_id`
WHERE `d`.`name` = 'Sales'
ORDER BY `employee_id` DESC;

-- 03. Employee departments
SELECT `e`.`employee_id`, `e`.`first_name`, `e`.`salary`, `d`.`name` 
FROM `employees` AS `e`
JOIN `departments` AS `d` ON `d`.`department_id` = `e`.`department_id`
WHERE `salary` > 15000
ORDER BY `d`.`department_id` DESC
LIMIT 5;

-- 04. employees without Project
SELECT `e`.`employee_id`, `e`.`first_name` 
FROM `employees` AS `e`
WHERE `e`.`employee_id` NOT IN   
(
	SELECT DISTINCT `ep`.`employee_id` 
	FROM `employees_projects` AS `ep`
)
ORDER BY `e`.`employee_id` DESC
LIMIT 3;

-- 05. Employee Manager
SELECT `e`.`employee_id`, `e`.`first_name`, `m`.`employee_id` as 'manager_id', `m`.`first_name` as 'manager_name'
FROM `employees` AS `e`
INNER JOIN `employees` AS `m` ON `m`.`employee_id` = `e`.`manager_id`
WHERE `e`.`manager_id` IN (3,7)
ORDER BY `e`.`first_name`;

-- 06. Min salary
SELECT `min_salary`.`salary`, `d`.`name` 
FROM
(
	SELECT `e`.`salary` AS `salary`, `e`.`department_id` 
	FROM `employees` AS `e`
	ORDER BY `e`.`salary` 
	LIMIT 1
) AS `min_salary`
JOIN `departments` AS `d` ON `d`.`department_id` = `min_salary`.`department_id`

USE `geography`;

-- 07. countries without any mountains
SELECT `country_name` 
FROM `countries`
WHERE `country_code` NOT IN 
(
	SELECT DISTINCT `country_code` 
	FROM `mountains_countries`
);