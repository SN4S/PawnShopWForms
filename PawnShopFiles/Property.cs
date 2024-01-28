using System;

namespace PawnShopFiles
{
    public class Property
    {
        protected int _id;
        protected string _type;
        protected int _client_id;
        protected int _emp_id;
        protected int _as_value;
        protected int _price;
        protected DateTime _date_of_offer;
        protected int _term_of_cont;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public int ClientId
        {
            get => _client_id;
            set => _client_id = value;
        }

        public int EmpId
        {
            get => _emp_id;
            set => _emp_id = value;
        }

        public int Price
        {
            get => _price;
            set => _price=value;
        }
        
        public Property(int id, string type, int clientId, int empId, int asValue, int price, DateTime dateOfOffer, int termOfCont)
        {
            _id = id;
            _type = type;
            _client_id = clientId;
            _emp_id = empId;
            _price = price;
            _date_of_offer = dateOfOffer;
            _term_of_cont = termOfCont;
            _as_value = asValue;
        }
    }
}