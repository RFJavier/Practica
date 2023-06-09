﻿using Entidadesdenegocio;
using LogicadeNegocios;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Prueba1WebApi.Controllers
{
   

       [Route("api/[Controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private RolBL RolBL = new RolBL();

        [HttpGet]
        public async Task<IEnumerable<Rol>> Get()
        {
            return await RolBL.ObtenerTodosAsync();
        }

        [HttpGet("{id}")]
        public async Task<Rol> Get(int id)
        {
            Rol rol = new Rol();
            rol.Id = id;
            return await RolBL.ObtenerPorIdAsync(rol);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Rol rol)
        {
            try
            {
                await RolBL.CrearAsync(rol);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Rol rol
            )
        {
            if (rol.Id == id)
            {
                await RolBL.ModificarAsync(rol);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                Rol rol = new Rol();
                rol.Id = id;
                await RolBL.EliminarAsync(rol);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("Buscar")]
        public async Task<List<Rol>> Buscar([FromBody] object pMedico)
        {
            var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string strMedico = JsonSerializer.Serialize(pMedico);
            Rol medico = JsonSerializer.Deserialize<Rol>(strMedico, option);
            return await RolBL.BuscarAsync(medico);

        }

        }
    }

