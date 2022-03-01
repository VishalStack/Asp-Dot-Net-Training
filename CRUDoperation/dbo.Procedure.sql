CREATE PROCEDURE [dbo].[EmployeeCrudOperation]   
    -- Add the parameters for the stored procedure here  
    @Employeeid int,  
    @EmployeeName nvarchar(50),  
    @EmployeeSalary numeric(18,2),  
    @EmployeeCity nvarchar(20),  
    @OperationType int   
    --================================================  
    --operation types   
    -- 1) Insert  
    -- 2) Update  
    -- 3) Delete  
    -- 4) Select Perticular Record  
    -- 5) Selec All  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
      
    --select operation  
    IF @OperationType=1  
    BEGIN  
        INSERT INTO Employee VALUES (@EmployeeName,@EmployeeSalary,@EmployeeCity)  
    END  
    ELSE IF @OperationType=2  
    BEGIN  
        UPDATE Employee SET EmployeeName=@EmployeeName , EmployeeSalary=@EmployeeSalary ,EmployeeCity=@EmployeeCity WHERE EmployeeId=@Employeeid  
    END  
    ELSE IF @OperationType=3  
    BEGIN  
        DELETE FROM Employee WHERE EmployeeId=@Employeeid  
    END  
    ELSE IF @OperationType=4  
    BEGIN  
        SELECT * FROM Employee WHERE EmployeeId=@Employeeid  
    END  
    ELSE   
    BEGIN  
        SELECT * FROM Employee   
    END  
       
END  
