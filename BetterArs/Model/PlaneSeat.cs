//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterArs.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlaneSeat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlaneSeat()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int Id { get; set; }
        public int PlaneId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public decimal Fare { get; set; }
        public string SeatName { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Plane Plane { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
