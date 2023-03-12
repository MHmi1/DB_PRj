-- Adding All Foreign Keys --
Use WoodenDoor;


--
ALTER TABLE Applicant
ADD FOREIGN KEY (Email) REFERENCES "User"(Email);

ALTER TABLE Applicant
ADD FOREIGN KEY (Uid) REFERENCES Blogger(Uid);


--
ALTER TABLE Agent
ADD FOREIGN KEY (Email) REFERENCES "User"(Email);


--
ALTER TABLE Business
ADD FOREIGN KEY (Uid) REFERENCES Blogger(Uid);

ALTER TABLE Business
ADD FOREIGN KEY (Agent_Email) REFERENCES Agent(Email);


--
ALTER TABLE BLocations
ADD FOREIGN KEY (BName) REFERENCES Business(BName);


--
ALTER TABLE Cats
ADD FOREIGN KEY (BName) REFERENCES Business(BName);


--
ALTER TABLE Ads
ADD FOREIGN KEY (BName) REFERENCES Business(BName);


--
ALTER TABLE Post
ADD FOREIGN KEY (Writer_id) REFERENCES Blogger(Uid);


--
ALTER TABLE Comment
ADD FOREIGN KEY (Pid) REFERENCES Post(Pid);

ALTER TABLE Comment
ADD FOREIGN KEY (Uid) REFERENCES Blogger(Uid);
 
ALTER TABLE Comment
ADD FOREIGN KEY (ReplayCid) REFERENCES Comment(Cid);


--
ALTER TABLE Recommend
ADD FOREIGN KEY (App_Email) REFERENCES Applicant(Email);

ALTER TABLE Recommend
ADD FOREIGN KEY (Ads_id) REFERENCES Ads(Aid);


--
ALTER TABLE Apply_Ads
ADD FOREIGN KEY (App_Email) REFERENCES Applicant(Email);

ALTER TABLE Apply_Ads
ADD FOREIGN KEY (Ads_id) REFERENCES Ads(Aid);


--
ALTER TABLE Need_Skill
ADD FOREIGN KEY (Ads_id) REFERENCES Ads(Aid);

ALTER TABLE Need_Skill
ADD FOREIGN KEY (Skill_Name,Skill_Cat) REFERENCES Skill(SName,Cat);


--
ALTER TABLE Has_Skill
ADD FOREIGN KEY (App_Email) REFERENCES Applicant(Email);

ALTER TABLE Has_Skill
ADD FOREIGN KEY (Skill_Name,Skill_Cat) REFERENCES Skill(SName,Cat);


--
ALTER TABLE React
ADD FOREIGN KEY (Uid) REFERENCES Blogger(Uid);

ALTER TABLE React
ADD FOREIGN KEY (Pid) REFERENCES Post(Pid);


--
ALTER TABLE Add_Fav
ADD FOREIGN KEY (Uid) REFERENCES Blogger(Uid);

ALTER TABLE Add_Fav
ADD FOREIGN KEY (Pid) REFERENCES Post(Pid);


--
ALTER TABLE Has_Role
ADD FOREIGN KEY (Role_Name) REFERENCES Role(Role_Name);

ALTER TABLE Has_Role
ADD FOREIGN KEY (User_Email) REFERENCES "User"(Email);


--
ALTER TABLE Has_Permission
ADD FOREIGN KEY (Role_Name) REFERENCES Role(Role_Name);

ALTER TABLE Has_Permission
ADD FOREIGN KEY (Per_name) REFERENCES Permission(Per_Name);




-- Some Constraints --

--
ALTER TABLE Applicant
ADD CONSTRAINT Valid_Age CHECK ( DATEDIFF (year, Birthday, GETDATE()) > 15 );

ALTER TABLE Applicant
ADD CONSTRAINT Valid_ReqSal CHECK ( Req_Sal > 0 );


--
ALTER TABLE Business
ADD CONSTRAINT Valid_FundDate CHECK ( FundDate < GETDATE() );


--
ALTER TABLE Ads
ADD CONSTRAINT Valid_OfferSal CHECK ( Offer_Sal > 0 );

ALTER TABLE Ads
ADD CONSTRAINT Ads_Duration CHECK ( DATEDIFF (month, RegDate, ExpireDate) < 2 );


