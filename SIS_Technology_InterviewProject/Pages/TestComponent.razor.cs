using SIS_Technology_InterviewProject.Data;
using DevExpress.Blazor;

namespace SIS_Technology_InterviewProject.Pages;

public partial class TestComponent
{
    private IEnumerable<Product>? productList;

    private IEnumerable<CategoryProductCountStatistic> categoryProductCountStatistics;

    bool PanelVisible { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await LoadGridData();
        categoryProductCountStatistics = GetCategoryCounts();
    }

    private async Task LoadProducts() =>
        productList = (await ProductService.GetAllProductsAsync()).ToList();

    public IEnumerable<CategoryProductCountStatistic> GetCategoryCounts()
    {
        var categoryCounts = productList
            .GroupBy(p => p.Category)
            .Select(g => new CategoryProductCountStatistic
            {
                Category = g.Key,
                Count = g.Count()
            })
            .ToList();

        return categoryCounts;
    }

    async Task LoadGridData()
    {
        PanelVisible = true;
        await Task.Delay(1000);
        await LoadProducts();
        PanelVisible = false;
    }
}

public class CategoryProductCountStatistic
{
    public string Category { get; set; } = string.Empty;
    public int Count { get; set; }
}
