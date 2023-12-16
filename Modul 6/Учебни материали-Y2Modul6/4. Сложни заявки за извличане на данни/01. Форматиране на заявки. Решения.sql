USE `softuni`;

-- 01. Find All employees with salary More Than 50000
SELECT `first_name`, `last_name`, `salary` 
FROM `employees`
WHERE `salary` > 50000
ORDER BY `salary` DESC;

-- 02. Find 5 Best Paid employees
SELECT `first_name`, `last_name` 
FROM `employees`
ORDER BY `salary` DESC
LIMIT 5;

-- 03. Sort employees Table
SELECT * 
FROM `employees`
ORDER BY `salary` DESC, `first_name` ASC, `last_name` DESC, `middle_name` ASC;

-- 04. Find First 10 Started Projects
SELECT * 
FROM `projects`
ORDER BY start_date ASC, name ASC
LIMIT 10;

-- 05. Last 7 Hired employees
SELECT `first_name`, `last_name`, `hire_date` 
FROM `employees`
ORDER BY `hire_date` DESC
LIMIT 7;

USE `geography`;

-- 06. All Mountain peaks
SELECT `peak_name` 
FROM `peaks`
ORDER BY `peak_name`;

-- 07. Biggest Countries by population
SELECT `country_name`, `population`
FROM `countries`
WHERE `continent_code` = 'EU'
ORDER BY `population` DESC, `country_name`
LIMIT 30;

-- 08. countries and Currency (Euro / Not Euro)
SELECT `country_name`, `country_code`,
(CASE WHEN `currency_code`='EUR' THEN 'Euro' ELSE 'Not Euro' END) AS `currency`
FROM `countries`
ORDER BY `country_name`;