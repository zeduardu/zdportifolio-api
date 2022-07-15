namespace ZdportifolioApi.Models;

public class Category
{
    public string Name { get; set; }
    public Category Parent { get; set; } = null!;
}