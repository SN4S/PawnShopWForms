using System.Net.NetworkInformation;

namespace PawnShopFiles
{
    public class Histrory
    {
        private int _id;
        private string _type_of_operation;
        private int _client_id;
        private int _emp_id;
        private string _pawn_info;
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

        public string PawnInfo
        {
            get => _pawn_info;
            set => _pawn_info = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }
        
        public Histrory(int id, string typeOfOperation, int clientId, int empId, string pawnInfo, int price)
        {
            _id = id;
            _type_of_operation = typeOfOperation;
            _client_id = clientId;
            _emp_id = empId;
            _pawn_info = pawnInfo;
            _price = price;
        }
    }
}