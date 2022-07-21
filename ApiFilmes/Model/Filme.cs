using System;
using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Model
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="campo Titulo obrigatorio")]
        public string Titulo { get; set; }
        [Required (ErrorMessage ="campo Diretor obrigatorio")]
        public string Direto { get; set; }
        [StringLength(60,ErrorMessage ="numero maximo de caracter foi ultrapassado seu tamanho")]
        public string Genero { get; set; }
        [Range(1,600,ErrorMessage ="tempo tem que esta entre 1 e 600")]
        public int Duracao { get; set; }
    }
}
