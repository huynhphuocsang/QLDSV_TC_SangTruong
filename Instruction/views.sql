CREATE VIEW [dbo].[DSGV_CTTK]
AS
SELECT MAGV, HO + ' ' + TEN AS HOTEN
FROM     dbo.GIANGVIEN
WHERE  (NOT EXISTS
                      (SELECT name
                       FROM      sys.database_principals
                       WHERE   (type_desc = 'SQL_USER') AND (name = dbo.GIANGVIEN.MAGV))) AND (NOT EXISTS
                      (SELECT name
                       FROM      LINK1.QLDSV_TC.sys.database_principals
                       WHERE   (type_desc = 'SQL_USER') AND (name = dbo.GIANGVIEN.MAGV))) AND (NOT EXISTS
                      (SELECT name
                       FROM      LINK2.QLDSV_TC.sys.database_principals
                       WHERE   (type_desc = 'SQL_USER') AND (name = dbo.GIANGVIEN.MAGV)))
GO

CREATE VIEW [dbo].[V_DS_NIENKHOA] AS
SELECT DISTINCT NIENKHOA
FROM     dbo.LOPTINCHI
GO


CREATE VIEW [dbo].[V_DS_PHANMANH] AS
SELECT PUBS.description AS PHONGBAN, SUBS.subscriber_server AS TENSERVER
FROM     dbo.sysmergesubscriptions AS SUBS INNER JOIN
                  dbo.sysmergepublications AS PUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server


GO
