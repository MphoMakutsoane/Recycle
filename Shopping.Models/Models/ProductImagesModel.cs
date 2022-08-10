using System;
using System.Collections.Generic;
using System.Text;

namespace Recycle.Models.Models
{
    public class ProductImagesModel: BaseModel
    {
        public long ProductId { get; set; }
        public string Image { get; set; }
    }
}
