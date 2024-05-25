using DevExpress.Blazor;
using SIS_Technology_InterviewProject.Data;

namespace SIS_Technology_InterviewProject.Pages;

public partial class Products
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

    private async Task OnRowInserting(Product product)
    {
        await ProductService.AddProductAsync(product);
    }

    private async Task OnRowUpdating(GridEditModelSavingEventArgs p)
    {
        if (p.IsNew)
        {
            await OnRowInserting((Product)p.EditModel);
        }
        else
        {
            var product = (Product)p.EditModel;
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