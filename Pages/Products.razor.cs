using DevExpress.Blazor;
using SIS_Technology_InterviewProject.Data;

namespace SIS_Technology_InterviewProject.Pages;

public partial class Products
{
    private IEnumerable<Product>? productList;

    private DateTime DateTimeValue = DateTime.Today;

    protected override async Task OnInitializedAsync() =>
        await LoadProducts();

    private async Task LoadProducts() =>
        productList = (await ProductService.GetAllProductsAsync()).ToList();

    private async Task OnRowInserting(Product product)
    {
        await ProductService.AddProductAsync(product);
        await LoadProducts();
    }

    private async Task OnRowUpdating(GridEditModelSavingEventArgs p)
    {
        if (p.IsNew)
        {
            var product = (Product)p.EditModel;
            product.DateAdded = DateTimeValue;
            await OnRowInserting(product);
        }
        else
        {
            var product = (Product)p.EditModel;
            //The line below can be uncommented if you want to be able to redact the DateAdded field
            //product.DateAdded = DateTimeValue;
            await ProductService.UpdateProductAsync(product);
        }
        await LoadProducts();
    }

    private async Task OnRowDeleting(GridDataItemDeletingEventArgs e)
    {
        await ProductService.DeleteProductAsync((e.DataItem as Product).Id);
        await LoadProducts();
    }

    void OnDateChanged(DateTime newValue) =>
        DateTimeValue = newValue;
}