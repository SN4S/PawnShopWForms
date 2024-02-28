using System;

namespace PawnShopFiles
{
    public class Employee:Human, IStringTampering
    {
        private int _id;
        private string _phone;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        public Employee(int id,string fname,string sname, string phone) : base (fname,sname)
        {
            _id = id;
            _phone = phone;
        }

        ~Employee()
        {
            Console.WriteLine("Destructor");
        }
        public override string ToString()
        {
            return $"{Id}#{Fname}#{Sname}#{Phone}";
        }
    }
}