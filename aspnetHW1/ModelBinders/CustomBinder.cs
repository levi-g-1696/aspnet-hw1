using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetHW1.ModelBinders
{

    public class CustomBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var data = bindingContext.HttpContext.Request.Query;

            var result = data.TryGetValue("candies", out var candy);

            if (result)
            {
                var array = candy.ToString().Split('|');

                bindingContext.Result = ModelBindingResult.Success(array);
            }

            return Task.CompletedTask;

        }
    }
}

        
  
