//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raid
    {
        public int Step { get; set; }
        public System.Guid Game { get; set; }
        public Nullable<System.Guid> TargetOrder { get; set; }
        public System.Guid SourceOrder { get; set; }
    
        public virtual Step Step1 { get; set; }
    }
}
