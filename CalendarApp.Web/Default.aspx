<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalendarApp.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
            font-size: x-large;
            background-color: #99CCFF;
        }
        .auto-style2 {
            font-size: x-large;
            color: #FF0000;
            background-color: #C0C0C0;
        }
    </style>
    
</head>
<body>



    <form id="form1" runat="server">
      <div class="container jumbotron">
            <div class="page-header">
                <h1>Booking Service Demo</h1> 
                <p class="lead">by M M Rahman</p>
           </div>

          <div>
                <h2>Description</h2>
                <p>This web app has been created to showcase C# and ASP.NET skills. 
                    This web app can be used to provide a booking service to the customers.
                    The app utilises a SQL server and keeps a record of the bookings. Customers use the webform to supply their details.
                    Once the booking is made (when the customer clicks the order button), it confirms about the booking by redirecting them to a different webpage and highlights the booking dates in pink (The pink dates shown in the calendar are the unavailable dates which are already booked).
                    If the customer does not provide all the details the app shows the relevant error messages. 
                </p>

            </div>

           <div class="row">

                            
               <div class="col-xs-6 col-sm-6 col-md-6 flex-column">
                <p><strong>Select your check in day:</strong></p>
                 <asp:Calendar ID="checkInCalendar" runat="server" OnDayRender="CheckInCalendar_DayRender"  BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="250px" Width="250px"  >
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                </asp:Calendar>
               </div> 
               <div class="col-xs-6 col-sm-6 col-md-6 flex-column">
                       
                <p> <strong>Select your check out day:</strong></p>
                
                <asp:Calendar ID="checkOutCalendar" runat="server" OnDayRender="CheckOutCalendar_DayRender" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="250px" Width="250px">
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                </asp:Calendar>
               </div>
                          
            
           </div>
        
        <div><p style="color:purple">&nbsp;</p>
            <p style="color:purple">
                <asp:Label ID="calendarValidationMessageLabel" runat="server" CssClass="auto-style2"></asp:Label>

             </p>
            <p style="color:purple">The dates highlighted pink are unavailable.

             </p>
            <p>We operate on first come first serve basis.</p>
            <p>
                <asp:Label ID="validationLabel" runat="server" CssClass="auto-style1"></asp:Label>
            </p>
        </div>
         
        <div>
        <p>
            Name:</p>
        <p>
            <asp:TextBox ID="nameTextBox" runat="server"  CssClass="form-control"></asp:TextBox>
        </p>
        <p>
            Address:</p>
        <p>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </p>
        <p>
            Postcode:</p>
        <p>
            <asp:TextBox ID="postcodeTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </p>
        <p>
            Phone:</p>
        <p>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Choose your payment options:</p>
        <p>
            <asp:RadioButton ID="cashRadioButton" runat="server" Text="&nbsp;Cash" />
        </p>
        <p>
            <asp:RadioButton ID="cardRadioButton" runat="server" Text="&nbsp;Card" />
        </p>
        <p>
            <asp:Button ID="OrderButton" runat="server" OnClick="OrderButton_Click "   Text="Order" Class="btn-primary"/>
        </p>
        </div>
     </div>          
    </form>
    
       
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>

</body>
</html>
