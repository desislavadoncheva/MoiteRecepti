namespace MoiteRecepti.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti.Services.Data;
    using MoiteRecepti.Web.ViewModels;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService countsService;

        public HomeController(IGetCountsService countsService)
        {
            this.countsService = countsService;
        }

        //private readonly ApplicationDbContext db;
        //public HomeController(ApplicationDbContext db)
        //{
        //    this.db = db;
        //} - замества се ApplicationDbContext с Repositories

        //private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        //private readonly IDeletableEntityRepository<Category> categoriesRepository;
        //private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;
        //private readonly IRepository<Image> imagesRepository;

        //public HomeController(
        //    IDeletableEntityRepository<Recipe> recipesRepository,
        //    IDeletableEntityRepository<Category> categoriesRepository,
        //    IDeletableEntityRepository<Ingredient> ingredientsRepository,
        //    IRepository<Image> imagesRepository)
        //{
        //    this.recipesRepository = recipesRepository;
        //    this.categoriesRepository = categoriesRepository;
        //    this.ingredientsRepository = ingredientsRepository;
        //    this.imagesRepository = imagesRepository;
        //} - замества се със Service

        public IActionResult Index()
        {
            var viewModel = this.countsService.GetCounts();
            return this.View(viewModel);

            //var viewModel = new IndexViewModel
            //{
            //    RecipesCount = this.recipesRepository.All().Count(),
            //    CategoriesCount = this.categoriesRepository.All().Count(),
            //    IngredientsCount = this.ingredientsRepository.All().Count(),
            //    ImagesCount = this.imagesRepository.All().Count(),
            //};
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
