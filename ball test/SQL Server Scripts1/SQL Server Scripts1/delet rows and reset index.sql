Use iemt_pdt_es01_development
go

delete from dbo.IMPORT_CELL_MAPPING
DBCC CHECKIDENT('dbo.IMPORT_CELL_MAPPING', RESEED, 0)