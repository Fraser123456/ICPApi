

using ICP.Models.DTO.ImageDto;
using System.Collections.Generic;

namespace ICP.Models.DTO.ProductDto
{
    public class AddProductDto
    {
        public string name { get; set; }
        public string description { get; set; }
        public List<AddImageDto> Images { get; set; }
    }
}
