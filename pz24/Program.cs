namespace pz24
{
    using System;

    public class DeliveryRequest : ICloneable
    {
        public int Id { get; set; }
        public string RequestTime { get; set; }
        public int Summ { get; set; }
        public string Adr { get; set; }
        public string Reason { get; set; }
        public bool Correct { get; set; }

        public DeliveryRequest()
        {
            Reason = "отсутствует";
        }

        public void GetDeliveryInfo(int id, string requestTime, int summ, string adr)
        {
            Reason = "отсутствует";
            string[] date = requestTime.Split('.');
            int day = Convert.ToInt32(date[0]);
            int month = Convert.ToInt32(date[1]);
            int year = Convert.ToInt32(date[2]);
            if ((summ >= 1000 && summ <= 10000) && (id != 0) && (day >= 1 && day <= 30) && (month >= 1 && month <= 12) && (year >= 2022 && year <= 2023))
            {
                Id = id;
                RequestTime = requestTime;
                Summ = summ;
                Adr = adr;
                Correct = true;
            }
            else
            {
                Correct = false;
                Reason = "Ошибка в данных.";
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            if (Correct)
            {
                return string.Format($"Уникальный идентификатор: {Id}\nВремя заявки: {RequestTime}\nСумма: {Summ}\nАдрес: {Adr}\nОшибка: {Reason}");
            }
            else
            {
                return string.Format(Reason);
            }
        }
    }

    class RejectedDelivery : DeliveryRequest, ICloneable
    {
        public new string Reason { get; set; }

        public void GetDeliveryInfo(int id, string requestTime, int summ, string adr, string reason)
        {
            string[] date = requestTime.Split('.');
            int day = Convert.ToInt32(date[0]);
            int month = Convert.ToInt32(date[1]);
            int year = Convert.ToInt32(date[2]);
            if ((summ >= 1000 && summ <= 10000) && (id != 0) && (day >= 1 && day <= 30) && (month >= 1 && month <= 12) && (year >= 2022 && year <= 2023))
            {
                Id = id;
                RequestTime = requestTime;
                Summ = summ;
                Adr = adr;
                Correct = true;
                Reason = reason;
            }
            else
            {
                Correct = false;
            }
        }

        public new object Clone()
        {
            return MemberwiseClone();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RejectedDelivery rd = new RejectedDelivery();
            rd.GetDeliveryInfo(1, "30.07.2022", 2500, "г. Оренбург, Ул. Пушкинская, д. 1", "Причина отклонения");
            Console.WriteLine(rd);
            DeliveryRequest clonedRequest = (DeliveryRequest)rd.Clone();
            Console.WriteLine("Клонированный объект:");
            Console.WriteLine(clonedRequest);
        }
    }
}
