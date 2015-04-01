

namespace Classes
{
    using Classes;
    using Classes.Interfaces;

   public abstract class AnimationStaff : EventStaff, IRequiredStaff
    {
        protected bool IsRequiredStaff = false;

        public virtual bool IsRequired()
        {
            return IsRequiredStaff;
        }
    }
}
