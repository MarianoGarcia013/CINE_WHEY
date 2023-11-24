using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CineWheyBackend.Models;
using CineWheyBackend.Data;
using CineWheyBackend.Negocio;

namespace CineWheyxApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CINEControlador : ControllerBase
    {
        private DataApi DA;

        public CINEControlador()
        {
                DA = new DataApi();
        }

        [HttpGet("/Peliculas")]
        public IActionResult GetPeliculas() // GetPeliculas Listo
        {
            return Ok(DA.ConsultarPeliculas());
        }

        [HttpGet("/Peliculas por Genero")]
        public IActionResult GetPeliculaPorGenero(int genero)   // GetPeliculas por genero Listo
        {
            if (genero == null)
                return BadRequest("Debe ingresar un genero!");
            return Ok(DA.GetPeliculaPorGenero(genero));

        }




        [HttpPost("/AgregarPelicula")]
        public IActionResult PostPelicula(Pelicula pelicula) // PostPeliculas Listo
        {
            try
            {
                if (pelicula == null)
                    return BadRequest("Falan datos para agregar una pelicula");
                if (DA.InsertarPelicula(pelicula))
                    return Ok("La pelicula fue agregada con exito!");
                else
                    return Ok("La pelicula no pudo ser agregada");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("/ModificarPeliculas")]
        public IActionResult PutPelicula(Pelicula pelicula) // PutPelicula Listo
        {

            try
            {
                if (pelicula == null)
                    return BadRequest("Los datos ingresados son incorrectos.");

                if (DA.UpdatePelcicula(pelicula))
                    return Ok("La pelicula fue modificada con exito!");
                else
                    return Ok("La pelicula no pudo ser modificada");

            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("/EliminarPeliculas")]
        public IActionResult DeletePelicula(int id) //DeletePelicula Listo
        {
            try
            {
                if (id == 0)
                    return BadRequest("Ingrese el codigo de la pelicula que quiere eliminar");

                if (DA.DeletePeliucla(id))
                    return Ok("La pelicula fue eliminada con exito!");
                else
                    return Ok("La pelicula no pudo ser eliminada");

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
