using MagicVilla_API.Modelos.NewFolder;

namespace MagicVilla_API.Datos
{
    public  static class VillaStore
    {

        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id= 1, Nombre = "Vista a la Piscina", Ocupantes =4, MetrosCuadrados = 50},
            new VillaDto{Id= 2, Nombre = "Vista a la Playa", Ocupantes =8, MetrosCuadrados = 80}
        };
    }
}
