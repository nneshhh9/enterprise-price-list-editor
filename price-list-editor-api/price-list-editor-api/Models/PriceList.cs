using System.ComponentModel.DataAnnotations;

namespace price_list_editor_api.Models;

/// <summary>
/// Эта модель представляет прайс-лист, который содержит множество товаров и колонок
/// </summary>
public class PriceList
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public ICollection<Product> Products { get; set; }
    public ICollection<Column> Columns { get; set; }
}