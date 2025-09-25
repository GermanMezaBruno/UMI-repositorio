


SELECT @@SERVERNAME; --Te verifica el nombre actual del servidor

SP_DROPSERVER 'DESKTOP-FLRFBE3\SQLEXPRESS'; --Borras el nombre del servidor 


SP_ADDSERVER 'BRUNOGERMAN', 'local';  --Agregas un nombre al servidor 


sp_helpserver  --te verifica los servidores registrados



USE Zapateria_UMI;
EXEC sp_changedbowner 'sa'; --Cambie de propietario antiguo al sa "system administrator"
