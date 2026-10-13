namespace CarRentalApplication.Models
{
    public class Car
    {
        private int id;
        private string name;
        private decimal price;

        public Car(int i, string n, decimal p)
        {
            id = i;
            name = n;
            price = p;
        }
        public Car()
        {

        }
        public int ID
        { 
            get { return id; }
            set { id = value; } 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price 
        {
            get { return price; }
            set {  price = value; }
        }
    }
}
