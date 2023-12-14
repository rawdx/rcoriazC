using rcoriaz.DAL;
using rcoriaz.Models;

namespace rcoriaz.Utils
{
    public class Conversion
    {
        public List<VajillaDto> ConvertirDaoADto(List<Vajilla> vajillas)
        {
            List<VajillaDto> vajillasDto = new List<VajillaDto>();

            foreach (var vajilla in vajillas)
            {
                VajillaDto vajillaDto = new VajillaDto
                {
                    IdVajilla = vajilla.IdVajilla,
                    Codigo = vajilla.Codigo,
                    Nombre = vajilla.Nombre,
                    Descripcion = vajilla.Descripcion,
                    Cantidad = vajilla.Cantidad
                };

                vajillasDto.Add(vajillaDto);
            }

            return vajillasDto;
        }
        public List<Vajilla> ConvertirDtoADao(List<VajillaDto> vajillasDto)
        {
            List<Vajilla> vajillasDao = new List<Vajilla>();

            foreach (var vajillaDto in vajillasDto)
            {
                Vajilla vajillaDao = new Vajilla
                {
                    Codigo = vajillaDto.Codigo,
                    Nombre = vajillaDto.Nombre,
                    Descripcion = vajillaDto.Descripcion,
                    Cantidad = vajillaDto.Cantidad
                };

                vajillasDao.Add(vajillaDao);
            }

            return vajillasDao;
        }
    }
}
