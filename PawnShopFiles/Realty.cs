using System;

namespace PawnShopFiles
{
    public class Realty:Property
    {
        private string _address; 
        private string _details;

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string Details
        {
            get => _details;
            set => _details = value;
        }
        
        public Realty(int id, string type, int clientId, int empId,string address,string details,int asValue, int price, DateTime dateOfOffer, int termOfCont) : base (id, type,  clientId, empId, asValue, price, dateOfOffer, termOfCont)
        {
            _address = address;
            _details = details;
        }
    }
}