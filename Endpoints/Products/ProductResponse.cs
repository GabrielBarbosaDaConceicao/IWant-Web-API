﻿namespace IWantApp.Endpoints.Categories.Products;

public record ProductResponse(string Name, string CategoryName, string Description, bool HasStock, bool Active);
