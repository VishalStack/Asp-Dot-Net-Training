using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapi22march.Models;

using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Webapi22march.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public ItemController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        [HttpGet]
        [Route("GetItems")]
        public List<ItemModel> GetItems()
        {
            //return LoadList();

            return LoadListFromDB();
        }


        [HttpGet]
        [Route("GetItemById")]
        public List<ItemModel> GetItemById(string ItemId)
        {
            // return LoadList().Where(e=>e.ItemCode == ItemId).ToList();
            return LoadListFromDB().Where(e => e.ItemCode == ItemId).ToList();
        }


        [HttpPost]
        [Route("InsertItem")]
        public string InsertItem(ItemModel obj)
        {
            //List<ItemModel> lstmain = new List<ItemModel>();
            //lstmain.Add(obj);
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConn"));
            SqlCommand cmd = new SqlCommand("Insert into Item Values('"+ obj.ItemCode +"' , '"+ obj.ItemName +"' , '"+ obj.Price +"')" , con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Item Added Successfully";
        }



        [HttpDelete]
        [Route("DeleteItem")]
        public string DeleteItem(string ItemID)
        {
            
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConn"));
            SqlCommand cmd = new SqlCommand("Delete from Item Where ItemCode ='"+ ItemID +"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Item Delete Successfully";
        }


        [HttpPut]
        [Route("EditItem")]
        public string EditItem(string ItemID , ItemModel obj)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConn"));
            SqlCommand cmd = new SqlCommand("Upadate Item set(ItemCode,  ItemName, Price )Where ItemCode ='" + ItemID + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Item Upadated Successfully";
        }

        private List<ItemModel> LoadListFromDB()
        {
            List<ItemModel> lstmain = new List<ItemModel>();

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConn"));
            SqlCommand cmd = new SqlCommand("Select * from Item ", con );
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ItemModel obj = new ItemModel();
                obj.ItemCode = dt.Rows[i]["ItemCode"].ToString();
                obj.ItemName = dt.Rows[i]["ItemName"].ToString();
                obj.Price = decimal.Parse(dt.Rows[i]["Price"].ToString());
                lstmain.Add(obj);

            }
            return lstmain;
        }


            private List<ItemModel> LoadList()
        {
            List<ItemModel> lstmain = new List<ItemModel>();

            ItemModel obj = new ItemModel();
            obj.ItemCode = "1";
            obj.ItemName = "Lenovo";
            obj.Price = 50000;
            lstmain.Add(obj);


            obj = new ItemModel();
            obj.ItemCode = "2";
            obj.ItemName = "Lenovo Keyboard";
            obj.Price = 1000;
            lstmain.Add(obj);

            obj = new ItemModel();
            obj.ItemCode = "3";
            obj.ItemName = "Lenovo Mouse";
            obj.Price = 1000;
            lstmain.Add(obj);

            obj = new ItemModel();
            obj.ItemCode = "4";
            obj.ItemName = "Dell Laptop";
            obj.Price = 80000;
            lstmain.Add(obj);

            obj = new ItemModel();
            obj.ItemCode = "5";
            obj.ItemName = "Dell Keyboard";
            obj.Price = 3000;
            lstmain.Add(obj);

           return lstmain;
        }


    }
}
