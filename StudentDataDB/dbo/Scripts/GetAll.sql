SELECT * FROM Personal_Info P
INNER JOIN Family_Profile F on P.IdNumber=F.StudentId
INNER JOIN SHS_Information S on P.IdNumber = S.StudentId
INNER JOIN College_Information C on P.IdNumber = C.StudentId