using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http.Headers;
using Nutid.Model;

namespace Nutid
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // When the page load, Get() function is called.
            Get();
            // Putting data in GridView1
            GridView1.DataSource = Get();
            // Binding the data
            GridView1.DataBind();
        }

        // Get
        public List<StoreItem> Get()
        {
            // We call for the Nutid Client
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.nutidweboffice.com/bunkersgolfhk/api/assignment");

            // We accept it as a json Object
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Getting response
            HttpResponseMessage response = client.GetAsync("assignment").Result;

            // If the response is sucess
            if (response.IsSuccessStatusCode)
            {
                // get a list with StoreItem Class
                var storeItems = response.Content.ReadAsAsync<IEnumerable<StoreItem>>().Result; 
                return storeItems.ToList();

            }

            return null;
        }

        // Post
        public void Post(List<StoreItem> list)
        {
            if (list.Count() == 3)
            {
                Response.StatusCode = 200;
                Response.Write("There were more 3 objects in the list of storeItems" + "<br />" + Response.StatusDescription);
                Response.End();
            }
            else
            {
                // if the list does not contain 3 objects, show bad request 400
                Response.StatusCode = 400;
                Response.Write("There were not 3 objects in the list of storeItems" + "<br />" + Response.StatusDescription);
                Response.End();
            }
        }

        // Button1 Click Event
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Call for the Post function
            Post(Get());

        }
    }
}