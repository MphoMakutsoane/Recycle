using Recycle.Models.Enums;
using Recycle.Models.Models;
using Recycle.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Recycle.Services
{
    public class ProductsService : IProductsService
    {
        /// <summary>
        /// Gets the available products list by category name.
        /// </summary>
        /// <param name="categoryName">The target category Name</param>
        /// <returns>The found prodycts.</returns>
        public IEnumerable<ProductModel> GetProductsByGategoryName(string categoryName)
        {
            ProductsEnum productCategory;
            List<ProductModel> mockList = new List<ProductModel>
            {
                new ProductModel{ID = 1, Category = ProductsEnum.Glasses, Name = "All sort of glasses ", Price = 30, Thumbnail = "http://hwestequipment.com/wp-content/uploads/2019/02/Things-Made-from-Recycled-Glass.jpg" },
                new ProductModel{ID = 2, Category = ProductsEnum.Glasses, Name = "We take diffrent glasses", Price = 30, Thumbnail = "https://www.minneapolismn.gov/media/-www-content-assets/images/hennepin_glass_72DPI.jpg" },
                new ProductModel{ID = 3, Category = ProductsEnum.Plastics, Name = "all sorts of plastics", Price = 20, Thumbnail = "https://cordis.europa.eu/docs/news/images/2019-11/411547.jpg" },
                new ProductModel{ID = 4, Category = ProductsEnum.Plastics, Name = "Dont throw me, Recycle", Price = 20, Thumbnail = "https://journals.openedition.org/factsreports/docannexe/image/5191/img-1-small580.jpg" },
                new ProductModel{ID = 5, Category = ProductsEnum.Metals, Name = "This type of metals metals recyclable", Price = 50, Thumbnail = "https://recyclecoach.com/wp-content/uploads/2021/04/how-to-recycle-tin-cans.png" },
                new ProductModel{ID = 6, Category = ProductsEnum.Metals, Name = "Cans also recyclable", Price = 50, Thumbnail = "https://langleyrecyclingkc.b-cdn.net/wp-content/uploads/2021/04/scrap-8-rusted-rims-1024x682.jpg" },
            };

            productCategory = (ProductsEnum)Enum.Parse(typeof(ProductsEnum), categoryName);
            return mockList.Where(x => x.Category == productCategory);
        }

        /// <summary>
        /// Gets product images by the product ID.
        /// </summary>
        /// <param name="productId">The target product ID.</param>
        /// <returns>The method returns thhe found list of products.</returns>
        public IEnumerable<string> GetProductsImages(long productId)
        {
            List<ProductImagesModel> images = new List<ProductImagesModel>
            {
                new ProductImagesModel{ID = 1, ProductId = 1, Image="http://hwestequipment.com/wp-content/uploads/2019/02/Things-Made-from-Recycled-Glass.jpg"},
                new ProductImagesModel{ID = 2, ProductId = 1, Image="https://www.minneapolismn.gov/media/-www-content-assets/images/hennepin_glass_72DPI.jpg"},
                new ProductImagesModel{ID = 3, ProductId = 1, Image="https://www.gannett-cdn.com/presto/2021/02/23/PLAL/de84b3d6-dc12-479d-8b7c-e91f1483dce2-BackYard.Sapphire.Glass.Recycling-0006780.jpg"},

                new ProductImagesModel{ID = 4, ProductId = 2, Image="https://cordis.europa.eu/docs/news/images/2019-11/411547.jpg"},
                new ProductImagesModel{ID = 5, ProductId = 2, Image="https://journals.openedition.org/factsreports/docannexe/image/5191/img-1-small580.jpg"},
                new ProductImagesModel{ID = 6, ProductId = 2, Image="https://www.compactor-runi.com/app/webroot/_resized/uploads/Kategorier/PET%20flasker-b0af9eb32e5df4c25936b663d50b6c45.jpg"},

                new ProductImagesModel{ID = 7, ProductId = 3, Image="https://journals.openedition.org/factsreports/docannexe/image/5191/img-1-small580.jpg"},
                new ProductImagesModel{ID = 8, ProductId = 3, Image="https://journals.openedition.org/factsreports/docannexe/image/5191/img-1-small580.jpg"},
                new ProductImagesModel{ID = 9, ProductId = 3, Image="https://journals.openedition.org/factsreports/docannexe/image/5191/img-1-small580.jpg"},

                new ProductImagesModel{ID = 10, ProductId = 4, Image="https://cordis.europa.eu/docs/news/images/2019-11/411547.jpg"},
                new ProductImagesModel{ID = 11, ProductId = 4, Image="https://cordis.europa.eu/docs/news/images/2019-11/411547.jpg"},
                new ProductImagesModel{ID = 12, ProductId = 4, Image="https://cordis.europa.eu/docs/news/images/2019-11/411547.jpg"},

                new ProductImagesModel{ID = 13, ProductId = 4, Image="https://encorerecyclers.com/wp-content/uploads/2017/07/how-to-identify-steel-scrap-metal-recycling-dallas.jpg"},
                new ProductImagesModel{ID = 14, ProductId = 4, Image="https://encorerecyclers.com/wp-content/uploads/2017/07/how-to-identify-steel-scrap-metal-recycling-dallas.jpg"},

                new ProductImagesModel{ID = 15, ProductId = 5, Image="https://everydayrecycler.com/wp-content/uploads/2020/07/Depositphotos_40012335_xl-2015_optimized.jpg"},
                new ProductImagesModel{ID = 16, ProductId = 5, Image="https://mgmmetals.co.za/wp-content/uploads/2019/05/MGM-Recycling-Scrap-Metal-Metals.jpg"},
                new ProductImagesModel{ID = 17, ProductId = 5, Image="https://www.metalicobuffalo.com/content/images/copper-plumbing-fixtures.jpg"},

                new ProductImagesModel{ID = 18, ProductId = 6, Image="https://www.metalicobuffalo.com/content/images/copper-plumbing-fixtures.jpg"},
                new ProductImagesModel{ID = 19, ProductId = 6, Image="https://cm-today.com/uploads/docs/aluminium.jpg"},
                new ProductImagesModel{ID = 20, ProductId = 6, Image="https://www.hcienv.com/images/uploaded/scrp-metal1.jpeg"}
            };

            return images.Where(x => x.ProductId == productId).Select(x=>x.Image);
        }
    }
}
