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
    
    public partial class TerrainType
    {
        public TerrainType()
        {
            this.Terrain = new HashSet<Terrain>();
        }
    
        public string Name { get; set; }
    
        public virtual ICollection<Terrain> Terrain { get; set; }
    }
}