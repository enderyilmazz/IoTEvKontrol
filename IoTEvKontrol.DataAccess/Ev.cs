//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IoTEvKontrol.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ev
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ev()
        {
            this.Oda = new HashSet<Oda>();
        }
    
        public int ID { get; set; }
        public string EvAdi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oda> Oda { get; set; }
    }
}
