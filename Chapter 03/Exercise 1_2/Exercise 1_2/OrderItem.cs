﻿namespace OrderManageSystem
{
    public class OrderItem
    {
        public string Pname { get; set; }   //商品名
        public int Pnum { get; set; }   //商品数量

        Goods goods = new Goods();
        public override bool Equals(object obj)
        {
            if (obj is OrderItem o)
            {
                return Pname == o.Pname;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Pname.GetHashCode();
        }

        public override string ToString()
        {
            double Price = goods.GetPrice(Pname) * Pnum;
            return $"商品：{Pname} 数量：{Pnum} 价格：{Price}";
        }
    }
}
