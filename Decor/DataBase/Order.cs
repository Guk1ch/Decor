//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Decor.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public Nullable<int> IDBusket { get; set; }
        public Nullable<System.DateTime> DateOrder { get; set; }
        public System.DateTime DateComplite { get; set; }
        public Nullable<int> IDPoint { get; set; }
        public Nullable<int> Code { get; set; }
        public Nullable<int> IDStatus { get; set; }
    
        public virtual Busket Busket { get; set; }
        public virtual Point Point { get; set; }
        public virtual Status Status { get; set; }
    }
}