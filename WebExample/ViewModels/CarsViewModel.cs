using WebExample.Models;

namespace WebExample.ViewModels
{
    public class CarsViewModel : Human
    {
        /// <summary>
        /// For representation in result
        /// </summary>
        public List<Car> Cars { get; set; } = null!;
    }
}
