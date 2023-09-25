﻿using ProjetoAula06.Controllers;
using ProjetoAula06.Repositories;
using ProjetoAula06.Interfaces;

namespace ProjetoAula06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var alunoController = new AlunoController(new AlunoRepository());

            try
            {
                alunoController.CadastrarAluno();
            }
            catch (Exception e) 
            {
                Console.WriteLine("\nFalha" + e.Message);
            }


        }
    }

}