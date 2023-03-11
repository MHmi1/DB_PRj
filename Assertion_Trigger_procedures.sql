
CREATE TRIGGER Pass_Change_Warning 
ON "User"  
AFTER  UPDATE  
AS  
if update(password)
   EXEC msdb.dbo.sp_send_dbmail  
        @profile_name = ' Administrator',  
        @recipients = email,  
        @body = 'Hi , Your password has been changed. If this was not done by you, please let us know so that we can check the security of your account again . WOODENDOOR inc .',  
        @subject = 'Password Reminder';  
GO

