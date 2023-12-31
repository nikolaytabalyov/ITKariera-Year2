USE `geography`;

-- 01. Държави с реки
SELECT `c`.`country_name`, `r`.`river_name` 
FROM `countries` AS c
LEFT JOIN `countries_rivers` AS `cr` ON `cr`.`country_code` = `c`.`country_code`
LEFT JOIN `rivers` AS `r` ON `r`.`id` = `cr`.`river_id`
LEFT JOIN `continents` AS `con` ON `con`.`continent_code` = `c`.`continent_code`
WHERE `con`.`continent_name` = 'Africa'
ORDER BY `c`.`country_name`
LIMIT 5;

-- 02. Държави без планини
SELECT `c`.`country_name`
FROM `countries` AS `c`
LEFT JOIN `mountains_countries` AS `mc` ON `c`.`country_code` = `mc`.`country_code`
WHERE `mc`.`mountain_id` IS NULL;

-- 03. Планините в България 
SELECT `m`.`mountain_range`, `p`.`peak_name`, `p`.`elevation`
FROM `mountains` AS `m`
LEFT OUTER JOIN `peaks` AS `p` ON `p`.`mountain_id` = `m`.`id` 
WHERE `m`.`id` IN 
(
  SELECT `mountain_id` 
  FROM `mountains_countries` 
  WHERE `country_code` = 'BG'
)
AND 
(
  `p`.`id` IS NULL OR `p`.`id` = 
  (
    SELECT `id` 
    FROM `peaks` 
    WHERE `mountain_id` = `m`.`id` 
    ORDER by `elevation` DESC 
    LIMIT 1
  )
)
ORDER BY `p`.`elevation` DESC;

USE `softuni`;
 
-- 04. Всички служители без проекти
SELECT `e`.`employee_id`, `e`.`first_name`, `e`.`last_name` 
FROM `employees` AS `e`
LEFT JOIN `employees_projects` AS `ep` ON `e`.`employee_id` = `ep`.`employee_id`
WHERE `ep`.`project_id` IS NULL
ORDER BY `e`.`first_name`, `e`.`last_name`
LIMIT 3;