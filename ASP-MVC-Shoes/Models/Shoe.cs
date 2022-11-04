using System.ComponentModel.DataAnnotations;
using System;

namespace ASP_MVC_Shoes.Models
{
    public enum Brands
    {
        Adidas, Nike, Reebok, Puma, Salazenger, Karrimor, Skechers 
    }
    public enum Styles
    {
        Casual, Running, Walking, Cricket
    }
    public enum Gendes
    {
        Mens, Womens
    }

    public class Shoe
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50), Required]
        public string? Name { get; set; }

        [Required]
        public Brands Brand { get; set; }= Brands.Reebok;
        //public string Colour { get; set; }

        [Required]
        public Styles Style { get; set; }= Styles.Casual;
       
        [Required]
        public Gendes Gender { get; set; }= Gendes.Mens;

        [Range(15.99, 100.99), Required]
        public decimal Price { get; set; }


    //    [DataType(DataType.Date)]
    //    public DateTime ReleaseDate { get; set; }

    //    public string Genre { get; set; }
    //    public decimal Price { get; set; }
    }
}
