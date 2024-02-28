using System;

namespace PawnShopFiles
{
    public class Property : IStringTampering
    {
        private int _id;
        private Client _client;
        private Employee _emp;
        private string _detail;
        private int _as_value;
        private int _price;
        private DateTime _date_of_offer;
        private int _term_of_cont;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public Client Client
        {
            get => _client;
            set => _client = value;
        }

        public Employee Emp
        {
            get => _emp;
            set => _emp = value;
        }

        public string Detail
        {
            get => _detail;
            set => _detail = value;
        }

        public int AsValue
        {
            get => _as_value;
            set => _as_value=value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public DateTime DateOfOffer
        {
            get => _date_of_offer;
            set => _date_of_offer = value;
        }

        public int TermOfCont
        {
            get => _term_of_cont;
            set => _term_of_cont = value;
        }
        
        public Property(int id, Client client, Employee emp,string detail, int asValue, int price, DateTime dateOfOffer, int termOfCont)
        {
            _id = id;
            _client = client;
            _emp = emp;
            _detail = detail;
            _price = price;
            _date_of_offer = dateOfOffer;
            _term_of_cont = termOfCont;
            _as_value = asValue;
        }

        ~Property()
        {
            Console.WriteLine("Destructor");
        }
        
        public override string ToString()
        {
            return $"{Id}#{Client.Id}#{Emp.Id}#{Detail}#{AsValue}#{Price}#{DateOfOffer}#{TermOfCont}";
        }
    }
}