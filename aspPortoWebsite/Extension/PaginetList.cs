using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Extension
{
    public class PaginetList<T>:List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public PaginetList(List<T> items,int count,int pageIndex,int pagesize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pagesize);
            this.AddRange(items);
        }
        public  bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        public bool HasnextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }
        public static async Task<PaginetList<T>> CreateAsync(IQueryable<T> source,int pageindex,int pageSize)
        {
            var count =source.Count();
            var items = source.Skip((pageindex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginetList<T>(items, count, pageindex, pageSize);
        }
    }
}
