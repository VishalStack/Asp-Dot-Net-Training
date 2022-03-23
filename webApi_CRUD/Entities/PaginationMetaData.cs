using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi_CRUD.Entities
{
    public class PaginationMetaData
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalCount { get; private set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        public PaginationMetaData(int totalcount, int currentpage, int itemsperpage)
        {
            TotalCount = totalcount;
            CurrentPage = currentpage;
            TotalPages = (int)Math.Ceiling(totalcount / (double)itemsperpage);
          
        }
       
    }
}
