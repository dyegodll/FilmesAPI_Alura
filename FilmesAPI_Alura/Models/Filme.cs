using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    public int Id { get; set; }

    [StringLength(50, ErrorMessage = "O tamanho do título diretor não pode exceder 50 caracteres")]
    [Required(ErrorMessage = "O campo título do filme é obrigatório!")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O campo gênero do filme é obrigatório!")]
    [MaxLength(50, ErrorMessage = "O tamanho do campo gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "O campo duração do filme é obrigatório!")]
    [Range(70,600, ErrorMessage = "O campo duração do filme deve estar entre 70 e 600 min")]
    public int Duracao { get; set; }
    [Required(ErrorMessage = "O campo diretor do filme é obrigatório!")]
    [MaxLength(100, ErrorMessage = "O tamanho do campo diretor não pode exceder 100 caracteres")]
    public string Diretor { get; set; }
    

    public override string ToString()
    {
        return $"{Titulo} | Gênero: {Genero} | Duração: {Duracao}min | Diretor: {Diretor}";
    }

}
