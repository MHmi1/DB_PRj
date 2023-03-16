-- All Requested Queries (1 to 13) --

Use WoodenDoor;


-- Query1 --
SELECT * 
FROM Applicant;



-- Query2 --
SELECT * 
FROM Applicant
WHERE Gender = 'F' AND AppLocation LIKE '%San Francisco%';



-- Query3 --
SELECT Ads.*
FROM Ads
WHERE Aid IN (SELECT Ads_id
              FROM Apply_Ads  
              GROUP BY Ads_id 
              HAVING Count(*) > 1); -- 1 instead of 20
				


-- Query4 --
SELECT Business.BName AS Business_Name
FROM ( (Business JOIN Ads ON Business.BName = Ads.BName) JOIN Need_Skill ON Aid = Ads_id ) 
WHERE Need_Skill.Skill_Name Like '%Python%';



-- Query5 -- 
SELECT Email AS Applicant_Email
FROM (Applicant JOIN Apply_Ads ON Email = App_Email)
WHERE Status = N'Rejected' 
GROUP BY Email
HAVING Count(*) > 0; -- 0 instead of 5



-- Query6 --
SELECT Avg ( DATEDIFF (Year, Birthday, GETDATE()) ) AS Avg_Age
FROM Applicant 
WHERE Email IN (SELECT Email
				FROM (Applicant JOIN Has_Skill ON Email = App_Email)
				WHERE Skill_Name LIKE '%Objective-c%'
				INTERSECT
				SELECT Email
				FROM (Applicant JOIN Has_Skill ON Email = App_Email)
				WHERE Skill_Name LIKE '%Network+%');



-- Query7 --
SELECT Count(*) AS No_of_Applicants
FROM Applicant 
WHERE (Work_Exp BETWEEN 3 AND 5) AND (Req_Sal BETWEEN 12 AND 16);



-- Query8 -- (Uses View)
SELECT Applicant.* 
FROM Applicant 
WHERE Gender ='M' AND Email IN (SELECT App_email
								FROM Same_Location);



-- Query9 --
SELECT * 
FROM Ads 
WHERE Offer_Sal > (SELECT Avg(Req_Sal)  
                   FROM Applicant);



-- Query10 --
SELECT Gender, Avg(Offer_Sal) AS Avg_Offer_Sal 
FROM ( (Applicant JOIN Apply_Ads ON Email = App_Email) JOIN Ads ON Ads_id = Aid)
WHERE Apply_Ads.Status = 'Accepted' 
GROUP BY Gender;



-- Query11 -- 
SELECT Post.* 
FROM (Post JOIN Applicant ON Writer_id = Applicant.Uid)
WHERE ( Work_Exp BETWEEN 2 AND 10 ) AND Email IN (SELECT App_Email 
												 FROM Apply_Ads 
											     WHERE Status ='Rejected');



-- Query12 -- (Uses View)
SELECT Count(*) AS No_of_Businesses
FROM Query12_1 , Query12_2 
WHERE Avg_OfferSalary > Max_ReqSalary;



-- Query13 -- (Uses View)
SELECT Gender , COUNT(*) AS No_of_Applicants
FROM Applicant
WHERE Uid IN (SELECT Applicant.Uid
		      FROM ( (Applicant JOIN Add_Fav ON Applicant.Uid = Add_Fav.Uid) JOIN Most_Popular_Post ON Add_Fav.Pid = Most_Popular_Post.Pid )
			  GROUP BY Applicant.Uid

			  INTERSECT

			  SELECT Applicant.Uid
			  FROM (Applicant JOIN Two_Comment ON Applicant.Uid = Two_Comment.Uid)
			  GROUP BY Applicant.Uid )
GROUP BY Gender;
