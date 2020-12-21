using System;
using System.Collections.Generic;
using System.Linq;
using NextSoftTest.Models;

namespace NextSoftTest.Data
{
    public class SqlCadastroRepo : ICadastroRepo
    {
        private readonly CadastroContext _context;
        public SqlCadastroRepo(CadastroContext context)
        {
            _context = context;
        }

        public cadastro getCadastroByCPF(string cpf)
        {
           return _context.Cadastros.FirstOrDefault(p=> p.CPF == cpf);
        }

        public bool saveChanges()
        {
            return (_context.SaveChanges() >= 0); 
        }

       
        void ICadastroRepo.insertCadastro(cadastro novoCadastro)
        {
            if (novoCadastro == null)
            {
                throw new ArgumentNullException(nameof(novoCadastro));
            }
            _context.Cadastros.Add(novoCadastro);
        }

        public void updateCadastro(cadastro CadastroUpdt)
        {
            //Nothing
        }

        public void patchCadastro()
        {
            //nothing
        }

        public void deleteCadastro(cadastro CadastroDelete)
        {
            if(CadastroDelete==null)
            {
                throw new ArgumentNullException(nameof(CadastroDelete));
            }

            _context.Cadastros.Remove (CadastroDelete);
        }
    }
}