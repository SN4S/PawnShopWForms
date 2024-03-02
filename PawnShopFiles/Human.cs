using System;

namespace PawnShopFiles
{
    public class Human
    {
        protected string _fname;
        protected string _sname;

        public string Fname
        {
            get => _fname;
            set => _fname = value;
        }

        public string Sname
        {
            get => _sname;
            set => _sname = value;
        }
        
        public Human(string fname, string sname)
        {
            this._fname = fname;
            this._sname = sname;
        }

        ~Human()
        {
            Console.WriteLine("DEstroy");
        }
    }
}