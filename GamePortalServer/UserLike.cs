//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamePortal
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLike
    {
        public string Login { get; set; }
        public string LikeLogin { get; set; }
        public bool IsLike { get; set; }
        public System.DateTimeOffset Date { get; set; }
    
        public virtual User User { get; set; }
    }
}
