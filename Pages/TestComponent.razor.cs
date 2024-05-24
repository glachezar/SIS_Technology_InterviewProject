using SIS_Technology_InterviewProject.Data;
using DevExpress.Blazor;

namespace SIS_Technology_InterviewProject.Pages;

public partial class TestComponent
{
    
    private IEnumerable<Product>? productList;
    DateTime DateTimeValue { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await LoadProducts();
    }

    private async Task LoadProducts()
    {
        productList = (await ProductService.GetAllProductsAsync()).ToList();
    }

    private async Task OnRowInserting(Product product)
    {
        await ProductService.AddProductAsync(product);
    }

    private async Task OnRowUpdating(GridEditModelSavingEventArgs p)
    {
        if (p.IsNew)
        {
            DateTimeValue = DateTime.Today;
            await OnRowInserting((Product)p.EditModel);
        }
        else
        {
            var product = (Product)p.EditModel;
            DateTimeValue = product.DateAdded;
            await ProductService.UpdateProductAsync((Product)p.EditModel);
        }
        await LoadProducts();
    }

    private async Task OnRowDeleting(GridDataItemDeletingEventArgs e)
    {
        await ProductService.DeleteProductAsync((e.DataItem as Product).Id);

        await LoadProducts();
    }
}
