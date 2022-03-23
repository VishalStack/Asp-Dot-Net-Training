using CoreApiApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CoreApiApp.Controllers
{
    //[Route("api/[controller]")]
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
        [Route("GetItemByID")]
        public List<ItemModel> GetItemByID(string Itemid)
        {
            //return LoadList().Where(e=>e.ItemCode==Itemid).ToList();
            return LoadListFromDB().Where(e => e.ItemCode == Itemid).ToList();
        }

        [HttpPost]
        [Route("AddItem")]
        public string AddItem(ItemModel obj)
        {
            //List<ItemModel> list = new List<ItemModel>();
            //list.Add(Obj);

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("Insert into Item values ('" + obj.ItemCode + "' , '" + obj.ItemName + "' , '" + obj.Price + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Item Added Successfully";
            
        }

        //[HttpPut("UpdateItemByID")]
        //public string UpdateItemByID(int id, [FromBody] ItemModel item)
        //{
        //    Item c = new Item();
        //    c.ItemID = id;
        //    c.ItemCode = item.ItemCode;
        //    c.ItemName = item.ItemName;
        //    c.Price = item.Price;
        //    c.SaveChnages();
        //}


        [HttpDelete]
        [Route("DeleteItem")]
        public string DeleteItem(string ItemID)
        {
            //List<ItemModel> list = new List<ItemModel>();
            //list.Add(Obj);

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("Delete from Item where ItemCode = '"+ItemID+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Item Deleted Successfully";

        }

        private List<ItemModel> LoadListFromDB()
        {
            List<ItemModel> lst = new List<ItemModel>();

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("Select * from Item", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ItemModel obj = new ItemModel();
                obj.ItemCode = dt.Rows[i]["ItemCode"].ToString();
                obj.ItemName = dt.Rows[i]["ItemName"].ToString();
                obj.Price = decimal.Parse(dt.Rows[i]["Price"].ToString());
            lst.Add(obj);
            }
            return lst;
        }

        private List<ItemModel> LoadList()
        {
            List<ItemModel> lst = new List<ItemModel>();

            ItemModel obj = new ItemModel();
            obj.ItemCode = "101";
            obj.ItemName = "Lenovo";
            obj.Price = 1000;
            lst.Add(obj);

            obj = new ItemModel();
            obj.ItemCode = "102";
            obj.ItemName = "Oppo";
            obj.Price = 5000;
            lst.Add(obj);

            obj = new ItemModel();
            obj.ItemCode = "103";
            obj.ItemName = "Vivo";
            obj.Price = 7000;
            lst.Add(obj);

            return lst;
        }
    }
}
