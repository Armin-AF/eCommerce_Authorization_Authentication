using Microsoft.EntityFrameworkCore;
using strore.server.Models;

namespace strore.server.DataBase;

public class DbInitializer
{
    readonly ModelBuilder _builder;
    
    public DbInitializer(ModelBuilder builder)
    {
        _builder = builder;
    }

    public void Seed(){
        _builder.Entity<User>().HasData(
            new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user1",
                Email = "user1@email.com",
                Role = "user",
                StoreId = "store1",
                Password = "123456"
            },
            new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user2",
                Email = "user2@email.com",
                Role = "user",
                StoreId = "store2",
                Password = "123456"
            },
            new User{
                Id = new Guid("f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b").ToString(),
                UserName = "admin",
                Email = "admin@email.com",
                Role = "admin",
                Password = "123456"
            }
        );
        
        _builder.Entity<Store>().HasData(
            new Store
            {
                Id = new Guid("f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b").ToString(),
                Name = "store1",
                AdminId = new Guid("f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b").ToString()
            },
            new Store
            {
                Id = new Guid("f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b").ToString(),
                Name = "store2",
                AdminId = new Guid("f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b").ToString()
            },
            new Store
            {
                Id = new Guid("f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b").ToString(),
                Name = "store3",
                AdminId = new Guid("f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b").ToString()
            }
        );
        
        _builder.Entity<Product>().HasData(
            new Product
            {
                Id = Guid.NewGuid().ToString(),
                Title = "product1",
                Description = "product1 description",
                ImageUrl = "https://picsum.photos/200/300",
                StoreId = "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b",
                Price = 10,
                Quantity = 10,
                Category = "category1"},
            
            new Product
            {
                
                Id = Guid.NewGuid().ToString(),
                Title = "product2",
                Description = "product2 description",
                ImageUrl = "https://picsum.photos/200/300",
                StoreId = "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b",
                Price = 20,
                Quantity = 20,
                Category = "category1"},
            
            new Product
                
            {
                Id = Guid.NewGuid().ToString(),
                Title = "product3",
                Description = "product3 description",
                ImageUrl = "https://picsum.photos/200/300",
                StoreId = "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b",
                Price = 30,
                Quantity = 30,
                Category = "category1"}
            );
    }
    
}