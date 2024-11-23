duplicateListItemsLoop :: [a] -> [a] -> [a]
duplicateListItemsLoop list duplicated =
    if null list then duplicated
    else duplicateListItemsLoop (tail list) (duplicated ++ [head list] ++ [head list])

duplicateListItems :: [a] -> [a]
duplicateListItems list = duplicateListItemsLoop list []