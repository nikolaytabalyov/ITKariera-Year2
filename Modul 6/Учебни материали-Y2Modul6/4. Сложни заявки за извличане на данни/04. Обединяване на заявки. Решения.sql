USE `softuni`;

-- 01. Служители и техните мениджъри
(
    SELECT `first_name`, `last_name`, "(no manager)" AS `manager_name`
    FROM `employees` AS `e` 
    WHERE `manager_id` IS NULL
)
UNION
(
    SELECT `first_name`, `last_name`, 
    (
        SELECT CONCAT(`first_name`, " ", `last_name`) 
        FROM `employees` 
        WHERE `employee_id` = `e`.`manager_id`
    )
    FROM `employees` AS `e` 
    WHERE `manager_id` IS NOT NULL
) 
ORDER BY `manager_name`;

-- 02. Тримата най-добре платени
(
    SELECT `first_name`, `last_name`, "manager" AS `position`, `salary`
    FROM `employees` 
    WHERE `employee_id` IN 
    (
        SELECT DISTINCT `manager_id` 
        FROM `employees`
        WHERE `manager_id` IS NOT NULL
    )
    ORDER BY `salary` DESC LIMIT 3
)
UNION
(
    SELECT `first_name`, `last_name`, "employee", `salary`
    FROM `employees`  
    WHERE `employee_id` NOT IN 
    (
        SELECT DISTINCT `manager_id` 
        FROM `employees`
        WHERE `manager_id` IS NOT NULL
    )
    ORDER BY `salary` DESC LIMIT 3
)
ORDER BY `salary` DESC, `first_name`, `last_name`;

USE `geography`;

-- 03. Планините в България
(
    SELECT `mountain_range`,  
    (
        SELECT `peak_name` 
        FROM `peaks` 
        WHERE `mountain_id` = `m`.`id` 
        ORDER by `elevation` DESC 
        LIMIT 1
    ) AS `peak_name`,
    (
        SELECT `elevation` 
        FROM `peaks` 
        WHERE `mountain_id` = `m`.`id` 
        ORDER by `elevation` DESC 
        LIMIT 1
    ) AS `elevation`
    FROM `mountains` AS `m`  
    WHERE `id` IN 
    (
        SELECT `mountain_id` 
        FROM `mountains_countries` 
        WHERE `country_code` = 'BG'
    )
    AND `id` IN 
    (
        SELECT DISTINCT `mountain_id` 
        FROM `peaks`
    )
)
UNION
(
    SELECT `mountain_range`, "no",  "info"
    FROM `mountains` AS `m`  
    WHERE `id` IN 
    (
        SELECT `mountain_id` 
        FROM `mountains_countries` 
        WHERE `country_code` = 'BG'
    )
    AND NOT EXISTS 
    (
        SELECT 1 
        FROM `peaks` 
        WHERE `mountain_id` = `m`.`id`
    )
)
ORDER BY `mountain_range`;
   
-- 04. Всички географски обекти в България 
(
    SELECT `p`.`peak_name` AS `name`, "peak" AS `type`, `p`.`elevation` AS `info` 
    FROM `peaks` AS `p` 
    WHERE `p`.`mountain_id` IN 
    (
        SELECT `mountain_id` 
        FROM `mountains_countries` 
        WHERE `country_code` = 'BG'
    )
)
UNION
(
    SELECT r.`river_name`, "river", `r`.`length` 
    FROM `rivers` AS `r` 
    WHERE `id` IN 
    (
        SELECT `river_id` 
        FROM `countries_rivers` 
        WHERE `country_code` = 'BG'
    )
) 
UNION 
(
    SELECT `m`.`mountain_range`, "mountain", 
    (
        SELECT `elevation` 
        FROM `peaks` 
        WHERE `mountain_id` = `m`.`id` 
        ORDER by `elevation` DESC 
        LIMIT 1
    ) AS `elevation`
    FROM `mountains` AS `m`  
    WHERE `id` IN 
    (
        SELECT `mountain_id` 
        FROM `mountains_countries` 
        WHERE `country_code` = 'BG'
    )
)
ORDER BY `name`;
