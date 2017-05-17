namespace Cars.Models
{
    using System.Collections.Generic;

    public class Car
    {
        private ICollection<User> owners;

        public Car()
        {
            this.owners = new HashSet<User>();
        }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<User> Owners { get; set; }
    }
}