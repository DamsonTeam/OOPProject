
using Classes;
using Classes.Interfaces;

namespace Classes
{
  public class DJ : AnimationStaff, IRequiredStaff
    {
      //constructor
      public DJ (string name, Event eventToJoinn, decimal cost)
      {
          this.Name = name;
          this.EventToJoin = eventToJoinn;
          this.Cost = cost;
      }

      public override bool IsRequired()
      {
          return base.IsRequiredStaff;
      }

    }
}
