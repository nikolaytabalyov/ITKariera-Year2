-- USE softuni;
-- 
-- Задача 1. Намерете всички служители със заплата над 50000

-- SELECT e.first_name, e.last_name, e.salary
-- FROM employees AS e
-- WHERE e.salary > 50000
-- ORDER BY e.salary DESC;

-- Задача 2. Намерете 5 най-добре платени служители.

-- SELECT e.first_name, e.last_name
-- FROM employees AS e
-- ORDER BY e.salary DESC
-- LIMIT 5;

-- Задача 3. Сортирайте таблицата със служители

-- SELECT * 
-- FROM employees AS e
-- ORDER BY 
-- 	e.salary DESC,
-- 	e.first_name ASC,
-- 	e.last_name DESC,
-- 	e.middle_name ASC;

-- Задача 4. Намерете първите 10 започнати проекта

-- SELECT * 
-- FROM projects AS p
-- WHERE p.start_date IS NOT NULL
-- ORDER BY p.start_date, p.name
-- LIMIT 10;

-- Задача 5. Последните 7 наети служителя

-- SELECT e.first_name, e.last_name, e.hire_date
-- FROM employees AS e
-- ORDER BY e.hire_date DESC
-- LIMIT 7;




-- USE geography;



-- Задача 6. Всички планински върхове

-- SELECT p.peak_name
-- FROM peaks AS p
-- ORDER BY p.peak_name ASC;

-- Задача 7. Най-големи държави по население

-- SELECT c.country_name, c.population
-- FROM countries AS c
-- WHERE c.continent_code = 'EU'
-- ORDER BY c.population DESC, c.country_name ASC
-- LIMIT 30;

-- Задача 8. Държави и валути (Евро / Не евро)

-- SELECT c.country_name, c.country_code, IF (
-- 	c.currency_code = 'EUR', 'Euro', 'Not Euro') AS currency
-- FROM countries AS c
-- ORDER BY c.country_name ASC;



