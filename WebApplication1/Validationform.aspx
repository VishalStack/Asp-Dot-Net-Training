<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validationform.aspx.cs" Inherits="WebApplication1.Validationform" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Form</title>
</head>
<body>
    <form id="form1" runat="server">
        
       <table style="margin-left:40%">
            <h1 style="text-align:center; margin-top:3%">Registration Form</h1>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
            <tr style="width:100%">
                <td>
                    <asp:Label ID="lblFullName" runat="server" Text="Full Name"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
          
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Full Name cannot be blank" ControlToValidate="txtFullName" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"  RegularExpression="" ErrorMessage = "Please enter only alphabets" ControlToValidate="txtFullName" ForeColor="Red" ValidationExpression="[a-zA-Z'.\s]{1,50}"></asp:RegularExpressionValidator>
                </td>
            </tr>


              <tr>
                <td>
                    <asp:Label ID="lblEmailId" runat="server" Text="Email Id"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email Id cannot be blank" ControlToValidate="txtEmailId" ForeColor="Red"></asp:RequiredFieldValidator>  
  
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmailId" ErrorMessage="Enter proper email id format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator> 
                </td>
            </tr>

              <tr>
                <td>
                    <asp:Label ID="lblMobileNumber" runat="server" Text="Mobile Number"></asp:Label>
               </td>

                <td>
                    <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mobile Number cannot be blank" ControlToValidate="txtMobileNumber"  ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMobileNumber" ErrorMessage="Mobile number must be 10 digit" validationExpression="\d{10}"  ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
                </td>
           
               <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>

                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Age cannot be blank" ControlToValidate="txtAge" ForeColor="Red"></asp:RequiredFieldValidator>
               
               <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age must be between 18 to 50" ControlToValidate="txtAge" ForeColor="Red" MaximumValue="50" MinimumValue="18"></asp:RangeValidator>  
               </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                </td>
           
               <td>
                   <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="Gender1" />
                   <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="Gender1" />
                  
                
               </td>
            </tr> 

              <tr>
                <td>
                
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>

                   
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Password cannot be blank" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>  
                    
                </td>
            </tr>

        
              <tr>
                <td>

                    <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
                     <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Password and confirm password must be same" ForeColor="Red"></asp:CompareValidator>

                </td>
            </tr>

              
         
       
         </table>
        <br />
         <asp:Button ID="Button1" runat="server" Text="Submit" PostBackUrl="~/Submit.aspx" style="margin-left:50%"   />
        
    </form>

   
</body>
</html>

        

