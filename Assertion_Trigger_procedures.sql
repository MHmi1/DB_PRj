--TRIGGER SECTION 

-- This section sends a notification email if the user's password is updated in the system 
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


-- This section saves users' information entered in the system, including email and date of entry
 CREATE TRIGGER New_User_Audit   
    ON "User"  
    FOR INSERT  
    AS  
    BEGIN  
      Declare @Id int  
      SELECT @Id = email from inserted  
      INSERT INTO User_Audit 
      VALUES ('New User with Id = ' + CAST(@Id AS VARCHAR(50)) + ' is added at ' + CAST(Getdate() AS VARCHAR(22)))  
    END  
	go 


-- This section saves users' information DELETED from the system, including email and date of deletion

	    CREATE TRIGGER Del_User_Audit     
    ON "User"  
    FOR DELETE  
    AS  
    BEGIN  
      Declare @Id1 int  
      SELECT @Id1 = email from deleted  
      INSERT INTO User_Audit  
      VALUES ('An existing User with Id = ' + CAST(@Id1 AS VARCHAR(50)) + ' is deleted at ' + CAST(Getdate() AS VARCHAR(22)))  
    END 
	go 

