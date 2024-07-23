using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace price_list_editor_api.Models;

/// <summary>
/// Эта модель представляет товар, который включен в прайс-лист
/// </summary>
public class Product
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    public string Code { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    public int StockQuantity { get; set; }

    public DateTime DateAdded { get; set; }

    public int PriceListId { get; set; }
    public PriceList PriceList { get; set; }

    public ICollection<ProductColumnValue> ColumnValues { get; set; }
}