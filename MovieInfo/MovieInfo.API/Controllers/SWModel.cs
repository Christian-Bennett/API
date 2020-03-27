using System.ComponentModel.DataAnnotations;

namespace MovieInfo.API.Controllers
{

  public class SWModel
  {
    [Required]
    public string Title { get; set; }
  }


}