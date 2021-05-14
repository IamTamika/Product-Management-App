using System;

namespace ProductMaintenance.Model
{
    partial class Products
    {
        public Products(string productCode, string name, decimal version, DateTime releaseDate)
        {
            this.ProductCode = productCode;
            this.Name = name;
            this.Version = version;
            this.ReleaseDate = releaseDate;
        }
    }
}