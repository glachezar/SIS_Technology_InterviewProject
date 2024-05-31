using DevExpress.Blazor;
using Domain.Entities;

namespace SIS_Technology_InterviewProject.Pages;

public partial class Products
{
    private IEnumerable<Product>? productList;

    private DateTime DateTimeValue = DateTime.Today;

    bool PanelVisible { get; set; }

    protected override async Task OnInitializedAsync() =>
        await LoadGridData();

    private async Task LoadProducts() =>
        productList = (await ProductService.GetAllProductsAsync()).ToList();

    private async Task OnRowInserting(Product product)
    {
        await ProductService.CreateProductAsync(product);
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

    async Task LoadGridData()
    {
        PanelVisible = true;
        //await Task.Delay(1000);
        await LoadProducts();
        PanelVisible = false;
    }
}