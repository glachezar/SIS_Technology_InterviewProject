using SIS_Technology_InterviewProject.Data;
using DevExpress.Blazor;

namespace SIS_Technology_InterviewProject.Pages;

public partial class TestComponent
{
    private IEnumerable<Product>? productList;

    private DateTime DateTimeValue = DateTime.Today;

    protected override async Task OnInitializedAsync() =>
        await LoadProducts();

    private async Task LoadProducts() =>
        productList = (await ProductService.GetAllProductsAsync()).ToList();

}
