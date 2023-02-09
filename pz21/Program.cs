using System;

namespace pz_21
{
    public class DeliveryRequest
    {
        public override string ToString()
        {
            return string.Format($"Уникальный идентификатор: {Id}\nВремя заявки: {RequestTime}\nСумма: {Summ}\nАдрес: {Adr}");
        }
        public int Id { get; set; }
        public string RequestTime { get; set; }
        public int Summ { get; set; }
        public string Adr { get; set; }

        public void GetDeliveryInfo(int id, string requestTime, int summ, string adr)
        {
            Id = id;
            RequestTime = requestTime;
            Summ = summ;
            Adr = adr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DeliveryRequest dr = new DeliveryRequest();
            dr.GetDeliveryInfo(1, "30.07.2022", 2500, "г. Оренбург, Ул. Пушкинская, д. 1");
            Console.WriteLine(dr);
            dr.GetDeliveryInfo(2, "26.05.2023", 5000, "г. Оренбург, Ул. Новосёлов, д. 12");
            Console.WriteLine(dr);
            dr.GetDeliveryInfo(5, "01.01.2022", 100000, "г. Оренбург, Ул. Котова д. 46");
            Console.WriteLine(dr);
        }

    }

}



