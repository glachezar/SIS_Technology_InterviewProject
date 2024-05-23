using SIS_Technology_InterviewProject.Data;
using DevExpress.Blazor;

namespace SIS_Technology_InterviewProject.Pages;

public partial class TestComponent
{
    private IEnumerable<Product>? productList;

    protected override async Task OnInitializedAsync()
    {
        await LoadProducts();
    }

    private async Task LoadProducts()
    {
        productList = (await ProductService.GetAllProductsAsync()).ToList();
    }

    private async Task OnRowInserting()
    {
        await Task.CompletedTask;
    }

    private async Task OnRowUpdating(GridEditModelSavingEventArgs e)
    {
        await ProductService.UpdateProductAsync((Product)e.EditModel);
        await LoadProducts();
    }

    private async Task OnRowDeleting(GridDataItemDeletingEventArgs e)
    {
        await ProductService.DeleteProductAsync((e.DataItem as Product).Id);

        await LoadProducts();
    }
}
