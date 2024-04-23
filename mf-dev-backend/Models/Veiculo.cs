using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório Inserir um Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório Inserir a Placa")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Obrigatório Inserir o Ano de Fabricacao")]
        [Display(Name = "Ano de Fabricacao")]
        public int AnoFabricacao { get; set; }
        [Required(ErrorMessage = "Obrigatório Inserir o Ano do Modelo")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
