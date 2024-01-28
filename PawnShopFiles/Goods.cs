using System;

namespace PawnShopFiles
{
    public class Goods : Property
    {
        private string _goods_info;

        public Goods(int id, string type, int clientId, int empId, int asValue, int price, DateTime dateOfOffer, int termOfCont,string goodsInfo) : base(id, type, clientId, empId, asValue, price, dateOfOffer, termOfCont)
        {
            _goods_info = goodsInfo;
        }
    }
}