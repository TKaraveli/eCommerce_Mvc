namespace eCommerce_Mvc.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertisement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Picture = c.String(),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cart",
                c => new
                    {
                        CartId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CartId);
            
            CreateTable(
                "dbo.CartLine",
                c => new
                    {
                        CartLineId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Product_ProductId = c.Int(),
                        Cart_CartId = c.Int(),
                    })
                .PrimaryKey(t => t.CartLineId)
                .ForeignKey("dbo.Product", t => t.Product_ProductId)
                .ForeignKey("dbo.Cart", t => t.Cart_CartId)
                .Index(t => t.Product_ProductId)
                .Index(t => t.Cart_CartId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        SupplierId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Double(nullable: false),
                        OldPrice = c.Double(),
                        Discount = c.Decimal(precision: 18, scale: 2),
                        UnitsInStock = c.Int(),
                        WriterId = c.Int(nullable: false),
                        ProductAvailable = c.Boolean(),
                        ImageUrl = c.String(nullable: false, maxLength: 500),
                        ShortDesciription = c.String(maxLength: 300),
                        LongDesciription = c.String(maxLength: 2000),
                        Picture1 = c.String(maxLength: 500),
                        Picture2 = c.String(maxLength: 500),
                        Picture3 = c.String(maxLength: 500),
                        Picture4 = c.String(maxLength: 500),
                        Picture5 = c.String(maxLength: 500),
                        Picture6 = c.String(maxLength: 500),
                        Picture7 = c.String(maxLength: 500),
                        Picture8 = c.String(maxLength: 500),
                        Notes = c.String(maxLength: 250),
                        Pages = c.Int(nullable: false),
                        PublishYear = c.Int(nullable: false),
                        Language = c.String(),
                        OrderDetail_OrderDetailsId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Writer", t => t.WriterId, cascadeDelete: true)
                .ForeignKey("dbo.OrderDetail", t => t.OrderDetail_OrderDetailsId)
                .Index(t => t.SupplierId)
                .Index(t => t.CategoryId)
                .Index(t => t.WriterId)
                .Index(t => t.OrderDetail_OrderDetailsId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        CategoryDescription = c.String(maxLength: 250),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewsID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Review = c.String(nullable: false, maxLength: 500),
                        Rate = c.Int(),
                        ReviewDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.ReviewsID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 50),
                        ContactName = c.String(maxLength: 50),
                        ContactTitle = c.String(maxLength: 50),
                        Address = c.String(maxLength: 150),
                        Mobile = c.String(maxLength: 20),
                        Phone = c.String(maxLength: 20),
                        Fax = c.String(maxLength: 20),
                        Email = c.String(maxLength: 50),
                        City = c.String(maxLength: 20),
                        Country = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.Writer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 20),
                        Age = c.Int(),
                        Gender = c.Boolean(),
                        BirthDate = c.DateTime(storeType: "date"),
                        State = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        PostalCode = c.String(maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Address1 = c.String(nullable: false, maxLength: 50),
                        Address2 = c.String(maxLength: 50),
                        LastLogin = c.DateTime(),
                        CreatedDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        PaymentId = c.Int(nullable: false),
                        Discount = c.Int(),
                        Taxes = c.Int(),
                        ShippingFee = c.Decimal(storeType: "money"),
                        IsCompleted = c.Boolean(),
                        OrderDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Dispatched = c.Boolean(),
                        DispatchedDate = c.DateTime(),
                        Shipped = c.Boolean(),
                        ShippingDate = c.DateTime(),
                        Deliver = c.Boolean(),
                        DeliveryDate = c.DateTime(),
                        CancelOrder = c.Boolean(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Payment", t => t.PaymentId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.PaymentId);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        CreditAmount = c.Decimal(storeType: "money"),
                        DebitAmount = c.Decimal(storeType: "money"),
                        Balance = c.Decimal(storeType: "money"),
                        PaymentDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            CreateTable(
                "dbo.Wishlists",
                c => new
                    {
                        WishListID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.WishListID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailsId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(),
                        Discount = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailsId)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "OrderDetail_OrderDetailsId", "dbo.OrderDetail");
            DropForeignKey("dbo.OrderDetail", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Wishlists", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Wishlists", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Order", "PaymentId", "dbo.Payment");
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.CartLine", "Cart_CartId", "dbo.Cart");
            DropForeignKey("dbo.CartLine", "Product_ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "WriterId", "dbo.Writer");
            DropForeignKey("dbo.Product", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Reviews", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product", "CategoryId", "dbo.Category");
            DropIndex("dbo.OrderDetail", new[] { "OrderId" });
            DropIndex("dbo.Wishlists", new[] { "ProductID" });
            DropIndex("dbo.Wishlists", new[] { "CustomerID" });
            DropIndex("dbo.Order", new[] { "PaymentId" });
            DropIndex("dbo.Order", new[] { "CustomerId" });
            DropIndex("dbo.Reviews", new[] { "ProductID" });
            DropIndex("dbo.Product", new[] { "OrderDetail_OrderDetailsId" });
            DropIndex("dbo.Product", new[] { "WriterId" });
            DropIndex("dbo.Product", new[] { "CategoryId" });
            DropIndex("dbo.Product", new[] { "SupplierId" });
            DropIndex("dbo.CartLine", new[] { "Cart_CartId" });
            DropIndex("dbo.CartLine", new[] { "Product_ProductId" });
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Wishlists");
            DropTable("dbo.Payment");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
            DropTable("dbo.Writer");
            DropTable("dbo.Supplier");
            DropTable("dbo.Reviews");
            DropTable("dbo.Category");
            DropTable("dbo.Product");
            DropTable("dbo.CartLine");
            DropTable("dbo.Cart");
            DropTable("dbo.Advertisement");
        }
    }
}
