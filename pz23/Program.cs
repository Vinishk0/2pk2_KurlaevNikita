namespace pz23
{
    public class DeliveryRequest
    {
        public bool correct;
        public override string ToString()
        {

            if (correct)
            {
                return string.Format($"Уникальный идентификатор: {Id}\nВремя заявки: {RequestTime}\nСумма: {Summ}\nАдрес: {Adr}\nОшибка: {Reason}");
            }
            else
            {
                return string.Format(Reason);
            }

        }
        public int Id { get; set; }
        public string RequestTime { get; set; }
        public int Summ { get; set; }
        public string Adr { get; set; }
        public string Reason { get; set; }

        public void GetDeliveryInfo(int id, string requestTime, int summ, string adr)
        {
            Reason = "отсутствует";
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
                Reason = "Ошибка в данных.";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RejectedDelivery rd = new RejectedDelivery();
            rd.GetDeliveryInfo(1, "30.07.2022", 2500, "г. Оренбург, Ул. Пушкинская, д. 1");
            Console.WriteLine(rd);
            rd.GetDeliveryInfo(2, "26.05.2023", 5000, "г. Оренбург, Ул. Новосёлов, д. 12");
            Console.WriteLine(rd);
            rd.GetDeliveryInfo(5, "01.01.2022", 100000, "г. Оренбург, Ул. Котова д. 46");
            Console.WriteLine(rd);
        }

    }

    class RejectedDelivery : DeliveryRequest
    {
        public string Reason { get; set; }

        public void GetDeliveryInfo(int id, string requestTime, int summ, string adr, string reason)
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
                Reason = reason;

            }
            else
            {
                correct = false;
            }
        }
    }

}



