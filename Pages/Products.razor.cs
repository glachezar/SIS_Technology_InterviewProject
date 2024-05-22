namespace SIS_Technology_InterviewProject.Pages
{
    using SIS_Technology_InterviewProject.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public partial class Products
    {
        private IEnumerable<Product>? productList;

        protected override async Task OnInitializedAsync()
        {
            productList = await ProductService.GetAllProductsAsync();
        }

        private void OnRowInserting()
        {
        }
    }
}