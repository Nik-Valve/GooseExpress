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
    
    public partial class CargoValue
    {
        public int ID { get; set; }
        public int IDTypeOfCargo { get; set; }
        public decimal Allowance { get; set; }
    
        public virtual TypeOfCargo TypeOfCargo { get; set; }
    }
}
