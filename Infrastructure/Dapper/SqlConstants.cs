namespace Infrastructure.Dapper;

public static class SqlConstants
{
    public static class ProductSql
    {
        //Create
        public const string CreateProduct = "INSERT INTO Products (ProductName, Category, UnitPrice, DateAdded) VALUES (@ProductName, @Category, @UnitPrice, @DateAdded); SELECT CAST(SCOPE_IDENTITY() as int);";

        //Read
        public const string GetProductById = "SELECT * FROM Products WHERE Id = @Id";

        public const string GetAllProducts = "SELECT * FROM Products";

        //Update
        public const string UpdateProduct = "UPDATE Products SET ProductName = @ProductName, Category = @Category, UnitPrice = @UnitPrice, DateAdded = @DateAdded WHERE Id = @Id";

        //Delete
        public const string DeleteProduct = "DELETE FROM Products WHERE Id = @Id";
    }
}
