using System.Collections.Generic;
using NextSoftTest.Models;

namespace NextSoftTest.Models
{
    public interface ICadastroRepo 
    {
        //Definição dos comandos da interface.
        cadastro getCadastroByCPF(string cpf);
        void insertCadastro(cadastro novoCadastro);
        bool saveChanges();

        void updateCadastro(cadastro CadastroUpdt);

        void patchCadastro();

        void deleteCadastro(cadastro cadastroDelete);
        
    }
}