using System;

namespace PawnShopFiles
{
    public class Client:Human, IStringTampering
    {
        private int _id;
        private string _phone;
        private string _address;

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

        public string Address
        {
            get => _address;
            set => _address = value;
        }
        public Client(int id,string fname,string sname, string phone, string address) : base (fname,sname)
        {
            _id = id;
            _phone = phone;
            _address = address;
        }
        
        ~Client(){
            Console.WriteLine("Destructor");
        }
        
        public override string ToString()
        {
            return $"{Id}#{Fname}#{Sname}#{Phone}#{Address}";
        }
    }
}