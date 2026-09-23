namespace DeliveryApp
{
    public class ContactPerson : Model
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Ім'я: {Name} | Телефон: {Phone} | Email: {Email}";
        }
    }
}
