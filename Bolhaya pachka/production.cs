//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bolhaya_pachka
{
    using System;
    using System.Collections.Generic;
    
    public partial class production
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public production()
        {
            this.Materials = new HashSet<Material>();
            this.Products = new HashSet<Product>();
            this.Workers = new HashSet<Worker>();
        }
    
        public int id_production { get; set; }
        public System.TimeSpan time { get; set; }
        public decimal cost_price { get; set; }
        public int namber_workshop { get; set; }
        public int minimum_workers { get; set; }
        public string required_materials { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Materials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Worker> Workers { get; set; }
    }
}