using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using NextSoftTest.Data;
using NextSoftTest.Dtos;
using NextSoftTest.Models;

namespace nextsofttest.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CadastroController: ControllerBase
    {
        private readonly ICadastroRepo _repository;
        private readonly IMapper _mapper;

        public CadastroController(ICadastroRepo repository, IMapper mapper)
        {
           _repository = repository; 
           _mapper = mapper;
        }
        
        //GET api/[controller]/{cpf}
        [HttpGet("{cpf}", Name = "getCadastroByCPF")]
        public ActionResult<CadastroReadDto> getCadastroByCPF(string cpf)
        {
            var cadastroItems = _repository.getCadastroByCPF(cpf);
            if (cadastroItems != null)
            {
                return Ok (_mapper.Map<CadastroReadDto>(cadastroItems));
            }
            return NotFound();  
        }

        //POST api/Cadastro
        [HttpPost]
        public ActionResult<CadastroReadDto> insertCadastro(CadastroCreateDto novoCadastro)
        {
            var CadastroModel = _mapper.Map<cadastro>(novoCadastro);
            _repository.insertCadastro(CadastroModel);
            _repository.saveChanges();
            var cadastroReadDto = _mapper.Map<CadastroReadDto>(CadastroModel);
            return CreatedAtRoute(nameof(getCadastroByCPF), new {cpf = cadastroReadDto.CPF}, cadastroReadDto);
        } 

        //put api/Cadastro/{cpf}
        [HttpPut("{cpf}")]
        public ActionResult updateCadastro(string cpf, CadastroUpdateDto cadastroUpdateDto)
        {
            var CadastroFromRepo = _repository.getCadastroByCPF(cpf);
            if (CadastroFromRepo == null)
            {
                return NotFound();
            }
            
            _mapper.Map(cadastroUpdateDto, CadastroFromRepo);
            _repository.updateCadastro(CadastroFromRepo);
            _repository.saveChanges();
            
            return NoContent();
        }

        //PATCH api/Cadastro/{cpf}
        [HttpPatch("{cpf}")]
        public ActionResult UpdateParcialCadastro(string cpf, JsonPatchDocument<CadastroUpdateDto> patchDoc)
        {
            var CadastroFromRepo = _repository.getCadastroByCPF(cpf);
            if (CadastroFromRepo == null)
            {
                return NotFound();
            }

            var CadastroParaPatch = _mapper.Map<CadastroUpdateDto>(CadastroFromRepo);
            patchDoc.ApplyTo(CadastroParaPatch, ModelState);

            if(!TryValidateModel(CadastroParaPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(CadastroParaPatch, CadastroFromRepo);
            _repository.updateCadastro(CadastroFromRepo);
            _repository.saveChanges();
            return NoContent();
            
        }

        //DELETE api/Cadastro/{cpf}
        [HttpDelete("{cpf}")]
        public ActionResult DeletaCadastro(string cpf)
        {
            var CadastroFromRepo = _repository.getCadastroByCPF(cpf);
            if (CadastroFromRepo == null)
            {
                return NotFound();
            }

            _repository.deleteCadastro(CadastroFromRepo);
            _repository.saveChanges();
            return NoContent();

        }
    }
}