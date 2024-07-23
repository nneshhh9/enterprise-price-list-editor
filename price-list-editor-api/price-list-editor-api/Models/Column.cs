using System.ComponentModel.DataAnnotations;

namespace price_list_editor_api.Models;

/// <summary>
/// Эта модель представляет дополнительную колонку, которую может создать пользователь для прайс-листа
/// </summary>
public class Column
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [StringLength(50)]
    public string DataType { get; set; } // Например, "string", "int", "decimal", "date"

    public int PriceListId { get; set; }
    public PriceList PriceList { get; set; }
}