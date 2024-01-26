namespace PawnShopFiles
{
    public class Client:Human
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
        public Client(int id,string fname,string sname, string phone) : base (fname,sname)
        {
            _id = id;
            _phone = phone;
        }
    }
}