using System.ComponentModel.DataAnnotations;

namespace shampoo_shop.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Effect { get; set; }

        [Required]
        public string Usage { get; set; }
	}
}

