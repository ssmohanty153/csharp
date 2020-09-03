using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        int _custid;
        string _cname, _state;
        double _balance;
        bool _status;
        citys _city;
      string _country;
        public Customer(int custid,string cname,string state,double balance, bool status, citys city,string country)
        {
            _city = city;
            _cname = cname;
            _custid = custid;
            _balance = balance;
            _state = state;
           _country = country;
            //this.counttry you write you get the out whic is pass by the progrgrammer
            //if on countyr=country the you get india output;

        }
        public int custid
        {
            get
            {
                return _custid;
            }
        }
        public string cname
        {
            get
            {
                return _cname;
            }
            set
            {
                if (_status == true)
                _cname = value;
            }  
        }
        public bool status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        public double balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if(_status==true)
                {
                    if (value >= 500)
                       _balance = value;
                }
            }
        }
        public citys city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public String state
        {
            get
            {
                return _state;
            }
            protected set
            {
                if (_status == true)
                    _state = value;
            }
        }
        public string country
        {
            get;
            set;
           
        }


    }
}
