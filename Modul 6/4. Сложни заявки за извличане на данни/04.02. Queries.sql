-- USE softuni;

-- Задача 1. Най-ниско платени служители

-- SELECT e.first_name, e.last_name, e.salary
-- FROM employees AS e
-- ORDER BY salary ASC;

-- Задача 2. Служители с близки до най-ниските заплати

-- SELECT e.first_name, e.last_name, e.salary
-- FROM employees AS e
-- WHERE e.salary <= (
-- 	SELECT e.salary
-- 	FROM employees AS e
-- 	ORDER BY e.salary ASC
-- 	LIMIT 1) * 1.1;

-- Задача 3. Всички мениджъри
	
-- SELECT e.first_name, e.last_name, e.job_title	
-- FROM employees AS e
-- WHERE e.employee_id IN (
-- 	SELECT DISTINCT e.manager_id
-- 	FROM employees AS e
-- 	WHERE e.manager_id IS NOT NULL)
-- ORDER BY e.first_name, e.last_name;

-- Задача 4. Служителите от San Francisco

-- SELECT e.first_name, e.last_name
-- FROM employees AS e, addresses AS a
-- WHERE e.address_id = a.address_id 
-- 	AND a.town_id = (
-- 		SELECT t.town_id
-- 		FROM towns AS t
-- 		WHERE t.name = 'San Francisco' 
-- 		LIMIT 1)

