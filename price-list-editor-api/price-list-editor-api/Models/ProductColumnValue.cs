using System.ComponentModel.DataAnnotations;

namespace price_list_editor_api.Models;

/// <summary>
/// Эта модель представляет значение пользовательской колонки для конкретного товара
/// </summary>
public class ProductColumnValue
{
    public int Id { get; set; }

    [Required]
    public string Value { get; set; }

    public DateTime LastUpdated { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int ColumnId { get; set; }
    public Column Column { get; set; }
}