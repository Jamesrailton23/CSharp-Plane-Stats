using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace top_trumps_web_app
{
    public partial class _default : System.Web.UI.Page
    {
        // Global varibles  
        string my_image;
        double cost;
        string plane_output;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Make image only show once, when page load
            if (!Page.IsPostBack)
            {
                image_1.ImageUrl = "/images/a340.png";
            }
        }

        protected void image_1_Click(object sender, ImageClickEventArgs e)
        {
            //Method call when button is clicked 
            planes();
        }

        protected void planes()
        {
            // String array of diffrent planes, used for images and cost 
            string[] images_array = { "a340", "british744", "conc", "delta777", "united733" };

            // Random number genrator so planes are not shown in order and only once
            Random array_random = new Random();
            my_image = images_array[array_random.Next(5)];

            // Sets the image to a random plane 
            image_1.ImageUrl = "/images/"+ my_image + ".png";

            // lable to show cost and plane type, calling two methods 
            result_lable.Text = String.Format("Aircraft type = {0} / Aircraft cost = {1:C}", plane_str(), plane_cost());
        }
        protected double plane_cost()
        {
            // Method to show plane cost 
            cost = (my_image == "british744") ? cost = 400000000 : cost;
            cost = (my_image == "conc") ? cost = 600000000 : cost;
            cost = (my_image == "a340") ? cost = 250000000 : cost;
            cost = (my_image == "delta777") ? cost = 400000000 : cost;
            cost = (my_image == "united733") ? cost = 100000000 : cost;
            
            // returns the plane cost to plane_cost()
            return cost;
        }

        protected string plane_str()
        {
            // Method to show plane type 
           plane_output = (my_image == "british744") ? plane_output = "British airways Boeing 747" : plane_output;
           plane_output = (my_image == "conc") ? plane_output = "BAE Concorde" : plane_output;
           plane_output = (my_image == "a340") ? plane_output = "Airbus a340-600" : plane_output;
           plane_output = (my_image == "delta777") ? plane_output = "delta Boeing 777-300ER" : plane_output;
           plane_output = (my_image == "united733") ? plane_output = "United Boeing 737-800" : plane_output;

           // returns the plane type to plane_str()
            return plane_output;

            
        }







    }
}