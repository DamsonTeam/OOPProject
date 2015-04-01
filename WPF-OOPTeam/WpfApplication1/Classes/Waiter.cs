using Classes;
using Classes.Interfaces;

namespace Classes
{
    public class Waiter : RestaurantStaff, IRequiredStaff
    {
        //constructor
        public Waiter(string name, Event eventToJoinn, decimal cost, bool isRequired)
        {
            this.Name = name;
            this.EventToJoin = eventToJoinn;
            this.Cost = cost;
            this.IsRequiredStaff = isRequired;

        }

        public override bool IsRequired()
        {
            return base.IsRequiredStaff;
        }

    }
}
