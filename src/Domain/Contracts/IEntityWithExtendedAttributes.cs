using System.Collections.Generic;

namespace GLifeInc.Domain.Contracts
{
    public interface IEntityWithExtendedAttributes<TExtendedAttribute>
    {
        public ICollection<TExtendedAttribute> ExtendedAttributes { get; set; }
    }
}