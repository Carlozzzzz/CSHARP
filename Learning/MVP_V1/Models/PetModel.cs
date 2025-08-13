using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVP_V1.Models
{
    public class PetModel
    {
        // Variables
        private int id;
        private string name;
        private string type;
        private string colour;


        //Properties
        [DisplayName("Pet ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Pet name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters.")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet type is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters.")]
        public string Type { get => type; set => type = value; }

        [DisplayName("Pet Colour")]
        [Required(ErrorMessage = "Pet colour is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters.")]
        public string Colour { get => colour; set => colour = value; }
    }
}
