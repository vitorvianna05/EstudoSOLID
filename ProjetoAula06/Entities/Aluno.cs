using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula06.Entities
{/// <summary>
/// Modelo de entidade
/// </summary>
    public class Aluno
    {
        #region Atributos
        private Guid _id;
        private string _nome;
        private string _matricula;
        private DateTime _dataNascimento;
        private List<Turma> _turmas;
        #endregion

        #region Propriedades
        public Guid Id
        {
            set => _id = value;
            get => _id;
        }
        public string Nome
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Por favor, insira o nome do aluno");

                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,100}$");

                if (!regex.IsMatch(value))
                    throw new ArgumentException
                        ("Por favor, insira um nome válido, entre 6 e 100 caracteres");
                _nome = value;
            }
            get=> _nome;
        }
        public string Matricula
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Por favor, insira a mátricula do aluno");
                var regex = new Regex("^[A-Za-z0-9]{4,10}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, insira uma mátricula válida.");
                _matricula = value;
            }
            get => _matricula;
        }
        public DateTime DataNascimento
        {
            set => _dataNascimento = value;
            get => _dataNascimento;
        }
        public List<Turma> Turmas
        {
            set => _turmas = value;
            get => _turmas;
        }
        #endregion

    }
}
