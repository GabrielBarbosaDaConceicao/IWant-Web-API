﻿using IWantApp.Domain.Products;
using IWantApp.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace IWantApp.Endpoints.Categories;

public class CategoryGetAll//Controller
{

    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;


    [HttpGet]
    public static IResult Action(ApplicationDbContext context)
    {
        var categories = context.Categories.ToList();
        var respose = categories.Select(c => new CategoryResponse { Id = c.Id, Name = c.Name, Active = c.Active });
        
        return Results.Ok(respose);
    }
}