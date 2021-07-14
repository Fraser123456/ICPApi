using ICP.Models.Collections;
using ICP.Models.DTO.ProductDto;

namespace ICP.Business.Managers.Abstract
{
    public interface IProductService
    {
        t_product AddProduct(AddProductDto product);
    }
}
