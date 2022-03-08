﻿using Labrasa.API.Domain.Interfaces;
using Labrasa.API.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labrasa.API.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class MesaController : Controller
    {
        private readonly IMesaRepository _context;
        public MesaController(IMesaRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _context.PegarTodas());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        [HttpPost]
        public async Task<IActionResult> Post(Mesa mesa)
        {
            try
            {
                if(mesa == null)
                {
                    return BadRequest();
                }
                return Ok(await _context.Incluir(mesa));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var mesa = await _context.PegarPeloId(id);
             
                if(mesa == null)
                {
                    return NotFound();
                }

                return Ok(mesa);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            try
            {
                await _context.Apagar(id);
                return true;
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Mesa mesa)
        {
            // FALTA IMPLEMENTAR CORRETAMENTE.
            try
            {
                return Ok(await _context.Atualizar(mesa)); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
         
            
            
    }
}
