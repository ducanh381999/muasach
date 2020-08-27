using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Products
    {
        private int Id;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string Title;

        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        private string Description;

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        private float Money;

        public float money
        {
            get { return Money; }
            set { Money = value; }
        }
        private int Quantity;

        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        private string Photo;

        public string photo
        {
            get { return Photo; }
            set { Photo = value; }
        }
        private int CategoryId;

        public int categoryid
        {
            get { return CategoryId; }
            set { CategoryId = value; }
        }

    }
}
