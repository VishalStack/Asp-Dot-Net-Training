using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi_CRUD.DataModels;

namespace webApi_CRUD.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("GetMembersEF")]

        public List<TblMember> GetMembersEF()
        {
            EmployeeContext ec = new EmployeeContext();

            return ec.TblMembers.ToList();
        }

        [HttpGet]
        [Route("GetMembersByIdEF")]

        public List<TblMember> GetMembersByIdEF(int bid)
        {
            EmployeeContext ec = new EmployeeContext();

            return ec.TblMembers.Where(e => e.MemberId == bid).ToList();
            
        }

        [HttpPost]
        [Route("InsertMembersEF")]
        public string InsertMembersEF(TblMember obj)
        {

            EmployeeContext ec = new EmployeeContext();
            ec.TblMembers.Add(obj);
            ec.SaveChanges();
            return "Item added successfully..";
        }

        [HttpDelete]
        [Route("DeleteMembersEF")]
        public string DeleteMembersEF(int id)
        {
            if (id <= 0)
                return "Not a valid student id";

            EmployeeContext ec = new EmployeeContext();
            //var book = ec.Bookdetails
            //    .Where(s => s.BookId == id)
            //    .FirstOrDefault();
            //ec.Entry(book).State = (Microsoft.EntityFrameworkCore.EntityState)System.Data.Entity.EntityState.Deleted;

            //ec.SaveChanges();
            var data = ec.TblMembers.FirstOrDefault(x => x.MemberId == id);
            if (data != null)
            {
                ec.TblMembers.Remove(data);
                ec.SaveChanges();
                return "Item deleted successfully..";
            }
            else
                return "ERROR!!!!! Try Again...";


        }

        //[HttpPut]
        //[Route("UpdateBooksEF")]
        //public string UpdateBooksEF(int id,Bookdetail obj)
        //{

        //    if (!ModelState.IsValid)
        //        return"Not a valid model";

        //    EmployeeContext ec = new EmployeeContext();
        //    // var existingbook = ec.Bookdetails.Where(s => s.BookId == id).FirstOrDefault<Bookdetail>();
        //    var existingbook = ec.Bookdetails.Find(id);
        //        if (existingbook != null)
        //        {
        //            existingbook.BookName = obj.BookName;
        //            existingbook.AuthorName = obj.AuthorName;
        //            existingbook.BookDescription = obj.BookDescription;
        //            ec.SaveChanges();
        //            //ec.Entry(existingbook).State = (Microsoft.EntityFrameworkCore.EntityState)System.Data.Entity.EntityState.Modified;
        //        return "update successfully";
        //        }
        //        else
        //        {
        //            return "ERROR!!!!! Try Again...";
        //        }

        //}

        [HttpPut]
        [Route("UpdateMembersEF")]
        public void UpdateBooksEF([FromBody] TblMember obj)
        {
            EmployeeContext ec = new EmployeeContext();
            ec.TblMembers.Update(obj);
            ec.SaveChanges();
        }



    }
}
