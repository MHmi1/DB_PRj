-- Some Views For DB WoodenDoor --


--Used in Query 8
Create View Same_Location AS
(
	SELECT App_email
	FROM ( (Applicant JOIN Apply_Ads ON Email = App_Email) JOIN Ads ON Ads_id = Aid )
	WHERE Applicant.AppLocation = Ads.Ads_Location
);


--Used in Query 12
Create View Query12_1 AS
(
	SELECT BName , Avg(Offer_Sal) AS Avg_OfferSalary
	FROM ( Ads JOIN Apply_Ads ON Aid = Ads_id)
	WHERE Status = N'Accepted'
	GROUP BY BName
);


--Used in Query 12
Create View Query12_2 AS
(
	SELECT Max(Req_Sal) AS Max_ReqSalary
	FROM Applicant 
	WHERE Gender = 'F' AND Email IN (SELECT Distinct App_Email 
									 FROM Apply_Ads 
									 WHERE Status = N'Accepted')
);


--Used in Query 13
Create View No_of_PostLikes AS 
(
	SELECT Post.Pid , Count(*) AS No_of_Likes
	FROM (Post JOIN React ON Post.Pid = React.Pid)
	WHERE React_type = 1
	GROUP BY Post.Pid
);


--Used in Query 13
Create View No_of_PostDisLikes AS 
(
	SELECT Post.Pid , Count(*) AS No_of_DisLikes
	FROM (Post JOIN React ON Post.Pid = React.Pid)
	WHERE React_type = 0
	GROUP BY Post.Pid
);


--Used in Query 13
Create View Most_Popular_Post AS 
(
	SELECT Top 1 No_of_PostLikes.Pid  , Max(ISNULL([No_of_Likes], 0) - ISNULL([No_of_DisLikes], 0) ) AS Popularity_Number
	FROM (No_of_PostLikes FULL JOIN No_of_PostDisLikes ON No_of_PostLikes.Pid = No_of_PostDisLikes.Pid)
	GROUP BY No_of_PostLikes.Pid
	ORDER BY Popularity_Number DESC
	
);


--Used in Query 13
Create View Two_Comment AS  
(
	SELECT Uid
	FROM Comment
	WHERE Pid NOT IN (SELECT Pid
					  FROM Most_Popular_Post)
	GROUP BY Uid
	HAVING Count(*) > 1 -- in query (2)
);
