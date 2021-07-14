using Microsoft.AspNetCore.Http;
using System;

namespace ICP.Models.DTO.ImageDto
{
    public class AddImageDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string PublicId { get; set; }
    }
}
