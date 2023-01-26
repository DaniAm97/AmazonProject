using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProject
{

    public class Item
    {
        private string title;
        private string price;
        private string url;
        private IWebDriver driver;
        public Item(string title, string price, string url)
        {
            this.title = title;
            this.price = price;
            this.url = url;
        }
        public string Title 
        {
            get { return this.title; }
            set { this.title = value; }
        }   
        public string Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Url
        {
         get { return this.url; }
         set { this.url = value; }
        }
        public string toString()
        {
            return "title: " + this.title + "\nprice: " + this.price + "\n url: " + this.url + "\n";
        }
    }
}
