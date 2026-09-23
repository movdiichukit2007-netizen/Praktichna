namespace DeliveryApp
{
    public class Posting : Model
    {
        public string TrackingNumber { get; set; }
        public double Weight { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Трек: {TrackingNumber} | Вага: {Weight} кг | Звідки: {SenderAddress} | Куди: {ReceiverAddress} | Статус: {Status}";
        }
    }
}
