using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models.ForCart
{
    public class Cart
    {
        public List<CartLine> _cardLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }
        public void AddProduct(Books books, int quantiy)
        {
            var line = _cardLines.FirstOrDefault(i => i.Books.ID == books.ID);
            if (line == null)
            {
                _cardLines.Add(new CartLine() { Books = books, Quantity = quantiy });
            }
            else
            {
                line.Quantity += quantiy;
            }
        }
        public void DeleteProduct(Books books)
        {
            _cardLines.RemoveAll(i => i.Books.ID == books.ID);
        }
        public double Total()
        {
            return _cardLines.Sum(i => i.Books.PresentPrice * i.Quantity);
        }
        public void Clear()
        {
            _cardLines.Clear();
        }
    }
    public class CartLine
    {
        public Books Books { get; set; }
        public int Quantity { get; set; }
    }
}
