<%@ Page Language="C#" AutoEventWireup="true" CodeFile="validateform.aspx.cs" Inherits="webform.validateform" %>

<html>
    <head>
        <title>validation form</title>
        <h2 style="margin-left:45%"> Validation Form</h2>
        
    </head>
    
    <body >
  <form id="form1" runat="server" >
        <table style="margin-left:40%"> 
 
      
            <tr  style="margin-left:100%"> 
                <td> 
            <asp:Label ID="lblname" runat="server" Text="Name" ></asp:Label>
              </td>
           <td > 
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Name canot be blank" ControlToValidate="txtname"></asp:RequiredFieldValidator>
              
             <asp:RegularExpressionValidator ID="regName" runat="server" ControlToValidate="txtname" 
       ValidationExpression="^[a-zA-Z'.\s]{1,50}"
       Text="Enter a name only text" /> 
               <br /><br />
         </td>
             </tr>
           

            <tr> 
                <td> 
            <asp:Label ID="lblnumber" runat="server" Text="Number"></asp:Label>

                </td>
                <td> 
            <asp:TextBox ID="txtnumber" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Number cannot be blank" ControlToValidate="txtnumber" ></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regPhone" runat="server"  ControlToValidate="txtnumber" 
           ValidationExpression="^[0-9][0-9]{9}$"
           Text="Enter a 10 digit phone number " /> 
          <br /><br />
                </td> 
        </tr>

            <tr>
                <td>
                    <asp:Label ID="lblage" runat="server" Text="Age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Age cannot be blank" ControlToValidate="txtage" ></asp:RequiredFieldValidator>
                  <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage"
                    ErrorMessage=" Enter a Age between 10 to 80  " MaximumValue="80" MinimumValue="10"
                    SetFocusOnError="True" ></asp:RangeValidator>
                    <br /><br />
                </td>
            </tr>
            
            <tr> 
                <td> 
            <asp:Label ID="lblemail" runat="server" Text="email"></asp:Label> </td>
                <td> 
            <asp:TextBox ID="txtemail" runat="server" OnTextChanged="txtemail_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email cannot be blank" ControlToValidate="txtemail"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="regEmail" 
           runat="server" 
           ControlToValidate="txtemail"  
           ValidationExpression="^(.+)@([^\.].*)\.([a-z]{2,})$"
           Text="Enter a valid email with @" />  
            <br /><br />

                </td>
            </tr>



            <tr> 
                <td>
                  
                </td>
                <td> 
            <asp:RadioButton ID="Male" runat="server" GroupName="name"  Text="Male"/>              
                <asp:RadioButton ID="Female" runat="server"  GroupName="name" Text="Female"/>
            <br /><br />
              </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Password cannot be blank" ControlToValidate="txtpassword" ></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
	                  ControlToValidate ="txtpassword"></asp:RequiredFieldValidator>
                    <br /><br />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblconfirmpassword" runat="server" Text="Confirm Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtconfirmpassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="ConfirmPassword cannot be blank" ControlToValidate="txtconfirmpassword"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
	                    ControlToCompare="txtpassword" ControlToValidate="txtconfirmpassword" 
	                    ErrorMessage="Password and ConfirmPassword does not match."></asp:CompareValidator>
                    <br /><br />
                </td>
            </tr>

            <tr> 
                <td> 

                </td>
                    <td>
            <asp:Button ID="Button1" runat="server" Text="Submit"  PostBackUrl="~/Confirm.aspx"/> 
                        </td>
               
            </tr>
         </table>  
        </form>

    </body>
</html>