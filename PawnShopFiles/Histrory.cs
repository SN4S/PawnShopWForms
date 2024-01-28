using System.Net.NetworkInformation;

namespace PawnShopFiles
{
    public class Histrory
    {
        private int _id;
        private string _type_of_operation;
        private string _client_info;
        private string _emp_info;
        private string _pawn_info;
        private int _as_value;
        private int _price;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string TypeOfOperation
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
        
        public Histrory(int id, string typeOfOperation, string clientInfo, string empInfo, string pawnInfo,int asValue, int price)
        {
            _id = id;
            _type_of_operation = typeOfOperation;
            _client_info = clientInfo;
            _emp_info = empInfo;
            _pawn_info = pawnInfo;
            _as_value = asValue;
            _price = price;
        }
        
        public override string ToString()
        {
            return $"{Id}#{TypeOfOperation}#{ClientInfo}#{EmpInfo}#{PawnInfo}#{AsValue}#{Price}";
        }
    }
}