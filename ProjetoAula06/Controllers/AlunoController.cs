using ProjetoAula06.Entities;
using ProjetoAula06.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Controllers
{/// <summary>
/// Classe controladora das ações da entidade Aluno
/// </summary>
    public class AlunoController
    {/// <summary>
    /// Criando vinculo com a interface do repositório do aluno.
    /// </summary>
        private readonly IAlunoRepository _alunoRepository;
        //Método para inicializar o atributo acima.
        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public void CadastrarAluno()
        {
            try
            {
                Console.WriteLine("\nCadastro de aluno");

                var aluno = new Aluno();
                aluno.Id = Guid.NewGuid();

                Console.Write("Insira o nome do aluno....................: ");
                aluno.Nome = Console.ReadLine();

                Console.Write("Insira a matricula do aluno...............: ");
                aluno.Matricula = Console.ReadLine();

                Console.Write("Insira a data de nascimento do aluno......: ");
                aluno.DataNascimento = DateTime.Parse(Console.ReadLine());
                //Gravando os dados do aluno.
                _alunoRepository.Exportar(aluno);

                Console.WriteLine("\nALUNO CADASTRADO COM SUCESSO!");

            } catch (ArgumentException e) 
            {
                Console.WriteLine("\nERRO DE VALIDAÇÃO" + e.Message);

            } catch (Exception e)
            {
                Console.WriteLine("\nErro ao cadastrar" + e.Message);
            }
        }
    }
}
