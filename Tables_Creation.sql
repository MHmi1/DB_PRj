-- "Tables" Creation of DataBase "WoodenDoor" --

--Use WoodenDoor;


create table "User"
(
	Email      varchar(50)    Not Null ,
	Password   varchar(150)   Not Null ,
	FName	   nvarchar(25)   Not Null , 
	LName	   nvarchar(25)   Not Null , 
	Tel	       varchar(20)             ,

	Primary Key (Email)
);


create table Applicant
(
	Email       varchar(50)   Not Null ,
	Uid         int           Not Null ,
	Work_Exp    tinyint                ,
	AppLocation nvarchar(50)  Not Null , 
	Gender      char          Not Null ,
	Birthday    date                   ,
	Req_Sal     smallint               ,

	Primary Key (Email),
	unique (Uid) 
);


create table Agent
(
	Email       varchar(50)   Not Null ,
	Position    nvarchar(25)  Not Null ,

	Primary Key (Email) 
);


create table Business
(
	Bus_Email      varchar(50)    Not Null ,
	BName          nvarchar(75)   Not Null , 
	Agent_Email    varchar(50)    Not Null ,
	Uid            int            Not Null ,
	FundDate       date           Not Null ,
	Site_Address   nvarchar(100)           ,
	IsValid        bit            Not Null ,

	Primary Key (BName),
	unique (Bus_Email),
	unique (Uid)
);


create table BLocations
(
	BName        nvarchar(75)  Not Null ,  
	Location     nvarchar(50)  Not Null , 

	Primary Key (Bname, Location) 
);


create table Cats
(
	BName   nvarchar(75)  Not Null ,
	Cat     nvarchar(35)  Not Null , 

	Primary Key (BName, Cat) 
);


create table Ads
(
	Aid             int			   Not Null  identity(1,1) ,
	BName           nvarchar(75)   Not Null ,
	Title		    nvarchar(100)  Not Null ,
	Context         ntext		   Not Null ,
	Ads_Location    nvarchar(50)			,
	Copp_Type       nvarchar(15)   Not Null ,
	Offer_Sal       smallint		        ,
	RegDate         date           Not Null ,
	ExpireDate      date		   Not Null	,
	IsVisible       bit            Not Null  default 1 ,
	IsValid         bit            Not Null  default 0 , 

	Primary Key (Aid)
);


create table Skill
(
	SName   nvarchar(30)  Not Null ,
	Cat     nvarchar(35)  Not Null ,

	Primary Key (SName, Cat) 
);


create table Role
(
	Role_Name   varchar(20)  Not Null , 

	Primary Key (Role_Name) 
);


create table Permission
(
	Per_Name   varchar(30)  Not Null ,

	Primary Key (Per_Name) 
);


create table Blogger
(
	Uid  int  Not Null identity(1,1) ,

	Primary Key (Uid) 
);


create table Comment
(
	Cid         int		   Not Null  identity(1,1) ,
	Pid         int        Not Null ,
	Uid		    int        Not Null ,
	Context     ntext      Not Null ,
	SendDate    datetime2  Not Null ,
	ReplayCid   int		        	,

	Primary Key (Cid),
	unique (Cid,Pid,Uid)
);


create table Post
(
	Pid         int			    Not Null  identity(1,1) ,
	Writer_id   int				Not Null ,
	Title		nvarchar(100)   Not Null ,
	Context     ntext		    Not Null ,
	Poster      image		       	     ,
	SendDate    datetime2	    Not Null ,
	Status      nvarchar(20)	Not Null  default  N'Draft',

	Primary Key (Pid)
);






create table Recommend
(
	App_Email   varchar(50)		 Not Null ,
	Ads_id      int			     Not Null ,
	Score	    tinyint					  ,

	Primary Key (App_Email,Ads_id)  
);


create table Apply_Ads
(
	App_Email   varchar(50)		 Not Null ,
	Ads_id      int			     Not Null ,
	Status      nvarchar(25)     Not Null  default  N'Waiting',  

	Primary Key (App_Email,Ads_id)  
);


create table Need_Skill
(
	Skill_Name    nvarchar(30)   Not Null ,
	Skill_Cat     nvarchar(35)   Not Null ,
	Ads_id		  int			 Not Null ,

	Primary Key (Skill_Name,Skill_Cat,Ads_id)  
);


create table Has_Skill
(
	Skill_Name    nvarchar(30)   Not Null ,
	Skill_Cat     nvarchar(35)   Not Null ,
	App_Email	  varchar(50)    Not Null ,  
	Level         tinyint				  ,

	Primary Key (Skill_Name,Skill_Cat,App_Email)  
);


create table React
(
	Uid			 int    Not Null ,
	Pid			 int	Not Null ,
	React_Type	 bit			 , 

	Primary Key (Uid,Pid)  
);


create table Add_Fav
(
	Uid	 int    Not Null ,
	Pid	 int	Not Null , 

	Primary Key (Uid,Pid)  
);


create table Has_Role  
(
	Role_Name	 varchar(20)    Not Null ,
	User_Email   varchar(50)    Not Null ,

	Primary Key (Role_Name,User_Email)  
);


create table Has_Permission
(
	Per_Name	 varchar(30)	 Not Null , 
	Role_Name	 varchar(20)	 Not Null ,  

	Primary Key (Role_Name,Per_Name)  
);
