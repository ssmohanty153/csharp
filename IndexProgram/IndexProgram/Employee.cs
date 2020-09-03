using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexProgram
{
    class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;

        public Employee(int Eno,double Salary,string Ename,string Job,string Dname,string Location)
        {
            this.Ename = Ename;
            this.Salary = Salary;
            this.Ename = Ename;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
        }
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return Eno;
                else if (index == 2)
                    return Salary;
                else if(index == 3)
                    return Ename;
                else if (index == 4)
                    return Job;
                else if (index == 5)
                    return Dname;
                else if (index == 6)
                    return Location;

                return null;
            }
            set
            {
                if (index == 1)
                    Eno = (int)value;
                else if (index == 2)
                    Salary = (double)value;
                else if (index == 3)
                    Ename = (string)value;
                else if (index == 4)
                    Job = (string)value;
                else if (index == 5)
                    Dname = (string)value;
                else if (index == 6)
                    Location = (string)value;
              
            }
        }
        public object this[string name]
        {
            get
            {
                if (name.ToLower() == "eno")
                    return Eno;
                else if (name.ToLower() == "salary")
                    return Salary;
                else if (name.ToLower() == "ename")
                    return Ename;
                else if (name.ToLower() == "job")
                    return Job;
                else if (name.ToLower() == "dname")
                    return Dname;
                else if (name.ToLower() == "location")
                    return Location;

                return null;
            }
            set
            {
                if (name.ToLower() == "eno")
                    Eno = (int)value;
                else if (name.ToLower() == "salary")
                    Salary = (double)value;
                else if (name.ToLower() == "ename")
                    Ename = (string)value;
                else if (name.ToLower() == "job")
                    Job = (string)value;
                else if (name.ToLower() == "dname")
                    Dname = (string)value;
                else if (name.ToLower() == "location")
                    Location = (string)value;

            }
        }

    }
}
