using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_assignmentt
{
    internal class Dessert
    {
        private string _menu;
        private string _price;
        private string _qty;
        private string _total;

        //constructor
        public Dessert(string menu, string price, string qty, string total)
        {
            this._menu = menu;
            this._price = price;
            this._qty = qty;
            this._total = total;

        }

        //encapsualtion
        public string getMenu()
        {
            return this._menu;
        }
        public string getPrice()
        {
            return this._price;
        }
        public string getQty()
        {
            return this._qty;
        }
        public string gettotal()
        {
            return this._total;
        }
    }
}
