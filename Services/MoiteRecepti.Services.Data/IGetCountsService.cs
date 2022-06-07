namespace MoiteRecepti.Services.Data
{
    using MoiteRecepti.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        ////1.Use the viewModel
        ////2.Create Dto - viewModel
        ////3.Tuples
        public HomeIndexViewModel GetCounts();
    }
}
