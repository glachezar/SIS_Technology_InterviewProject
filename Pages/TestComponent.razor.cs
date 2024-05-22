using SIS_Technology_InterviewProject.Data;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using DevExpress.Blazor.Grid;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;
using Abp.Application.Navigation;

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

    private void OnRowDeleting()
    {
    }
}
