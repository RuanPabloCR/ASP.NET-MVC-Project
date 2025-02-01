using System.ComponentModel.DataAnnotations;
using SalesWebMVC.Models.Enums;
namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} required")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        public double Amount { get; set; }
        [Display(Name = "Sale Status")]
        //[EnumDataType(typeof(SaleStatus))]
        [Required(ErrorMessage = "{0} required")]
        public SaleStatus Status { get; set; }
        public Seller? Seller { get; set; }
        [Display(Name = "Seller")]
        public int SellerId { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

    }
}
