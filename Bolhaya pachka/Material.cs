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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.IO;

    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.productions = new HashSet<production>();
            this.Suppliers1 = new HashSet<Supplier>();
        }

        public int Id_material { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public byte[] image { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public int min_quantity { get; set; }
        public int quantity_in_pack { get; set; }
        public string unit { get; set; }
        public string suppliers { get; set; }
        public string description { get; set; }


        
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<production> productions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier> Suppliers1 { get; set; }
    }
}
