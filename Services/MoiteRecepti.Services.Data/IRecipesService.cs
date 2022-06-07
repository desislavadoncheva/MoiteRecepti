﻿namespace MoiteRecepti.Services.Data
{
    using System.Threading.Tasks;

    using MoiteRecepti.Web.ViewModels.Recipes;

    public interface IRecipesService
    {
        Task Create(CreateRecipeInputModel input);
    }
}
