USE iemt_pdt_es01_development;
Go
SELECT COLUMN_NAME, COLUMNPROPERTY(OBJECT_ID(TABLE_SCHEMA + '.' + TABLE_NAME), COLUMN_NAME, 'ColumnID') AS COLUMN_ID
FROM iemt_pdt_es01_development.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='ENGINE_LIST'
Go