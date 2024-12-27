using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApi.Models;
using CustomerApi.Data;

namespace CustomerApi;
public static class APIs
{
    public static void Register(WebApplication app)
    {
        app.MapGet("/customers", (AppDbContext context) => context.Customers.ToArray());
        app.MapGet("/customer/{id}", (AppDbContext context, int id) => context.Customers.Find(id));
        app.MapPost("/customers/create", (AppDbContext context, Customer newCustomer) => {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
            return Results.NoContent();
        });
        app.MapDelete("/customers/delete/{id}", (AppDbContext context, int id) => {
            var customer = context.Customers.Find(id);
            if(customer == null) return Results.NotFound();
            context.Customers.Remove(customer);
            context.SaveChanges();
            return Results.NoContent();
        });
        app.MapPut("/customers/update/{id}", (AppDbContext context, int id, Customer updatedCustomer) => {
            var customer = context.Customers.Find(id);
            if(customer == null) return Results.NotFound();
            customer.Name = updatedCustomer.Name;
            customer.Address = updatedCustomer.Address;
            customer.PhoneNumber = updatedCustomer.PhoneNumber;
            context.SaveChanges();
            return Results.NoContent();
        });
    }
}