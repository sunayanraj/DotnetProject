using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //for properties episode. Can use get set without using public modifier
    public class Customer
    {
        int _Custid;
        bool _Status;
        string _Cname, _City;
        double _Balance;

        public Customer(int Custid, bool Status, string Cname, double Balance, string city)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _City = City;
            _Balance = Balance;
            City = city;
        }
        public int Custid
        {
            get { return _Custid; } // we can only read using the get property....
          //set { _Custid = value; } // we can write using the set property or change the value in TestCustomer....
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string Cname
        {
            get { return _Cname; }
            set {
                if (_Status == true)//we can add condition
                    _Cname = value; 
            }
        }

        public double Balance
        {
            get { return _Balance; }
            set { 
                if(_Status == true)
                {
                    if(value >= 500)
                    _Balance = value;
                }    
                
            }
        }

        public string City
        {
            get { return _City; }
            set
            {
                if(value == "Kathmandu" || value == "Lalitpur" || value == "Pokhara")
                {
                    _City = value;
                }
            }
        }
    }
}
