-- USE softuni;

-- Задача 1. Най-висока заплата по длъжности

-- SELECT DISTINCT e.job_title, e.salary
-- FROM employees AS e
-- ORDER BY e.salary DESC;

-- Задача 2. Най-ниско платени служители по отдели 

-- SELECT e.first_name, e.last_name, e.salary, (
-- 	SELECT d.name
-- 	FROM departments AS d
-- 	WHERE d.department_id = e.department_id
-- 	LIMIT 1) AS department
-- FROM employees AS e
-- WHERE	e.salary = (
-- 	SELECT emp.salary
-- 	FROM employees AS emp
-- 	WHERE emp.department_id = e.department_id
-- 	ORDER BY emp.salary ASC
-- 	LIMIT 1)
-- ORDER BY e.salary ASC;

-- Задача 3. Мениджъри с същото презиме

-- SELECT e.first_name, e.last_name
-- FROM employees AS e
-- WHERE e.employee_id IN (
-- 	SELECT DISTINCT em.manager_id
-- 	FROM employees AS em)
-- 	
-- 	AND e.middle_name IN (
-- 	SELECT DISTINCT em.middle_name
-- 	FROM employees AS em
-- 	WHERE em.manager_id = e.employee_id)
-- ORDER BY e.first_name;

-- Задача 4. Мениджъри с по-ниска заплата 

-- SELECT e.first_name, e.last_name
-- FROM employees AS e
-- WHERE e.employee_id IN (
-- 	SELECT DISTINCT em.manager_id
-- 	FROM employees AS em)
-- 	
-- 	AND 0 < (
-- 	SELECT COUNT(*)
-- 	FROM employees AS emp
-- 	WHERE	emp.salary > e.salary);

-- Задача 5. Мениджъри с точно 5 подчинени

SELECT e.first_name, e.last_name
FROM employees AS e
WHERE e.employee_id IN (
	SELECT DISTINCT em.manager_id
	FROM employees AS em)
	
	AND (
	SELECT COUNT(*)
	FROM employees AS emp 
	WHERE emp.manager_id = e.employee_id) = 5
ORDER BY e.first_name;
	
