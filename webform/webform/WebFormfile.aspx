<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormfile.aspx.cs" Inherits="webform.WebFormfile" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 30%;
        }
        .auto-style2 {
            margin-left: 68px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server"> 
    <table style="width:100%  ">
<%--Standard--%>

        <%--AdRotator--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblAdRotator" runat="server" Text="AdRotator"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:AdRotator ID="AdRotator1" runat="server" />
            </td>
        </tr>

        <%--BulletedList--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblBulletedList" runat="server" Text="BulletedList"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:BulletedList ID="BulletedList" runat="server" BorderStyle="Groove" BulletStyle="UpperRoman" Font-Bold="True" >
                    <asp:ListItem>Apple</asp:ListItem>
                    <asp:ListItem>Banana</asp:ListItem>
                    <asp:ListItem>Cherry</asp:ListItem>
                </asp:BulletedList>
                
            </td>
        </tr>

        <%--Button--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblButton" runat="server" Text="Button"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Button ID="Button" runat="server" Text="Submit" />
            </td>
        </tr>

        <%--Calendar--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblCalendar" runat="server" Text="Calendar"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
            </td>
        </tr>

        <%--CheckBox--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblCheckBox" runat="server" Text="CheckBox"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:CheckBox ID="Apple" runat="server" BorderStyle="Groove" Text="Apple" />
                <asp:CheckBox ID="Banana" runat="server" BorderStyle="Groove" Text="Banana" />
               <asp:CheckBox ID="Cherry" runat="server" BorderStyle="Groove" Text="Cherry"/>
            </td>
        </tr>

        <%--CheckBoxList--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblCheckBoxList" runat="server" Text="CheckBoxList"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:CheckBoxList ID="CheckBoxList" runat="server">
                    <asp:ListItem>Car</asp:ListItem>
                    <asp:ListItem>Bike</asp:ListItem>
                    <asp:ListItem>Auto</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>

        <%--DropDownList--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblDropDownList" runat="server" Text="DropDownList"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:DropDownList ID="DropDownList" runat="server" BackColor="#FF6699" Font-Bold="True" Font-Names="Bahnschrift SemiBold Condensed" Font-Size="Larger">
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>Canada</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>UK</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

         <%--FileUpload--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblFileUpload" runat="server" Text="FileUpload"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:FileUpload ID="FileUpload" runat="server" /> 
            </td>
        </tr>

         <%--HiddenField--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblHiddenField" runat="server" Text="HiddenField"></asp:Label>
            </td>     
            <td style="width:70%">
                
                <asp:HiddenField ID="HiddenField" runat="server" />
            </td>
        </tr>

         <%--HyperLink--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblHyperLink" runat="server" Text="HyperLink"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:HyperLink ID="HyperLink" runat="server">HyperLink</asp:HyperLink>
            </td>
        </tr>

         <%--Image--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblImage" runat="server" Text="Image"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Image ID="Image" runat="server" ImageUrl="D:/OneDrive/Pictures/Camera/abc.jpg" Width="230px" Height="142px" />
            </td>
        </tr>

         <%--ImageButton--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblImageButton" runat="server" Text="ImageButton"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:ImageButton ID="ImageButton" runat="server" ImageUrl="D:/OneDrive/Pictures/Camera/abc.jpg"  Height="81px" Width="94px" />
            </td>
        </tr>

         <%--ImageMap--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblImageMap" runat="server" Text="ImageMap"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:ImageMap ID="ImageMap" runat="server"></asp:ImageMap>
            </td>
        </tr>

         <%--LinkButton--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblLinkButton" runat="server" Text="LinkButton"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:LinkButton ID="LinkButton" runat="server">LinkButton</asp:LinkButton>
            </td>
        </tr>

         <%--ListBox--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblListBox" runat="server" Text="ListBox"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:ListBox ID="ListBox" runat="server" BackColor="White" Font-Italic="True" Font-Overline="True" Font-Strikeout="False" Rows="3">
                    <asp:ListItem>Apple</asp:ListItem>
                    <asp:ListItem>Banana</asp:ListItem>
                     <asp:ListItem>Cherry</asp:ListItem>
                    <asp:ListItem>Mango</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:ListBox>
            </td>
        </tr>

         <%--Literal--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblLiteral" runat="server" Text="Literal"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Literal ID="Literal" runat="server"></asp:Literal>
            </td>
        </tr>

         <%--Localize--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblLocalize" runat="server" Text="Localize"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Localize ID="Localize" runat="server"></asp:Localize>
            </td>
        </tr>

         <%--MultiView--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblMultiView" runat="server" Text="MultiView"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:MultiView ID="MultiView" runat="server"></asp:MultiView>
            </td>
        </tr>

        <%--Panel--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblPanel" runat="server" Text="Panel"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Panel ID="Panel" runat="server"></asp:Panel>
            </td>
        </tr>

        <%--PlaceHolder--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblPlaceHolder" runat="server" Text="PlaceHolder"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:PlaceHolder ID="PlaceHolder" runat="server"></asp:PlaceHolder>
            </td>
        </tr>

        <%--RadioButton--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblRadioButton" runat="server" Text="RadioButton"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:RadioButton ID="Male" runat="server" GroupName="name"  Text="Male"/>
                <asp:RadioButton ID="Female" runat="server"  GroupName="name" Text="Female"/>
            </td>
        </tr>

        <%--RadioButtonList--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblRadioButtonList" runat="server" Text="RadioButtonList"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:RadioButtonList ID="RadioButtonList" runat="server">
                    <asp:ListItem>Car</asp:ListItem >
                    <asp:ListItem>bike</asp:ListItem>
                    <asp:ListItem>Bus</asp:ListItem>
                    <asp:ListItem>Auto</asp:ListItem>
                    <asp:ListItem>Train</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>

        <%--Substitution--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblSubstitution" runat="server" Text="Substitution"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Substitution ID="Substitution" runat="server" />
                <asp:Label ID="Substitution1" runat="server" Text="Please Enter FirstNumber"  
                            ></asp:Label> 
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 <asp:Label ID="Substitution2" runat="server" Text="Please Enter SecondNumber"  
                            ></asp:Label> 
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
              
            </td>
        </tr>

        <%--Table--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblTable" runat="server" Text="Table"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Table ID="Table" runat="server" BorderColor="#009933" BorderStyle="Dotted" BorderWidth="5px" ForeColor="#003399" GridLines="Both">
                    
                    <asp:TableRow runat="server">
                         <asp:TableCell runat="server">Index</asp:TableCell>
                         <asp:TableCell runat="server">Name</asp:TableCell>
                         <asp:TableCell runat="server">Age</asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow runat="server">
                         <asp:TableCell runat="server">1</asp:TableCell>
                         <asp:TableCell runat="server">Dhwani</asp:TableCell>
                         <asp:TableCell runat="server">20</asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow runat="server">
                         <asp:TableCell runat="server">2</asp:TableCell>
                         <asp:TableCell runat="server">xyz</asp:TableCell>
                         <asp:TableCell runat="server" >0</asp:TableCell>
                    </asp:TableRow>
                    
                </asp:Table>
            </td>
        </tr>

        <%--TextBox--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblTextBox" runat="server" Text="TextBox"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
            </td>
        </tr>

        <%--View--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblView" runat="server" Text="View"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:View ID="View" runat="server"></asp:View>
            </td>
        </tr>

        <%--Wizard--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblWizard" runat="server" Text="Wizard"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Wizard ID="Wizard" runat="server">
                    <WizardSteps>
                        <asp:WizardStep ID="WizardStep1" runat="server" Title=" 1"></asp:WizardStep>
                        <asp:WizardStep ID="WizardStep2" runat="server" Title="2"></asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
            </td>
        </tr>

        <%--Xml--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblXml" runat="server" Text="Xml"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Xml ID="Xml" runat="server"></asp:Xml>
            </td>
        </tr>

<%--DATA--%>

        <%--Chart--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblChart" runat="server" Text="Chart"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Chart ID="Chart1" runat="server" Palette="Berry" Width="526px">
                    <Series>
                        <asp:Series Name="Series1" ChartType="StackedColumn" YValuesPerPoint="2"></asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                    </ChartAreas>
                    <Titles>
                        <asp:Title Name="Title1">
                        </asp:Title>
                        <asp:Title Name="Title2">
                        </asp:Title>
                    </Titles>
                    <Annotations>
                        <asp:LineAnnotation Name="LineAnnotation1">
                        </asp:LineAnnotation>
                        
                    </Annotations>
                </asp:Chart>
            </td>
        </tr>
        
        <%--DataList--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblDataList" runat="server" Text="DataList"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:DataList ID="DataList" runat="server">
                    <ItemStyle BorderStyle="Solid" Font-Bold="True" />
                </asp:DataList>
            </td>
        </tr>

        <%--DataPager--%>
      <%--  <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblDataPager" runat="server" Text="DataPager  "></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:DataPager ID="DataPager" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                    </Fields>
                </asp:DataPager>
            </td>
        </tr>--%>

        <%--DetailsView--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblDetailsView" runat="server" Text="DetailsView"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:DetailsView ID="DetailsView" runat="server" Height="50px" Width="125px"></asp:DetailsView>
            </td>
        </tr>

        <%--EntityDataSource--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblEntityDataSource" runat="server" Text="EntityDataSource"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:EntityDataSource ID="EntityDataSource" runat="server"></asp:EntityDataSource>
            </td>
        </tr>

        <%--FormView--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblFormView" runat="server" Text="FormView"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:FormView ID="FormView" runat="server"></asp:FormView>
            </td>
        </tr>

        <%--GridView--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblGridView" runat="server" Text="GridView"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:GridView ID="GridView" runat="server" Width="584px">
                    <Columns>
                        <asp:CommandField HeaderText="btn" ShowEditButton="True" />
                        <asp:BoundField DataField="Age" SortExpression="Age" />
                        <asp:CommandField ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

       <%--LinqDataSource--%>
        <%--<tr>
            <td class="auto-style1" >
                <asp:Label ID="lblLinqDataSource" runat="server" Text="LinqDataSource"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:LinqDataSource ID="LinqDataSource" runat="server"></asp:LinqDataSource>
            </td>
        </tr>--%>

        <%--ListView--%>
        <%--<tr>
            <td class="auto-style1" >
                <asp:Label ID="lblListView" runat="server" Text="ListView"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:ListView ID="ListView" runat="server"></asp:ListView>
            </td>
        </tr>--%>



        <%--ObjectDataSource--%>
        <%--<tr>
            <td class="auto-style1" >
                <asp:Label ID="lblObjectDataSource" runat="server" Text="ObjectDataSource"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:ObjectDataSource ID="ObjectDataSource" runat="server"></asp:ObjectDataSource>
            </td>
        </tr>--%>

        <%--QueryExtender--%>
        <%--<tr>
            <td class="auto-style1" >
                <asp:Label ID="lblQueryExtender" runat="server" Text="QueryExtender"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:QueryExtender ID="QueryExtender" runat="server"></asp:QueryExtender>
            </td>
        </tr>--%>

        <%--Repeater--%>
        <%--<tr>
            <td class="auto-style1" >
                <asp:Label ID="lblRepeater" runat="server" Text="Repeater"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:Repeater ID="Repeater" runat="server"></asp:Repeater>
            </td>
        </tr>--%>

        <%--SiteMapDataSource--%>
        <%--<tr>
            <td class="auto-style1" >
                <asp:Label ID="lblSiteMapDataSource" runat="server" Text="SiteMapDataSource"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:SiteMapDataSource ID="SiteMapDataSource" runat="server" />
            </td>
        </tr>--%>

        <%--SqlDataSource--%>
        <%--<tr>
            <td class="auto-style1" >
                <asp:Label ID="lblSqlDataSource" runat="server" Text="SqlDataSource"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:SqlDataSource ID="SqlDataSource" runat="server"></asp:SqlDataSource>
            </td>
        </tr>--%>

        <%--XmlDataSource--%>
        <%--<tr>
            <td class="auto-style1" >
                <asp:Label ID="lblXmlDataSource" runat="server" Text="XmlDataSource"></asp:Label>
            </td>     
            <td style="width:70%">
                <asp:XmlDataSource ID="XmlDataSource" runat="server"></asp:XmlDataSource>
            </td>
        </tr>--%>

<%--Validation--%>

        <%--CompareValidator--%>
        <tr>
            <td class="auto-style1" >
                <asp:Label ID="lblCompareValidator" runat="server" Text="CompareValidator"></asp:Label>
            </td>     
            <td style="width:70%">
                
                <asp:Label ID="lblpass" runat="server" Text="PassWord"></asp:Label>
                <asp:TextBox ID="txtpass" runat="server" CssClass="auto-style2"></asp:TextBox><br />
                   
                <asp:Label ID="lblconfirmpass" runat="server" Text=" ConfirmPassWord"></asp:Label>
                <asp:TextBox ID="txtConfirmpass" runat="server"></asp:TextBox><br />
                
                <asp:Button ID="Button1" runat="server" Text="Button" />
                
                 <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpass" ControlToValidate="txtConfirmpass"  ErrorMessage="Password not same !!"></asp:CompareValidator>
            </td>

        
        </tr>
        

        


    </table>
 </form>
</body>
</html>
