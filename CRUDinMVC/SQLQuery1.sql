﻿Create procedure [dbo].[DeleteStudent]  
(  
   @StdId int  
)  
as   
begin  
   Delete from StudentReg where Id=@StdId  
End
