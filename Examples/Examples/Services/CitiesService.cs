using System.Linq;

namespace Examples.Services
{
    public class CitiesService
    {
        public string[] Cities { get; } = new[]
        {
            "Santo Tomé",
            "Santiago del Estero",
            "Santa Rosa",
            "Santa Lucía",
            "Santa Fe de la Vera Cruz",
            "San Salvador de Jujuy",
            "San Ramón de la Nueva Orán",
            "San Rafael",
            "San Pedro",
            "San Nicolás de los Arroyos",
            "San Miguel de Tucumán",
            "San Martín de los Andes",
            "San Martín",
            "San Luis",
            "San Justo",
            "San Juan",
            "San José de Jáchal",
            "San Jorge",
            "San Francisco",
            "San Fernando del Valle de Catamarca",
            "San Antonio Oeste"
        };

        public string[] GetCities(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return new string[] { };
            }

            return Cities.Where(x => x.Contains(searchText)).ToArray();
        }

    }
}
