//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Cargo = new HashSet<Cargo>();
            this.FlightOrder = new HashSet<FlightOrder>();
        }
    
        public int ID { get; set; }
        public int IDCityOut { get; set; }
        public int IDCityInp { get; set; }
        public int IDCustomer { get; set; }
        public Nullable<int> IDRecipient { get; set; }
        public string AddInp { get; set; }
        public string AddrOut { get; set; }
        public System.DateTime DateOrder { get; set; }
        public System.DateTime DateTerm { get; set; }
        public decimal Cost { get; set; }
        public int IDRate { get; set; }
        public int IDStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> Cargo { get; set; }
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightOrder> FlightOrder { get; set; }
        public virtual Rate Rate { get; set; }
        public virtual Recipient Recipient { get; set; }
        public virtual Status Status { get; set; }
    }
}
