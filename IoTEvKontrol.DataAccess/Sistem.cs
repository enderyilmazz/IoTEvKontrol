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
    
    public partial class Sistem
    {
        public int ID { get; set; }
        public Nullable<int> KullaniciID { get; set; }
        public Nullable<int> OdaID { get; set; }
        public Nullable<int> CihazID { get; set; }
        public string IslemTipi { get; set; }
        public string Tarih { get; set; }
        public string Veri { get; set; }
        public string Durum { get; set; }
    
        public virtual Cihazlar Cihazlar { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
        public virtual Oda Oda { get; set; }
    }
}