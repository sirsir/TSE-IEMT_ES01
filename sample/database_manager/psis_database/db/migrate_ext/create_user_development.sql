/****** Object:  Login [psisuser]    Script Date: 09/19/2011 11:40:28 ******/
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [psisuser]    Script Date: 09/19/2011 11:40:28 ******/
CREATE LOGIN [psisuser] WITH PASSWORD=N'-2(Bî©l8tAc74¤,Ü8CMÃy[/zY', DEFAULT_DATABASE=[psis_development], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
EXEC sys.sp_addsrvrolemember @loginame = N'psisuser', @rolename = N'sysadmin'
GO
ALTER LOGIN [psisuser] DISABLE