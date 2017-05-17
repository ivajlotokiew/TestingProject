namespace Cars.Models
{
    using System.Collections.Generic;

    public class User
    {
        private ICollection<Car> cars;

        public User()
        {
            this.cars = new HashSet<Car>();
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}