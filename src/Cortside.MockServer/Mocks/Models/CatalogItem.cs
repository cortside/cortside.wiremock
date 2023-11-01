using System;

namespace Cortside.MockServer.Mocks.Models {
    public class CatalogItem {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
