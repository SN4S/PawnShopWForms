using System;
using System.Net.NetworkInformation;

namespace PawnShopFiles
{
    public class History : IStringTampering
    {
        private int _id;
        private OperType _type_of_operation;
        private string _client_info;
        private string _emp_info;
        private string _pawn_info;
        private int _as_value;
        private int _price;
        private DateTime _date_of_operation;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public OperType TypeOfOperation
        {
            get => _type_of_operation;
            set => _type_of_operation = value;
        }

        public string ClientInfo
        {
            get => _client_info;
            set => _client_info = value;
        }

        public string EmpInfo
        {
            get => _emp_info;
            set => _emp_info = value;
        }

        public string PawnInfo
        {
            get => _pawn_info;
            set => _pawn_info = value;
        }

        public int AsValue
        {
            get => _as_value;
            set => _as_value = value;
        }
        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public DateTime DateOfOperation
        {
            get => _date_of_operation;
            set => _date_of_operation = value;
        }
        
        public History(int id, string typeOfOperation, string clientInfo, string empInfo, string pawnInfo,int asValue, int price, DateTime dateOfOperation)
        {
            _id = id;
            if (Enum.TryParse(typeOfOperation, out OperType operType))
            {
                _type_of_operation = operType;
            }
            _client_info = clientInfo;
            _emp_info = empInfo;
            _pawn_info = pawnInfo;
            _as_value = asValue;
            _price = price;
            _date_of_operation = dateOfOperation;
        }

        ~History()
        {
            Console.WriteLine("Destructor");
        }
        
        public override string ToString()
        {
            return $"{Id}#{TypeOfOperation}#{ClientInfo}#{EmpInfo}#{PawnInfo}#{AsValue}#{Price}#{DateOfOperation.ToShortDateString()}";
        }
    }
}