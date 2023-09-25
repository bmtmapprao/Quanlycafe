using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycafe.DTO
{
    public class Menu
    {
        public Menu(string foodName, int count, float price, float totalprice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.Totalprive = totalprice;
        }
        public Menu(DataRow row)
        {
            this.FoodName = row["ten"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["gia"].ToString());
            this.Totalprive = (float)Convert.ToDouble(row["totalprice"].ToString());
        }
        private string foodName;
        private int count;
        private float price;
        private float totalprive;

        public float Totalprive
        {
            get { return totalprive; }
            set { totalprive = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
    }
}
