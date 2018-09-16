using System.ComponentModel.DataAnnotations;

namespace AngularDemo.Models {
    public class Account {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}