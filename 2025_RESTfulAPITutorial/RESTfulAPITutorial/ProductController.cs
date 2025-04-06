// <copyright file="ProductController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RESTfulAPITutorial;

using Microsoft.AspNetCore.Mvc;
using RESTfulAPITutorial.Data;
using RESTfulAPITutorial.Model;

/// <summary>
/// API controller for products model
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class ProductController(ApplicationDbContext applicationDbContext) : ControllerBase
{
    private readonly ApplicationDbContext applicationDbContext = applicationDbContext;

    // CRUD
    // create
    // read
    // update
    // delete

    /// <summary>
    /// create a product entity and save it to the database.
    /// </summary>
    /// <param name="product">Insert product model.</param>
    /// <returns>IActionResult success.</returns>
    [HttpPost]
    public IActionResult CreateProduct([FromBody] Product product)
    {
        this.applicationDbContext.Products.Add(product);
        this.applicationDbContext.SaveChanges();

        return this.CreatedAtAction(nameof(this.CreateProduct), new { id = product.Id }, product);
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return this.Ok(this.applicationDbContext.Products.ToList());
    }

    [HttpDelete]
    public IActionResult DeleteProduct(int id)
    {
        var product = this.applicationDbContext.Products.Find(id);

        if (product == null)
        {
            return this.NotFound();
        }

        this.applicationDbContext.Remove(product);
        this.applicationDbContext.SaveChanges();

        return this.NoContent();
    }

    [HttpPut]
    public IActionResult UpdateProduct(int id, [FromBody] Product product)
    {
        var productInDb = this.applicationDbContext.Products.Find(id);

        if (productInDb == null)
        {
            return this.NotFound();
        }

        productInDb.Name = product.Name;

        productInDb.Price = product.Price;

        this.applicationDbContext.SaveChanges();

        return this.Ok();
    }
}
