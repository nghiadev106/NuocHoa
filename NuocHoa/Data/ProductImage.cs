﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NuocHoa.Data
{
    public partial class ProductImage
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public string Path { get; set; }

        public virtual Product Product { get; set; }
    }
}