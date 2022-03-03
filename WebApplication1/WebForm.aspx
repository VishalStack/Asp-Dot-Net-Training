<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication1.WebForm" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 30%;
            height: 184px;
        }
        .auto-style2 {
            width: 70%;
            height: 184px;
        }
        .auto-style3 {
            height: 184px;
        }
    </style>
</head>

<body>
   <h1 style="text-align:center">Tool Box</h1>
  <form id="form1" runat="server" style="margin-left:30%">
  <table style="width:100%">

      <%--Standard--%>
      <%--AdRotator--%>
      <tr>
          <td style="width:30%" >
              <asp:Label ID="lblAdRotator" runat="server" Text="AdRotator"></asp:Label> 
                
          </td>
          <td style="width:70%">
               <asp:AdRotator ID="AdRotator1" runat="server" />
          </td>
      </tr>

       <%--BulletedList--%>
       <tr>
          <td style="width:30%" >
              <asp:Label ID="lblBulletedList" runat="server" Text="Bulleted List"></asp:Label> 
          </td>
          <td style="width:70%">
              <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Square">
                  <asp:ListItem>Coffee</asp:ListItem>
                  <asp:ListItem>Bournvita</asp:ListItem>
                  <asp:ListItem>Tea</asp:ListItem>
              </asp:BulletedList>
          </td>
      </tr>

       <%--Button--%>
      <tr>
          <td style="width:30%" >
              <asp:Label ID="lblButton" runat="server" Text="Button"></asp:Label> 
          </td>
          <td style="width:70%">
               <asp:Button ID="Button1" runat="server" Text="Button" />
          </td>
      </tr>

       <%--Calender--%>
      <tr>
          <td style="width:30%" >
              <asp:Label ID="lblCalender" runat="server" Text="Calender"></asp:Label> 
          </td>
          <td style="width:70%">
              <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                  <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                  <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                  <OtherMonthDayStyle ForeColor="#999999" />
                  <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                  <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                  <TodayDayStyle BackColor="#CCCCCC" />
              </asp:Calendar>
          </td>
      </tr>

       <%--CheckBox--%>
      <tr>
          <td style="width:30%" >
              <asp:Label ID="lblCheckBox" runat="server" Text="CheckBox"></asp:Label> 
          </td>
          <td style="width:70%">
              <asp:CheckBox ID="CheckBox1" runat="server" Text="Apple" />
              <asp:CheckBox ID="CheckBox2" runat="server" Text="Banana" />
          </td>
      </tr>

       <%--CheckBoxList--%>
        <tr>
          <td style="width:30%" >
              <asp:Label ID="lblCheckBoxList" runat="server" Text="CheckBoxList"></asp:Label> 
          </td>
          <td style="width:70%">
              <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                  <asp:ListItem>India</asp:ListItem>
                  <asp:ListItem>Canada</asp:ListItem>
                  <asp:ListItem>USA</asp:ListItem>
              </asp:CheckBoxList>
          </td>
      </tr>

       <%--DropDownList--%>
      <tr>
          <td style="width:30%" >
              <asp:Label ID="lblDropDownList" runat="server" Text="DropDownList"></asp:Label> 
          </td>
          <td style="width:70%">
              <asp:DropDownList ID="DropDownList1" runat="server">
                  <asp:ListItem>Ahmedabad</asp:ListItem>
                  <asp:ListItem>Gandhinagar</asp:ListItem>
                  <asp:ListItem>Surat</asp:ListItem>
              </asp:DropDownList>
          </td>
      </tr>

       <%--FileUpload--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblFileUpload" runat="server" Text="FileUpload"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:FileUpload ID="FileUpload1" runat="server" />
          </td>
      </tr>

       <%--HiddenField--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblHiddenField" runat="server" Text="HiddenField"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:HiddenField ID="HiddenField1" runat="server" />
          </td>
      </tr>

       <%--HyperLink--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblHyperLink" runat="server" Text="HyperLink"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
          </td>
      </tr>

       <%--Image--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblImage" runat="server" Text="Image"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Image ID="Image1" runat="server" />
          </td>
      </tr>

       <%--ImageButton--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblImageButton" runat="server" Text="ImageButton"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:ImageButton ID="ImageButton1" runat="server" />
          </td>
      </tr>

       <%--ImageMap--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblImageMap" runat="server" Text="ImageMap"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:ImageMap ID="ImageMap1" runat="server">
                  <asp:CircleHotSpot />
                  <asp:CircleHotSpot />
              </asp:ImageMap>
          </td>
      </tr>

       <%--LinkButton--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblLinkButton" runat="server" Text="Button"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
          </td>
      </tr>

       <%--ListBox--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblListBox" runat="server" Text="ListBox"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:ListBox ID="ListBox1" runat="server">
                  <asp:ListItem>Monday</asp:ListItem>
                  <asp:ListItem>Tuesday</asp:ListItem>
                  <asp:ListItem>Wednesday</asp:ListItem>
                  <asp:ListItem>Thursday</asp:ListItem>
                  <asp:ListItem>Friday</asp:ListItem>
                  <asp:ListItem>Saturday</asp:ListItem>
                  <asp:ListItem>Sunday</asp:ListItem>
              </asp:ListBox>
          </td>
      </tr>

       <%--Literal--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblLiteral" runat="server" Text="Literal"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Literal ID="Literal1" runat="server"></asp:Literal>
          </td>
      </tr>

       <%--Localize--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblLocalize" runat="server" Text="Localize"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Localize ID="Localize1" runat="server"></asp:Localize>
          </td>
      </tr>

       <%--MultipleView--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblMultipleView" runat="server" Text="MultipleView"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:MultiView ID="MultiView1" runat="server">
                  <p>view 1</p>

              </asp:MultiView>
              <asp:MultiView ID="MultiView3" runat="server">
                   <p>view 2</p>

              </asp:MultiView>
          </td>
      </tr>

       <%--Panel--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblPanel" runat="server" Text="Panel"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Panel ID="Panel1" runat="server"></asp:Panel>
          </td>
      </tr>

       <%--PlaceHolder--%>
         <tr>
          <td style="width:30%">
              <asp:Label ID="lblPlaceHolder" runat="server" Text="PlaceHolder"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
          </td>
      </tr>

       <%--RadioButton--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblRadioButton" runat="server" Text="RadioButton"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:RadioButton ID="RadioButton1" runat="server" Text="Date" GroupName ="r1" />
               <asp:RadioButton ID="RadioButton2" runat="server" Text="Month" GroupName ="r1" />
               <asp:RadioButton ID="RadioButton3" runat="server" Text="Year" GroupName ="r1" />
          </td>
      </tr>

       <%--RadioButtonList--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblRadioButtonList" runat="server" Text="RadioButtonList"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                  <asp:ListItem>Mobile</asp:ListItem>
                  <asp:ListItem>Laptop</asp:ListItem>
                  <asp:ListItem>Computer</asp:ListItem>
                  <asp:ListItem>Tablet</asp:ListItem>
              </asp:RadioButtonList>
          </td>
      </tr>

       <%--Substitution--%>
       <tr>
          <td style="width:30%">
              <asp:Label ID="lblSubstitution" runat="server" Text="Substitution"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Substitution ID="Substitution1" runat="server" />
          </td>
      </tr>

       <%--Table--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblTable" runat="server" Text="Table"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Table ID="Table1" runat="server">
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server">Name</asp:TableCell>
                      <asp:TableCell runat="server">Age</asp:TableCell>
                  </asp:TableRow>
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server">Ekta</asp:TableCell>
                      <asp:TableCell runat="server">20</asp:TableCell>
                  </asp:TableRow>
              </asp:Table>
          </td>
      </tr>                 

       <%--TextBox--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblTextBox" runat="server" Text="TextBox"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          </td>
      </tr>

       <%--View--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblView" runat="server" Text="View"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:MultiView ID="MultiView2" runat="server">

                  <asp:View ID="View1" runat="server"></asp:View>
              </asp:MultiView>

              
          </td>
      </tr>

       <%--Wizard--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblWizard" runat="server" Text="Wizard"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Wizard ID="Wizard1" runat="server">
                  <WizardSteps>
                      <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1"></asp:WizardStep>
                      <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2"></asp:WizardStep>
                      <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3"></asp:WizardStep>
                      <asp:WizardStep ID="WizardStep4" runat="server" Title="Step 4"></asp:WizardStep>
                  </WizardSteps>
              </asp:Wizard>
          </td>
      </tr>

       <%--Xml--%>
        <tr>
          <td style="width:30%">
              <asp:Label ID="lblXml" runat="server" Text="Xml"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Xml ID="Xml1" runat="server"></asp:Xml>
          </td>
      </tr>


      <%--Data--%>
      <%--Chart--%>
      <tr>
          <td style="width:30%">
              <asp:Label ID="lblChart" runat="server" Text="Chart"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Chart ID="Chart1" runat="server">
                  <Series>
                      <asp:Series Name="Series1" ChartType="Pie" YValuesPerPoint="6">
                          <Points>
                              <asp:DataPoint YValues="10,0,0,0,0,0" />
                              <asp:DataPoint YValues="20,0,0,0,0,0" />
                              <asp:DataPoint YValues="50,0,0,0,0,0" />
                              <asp:DataPoint YValues="40,0,0,0,0,0" />
                              <asp:DataPoint YValues="20,0,0,0,0,0" />
                          </Points>
                      </asp:Series>
                  </Series>
                  <ChartAreas>
                      <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                  </ChartAreas>
              </asp:Chart>            
          </td>
      </tr>

       <%--DataList--%>
      <%--<tr>
          <td style="width:30%">
              <asp:Label ID="lblDataList" runat="server" Text="DataList"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:DataList ID="DataList1" runat="server">
                  <AlternatingItemTemplate>
                      List
                  </AlternatingItemTemplate>
                  <EditItemTemplate>
                      Edit
                  </EditItemTemplate>
                  <ItemTemplate>
                      Data
                  </ItemTemplate>
                  <SelectedItemTemplate>
                      Item
                  </SelectedItemTemplate>
              </asp:DataList>
          </td>
      </tr>--%>

       <%--DataPager--%>
     <%-- <tr>
          <td style="width:30%">
              <asp:Label ID="lblDataPager" runat="server" Text="DataPager"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:DataPager ID="DataPager1" runat="server">
                  <Fields>
                      <asp:NumericPagerField />
                      <asp:NextPreviousPagerField />
                      <asp:TemplatePagerField>
                      </asp:TemplatePagerField>
                  </Fields>
              </asp:DataPager>
          </td>
      </tr>--%>

       <%--DetailsView--%>
      <%--<tr>
          <td style="width:30%">
              <asp:Label ID="lblDetailsView" runat="server" Text="DetailsView"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
              </asp:DetailsView>
          </td>
      </tr>--%>

       <%--EntityDataSource--%>
      <%--<tr>
          <td style="width:30%">
              <asp:Label ID="lblEntityDataSource" runat="server" Text="EntityDataSource"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:EntityDataSource ID="EntityDataSource1" runat="server"></asp:EntityDataSource>
          </td>
      </tr>--%>

       <%--FormView--%>
    <%--  <tr>
          <td style="width:30%">
              <asp:Label ID="lblFormView" runat="server" Text="FormView"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:FormView ID="FormView1" runat="server"></asp:FormView>
          </td>
      </tr>--%>
      
       <%--GridView--%>
     <%-- <tr>
          <td style="width:30%">
              <asp:Label ID="lblGridView" runat="server" Text="GridView"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:GridView ID="GridView1" runat="server"></asp:GridView>
          </td>
      </tr>--%>

       <%--LinqDataSource--%>
      <%--<tr>
          <td style="width:30%">
              <asp:Label ID="lblLinqDataSource" runat="server" Text="LinqDataSource"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName=""></asp:LinqDataSource>
          </td>
      </tr>--%>

       <%--ListView--%>
      <%--<tr>
          <td style="width:30%">
              <asp:Label ID="lblListView" runat="server" Text="ListView"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:ListView ID="ListView1" runat="server"></asp:ListView>
          </td>
      </tr>--%>

       <%--ObjectDataSource--%>
     <%-- <tr>
          <td style="width:30%">
              <asp:Label ID="lblObjectDataSource" runat="server" Text="ObjectDataSource"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
          </td>
      </tr>--%>

       <%--QueryExtender--%>
     <%-- <tr>
          <td style="width:30%">
              <asp:Label ID="lblQueryExtender" runat="server" Text="QueryExtender"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:QueryExtender ID="QueryExtender1" runat="server"></asp:QueryExtender>
          </td>
      </tr>--%>

       <%--Repeater--%>
      <%--<tr>
          <td style="width:30%">
              <asp:Label ID="lblRepeater" runat="server" Text="Repeater"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Repeater ID="Repeater1" runat="server"></asp:Repeater>
          </td>
      </tr>--%>

       <%--SiteMapDataSource--%>
    <%--  <tr>
          <td style="width:30%">
              <asp:Label ID="lblSiteMapDataSource" runat="server" Text="SiteMapDataSource"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
          </td>
      </tr>--%>

       <%--SqlDataSource--%>
     <%-- <tr>
          <td style="width:30%">
              <asp:Label ID="lblSqlDataSource" runat="server" Text="SqlDataSource"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
          </td>
      </tr>--%>

       <%--XmlDataSource--%>
     <%-- <tr>
          <td style="width:30%">
              <asp:Label ID="lblXmlDataSource" runat="server" Text="XmlDataSource"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
          </td>
      </tr>--%>


       <%--Validation--%>
       <%--CompareValidator--%>
      <tr>
         <td style="width:30%">
              <asp:Label ID="lblCompareValidator" runat="server" Text="CompareValidator"></asp:Label>
          </td>
          <td style="width:70%">
              <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
              <asp:textbox runat="server" textmode="Password" id="txtPassword"></asp:textbox><br />

              <asp:Label ID="lblRePassword" runat="server" Text="RePassword"></asp:Label>
              <asp:textbox runat="server" textmode="Password" id="txtRePassword"></asp:textbox><br />

              <asp:comparevalidator CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password does not match with confirm password." ControlToCompare="txtPassword" ControlToValidate="txtRePassword"></asp:comparevalidator>
              <br />
              <asp:Button ID="Button2" runat="server" Text="Save" />
          </td>
      </tr>
 
      

   

       
      

  </table>
  </form>
</body>
</html>
