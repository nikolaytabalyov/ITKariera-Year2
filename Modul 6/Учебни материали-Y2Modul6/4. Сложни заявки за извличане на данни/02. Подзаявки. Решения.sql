USE `softuni`;

-- 01. Най-ниско платени служители
SELECT `e`.`first_name`, `e`.`last_name`, e.`salary` 
FROM `employees` AS `e`
WHERE `e`.`salary` = 
(
    SELECT `salary` 
    FROM `employees` 
    ORDER BY `salary` 
    LIMIT 1
);
  
-- 02. Служители с близки до най-ниските заплати
SELECT `e`.`first_name`, `e`.`last_name`, `e`.`salary` 
FROM `employees` AS `e` 
WHERE `e`.`salary` < 1.1 * 
(
    SELECT `salary` 
    FROM `employees` 
    ORDER BY `salary` 
    LIMIT 1
) 
ORDER BY `salary`;

-- 03. Всички мениджъри
SELECT `e`.`first_name`, `e`.`last_name`, `e`.`job_title` 
FROM `employees` AS `e` 
WHERE `e`.`employee_id` IN 
(
    SELECT DISTINCT `manager_id` 
    FROM `employees`
)
ORDER BY `e`.`first_name`, `e`.`last_name`;

-- 04. Служителите от San Francisco
SELECT `e`.`first_name`, `e`.`last_name`, 
FROM `employees` AS `e` 
WHERE `e`.`address_id` in 
(
    SELECT `address_id` 
    FROM `addresses`
    WHERE `town_id` = 
    (
        SELECT `town_id` 
        FROM `towns` 
        WHERE name = "San Francisco"
    )
)
ORDER BY `e`.`first_name`, `e`.`last_name`;