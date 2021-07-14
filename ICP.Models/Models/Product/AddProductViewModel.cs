using ICP.Models.DTO.ImageDto;
using System.Collections.Generic;

namespace ICP.Models.Models.Product
{
    public class AddProductViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<AddImageDto> Images { get; set; }
    }
}
