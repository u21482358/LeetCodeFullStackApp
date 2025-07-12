namespace ResturauntViewing.Models.Models
{
    public class Product
    {
        public int Id;
        public double price = 2; // this value if not set is the default value assigned to the Product object.


        public int ID
        {

            get
            {
                return Id;

            }
            set
            {

                Id = value;

            }


        }


        public Product()
        {

        }
    }
}
