﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyWebAPI.Models;

namespace MyWebAPI
{
    public class CustomBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelName);
            var result = value.FirstValue;

            if (!int.TryParse(result, out var id))
            {
                return Task.CompletedTask;
            }

            var model = new CountryModel()
            {
                Id = id,
                Area = 400,
                Name = "India",
                Population = 500
            };

            bindingContext.Result = ModelBindingResult.Success(model);

            return Task.CompletedTask;

        }
    }
}
