using System;

namespace pz_22
{
    public class DeliveryRequest
    {
        public bool correct;
        public override string ToString()
        {
            if (correct)
            {
                return string.Format($"Уникальный идентификатор: {Id}\nВремя заявки: {RequestTime}\nСумма: {Summ}\nАдрес: {Adr}");
            }
            else
            {
                return string.Format($"Ошибка");
            }

        }
        public int Id { get; set; }
        public string RequestTime { get; set; }
        public int Summ { get; set; }
        public string Adr { get; set; }

        public void GetDeliveryInfo(int id, string requestTime, int summ, string adr)
        {
            string[] date = requestTime.Split('.');
            int day = Convert.ToInt32(date[0]);
            int month = Convert.ToInt32(date[1]);
            int year = Convert.ToInt32(date[2]);
            if ((summ >= 1000 && summ <= 10000) && (id != null) && (day >= 1 && day <= 30) && (month >= 1 && month <= 12) && (year >= 2022 && year <= 2023))
            {
                Id = id;
                RequestTime = requestTime;
                Summ = summ;
                Adr = adr;
                correct = true;

            }
            else
            {
                correct = false;
            }
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



