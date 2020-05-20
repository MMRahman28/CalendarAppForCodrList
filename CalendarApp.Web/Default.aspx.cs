using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalendarApp.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void OrderButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a name.";
                validationLabel.Visible = true;
                return;
            }
            if (addressTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter an address.";
                validationLabel.Visible = true;
                return;

            }
            if (postcodeTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a postcode.";
                validationLabel.Visible = true;
                return;

            }
            if (phoneTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a phone number.";
                validationLabel.Visible = true;
                return;

            }



            var order = BuildOrder();
            Domain.OrderManager.CreateOrder(order);
            Response.Redirect("Success.aspx");
            
        }


        private DTO.OrderDTO BuildOrder()
        {
            var order = new DTO.OrderDTO();
            
            order.CheckInDay = checkInCalendar.SelectedDate;
            order.CheckOutDay = checkOutCalendar.SelectedDate;
            

            TimeSpan duration = order.CheckOutDay.Subtract(order.CheckInDay);
            order.StayDuration = int.Parse((duration.Days).ToString());



            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.PostCode = postcodeTextBox.Text;
            order.Phone = phoneTextBox.Text;

            return order;
        }

        protected void CheckInCalendar_DayRender(object sender, DayRenderEventArgs e)
        {
            var orders = Domain.OrderManager.GetOrders();


            foreach (var item in orders)
            {
                DateTime checkInLimit = item.CheckInDay.Subtract(TimeSpan.FromDays(1));
                              
                if (e.Day.Date >= checkInLimit && e.Day.Date < item.CheckOutDay)

                {
                    e.Cell.Enabled = false;
                    e.Day.IsSelectable = false;
                    e.Cell.BackColor = System.Drawing.Color.Orchid;

                }
                

            }
        }
        protected void CheckOutCalendar_DayRender(object sender, DayRenderEventArgs e)
        {
            var orders = Domain.OrderManager.GetOrders();
           

            foreach (var item in orders)
            {

                
                if (e.Day.Date >= item.CheckInDay && e.Day.Date < item.CheckOutDay)

                {
                    e.Cell.Enabled = false;
                    e.Day.IsSelectable = false;
                    e.Cell.BackColor = System.Drawing.Color.Orchid;

                }
                if (checkInCalendar.SelectedDate < item.CheckInDay &&
                   checkOutCalendar.SelectedDate > item.CheckOutDay) 
                {
                    calendarValidationMessageLabel.Text = "Error: Invalid Dates.";
                }
                

            }
        }

       
    }   
}