using PaySolutionsDesktop.DAO;
using System;
using System.Data.SqlClient;

namespace PaySolutionsDesktop
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool confirmado = false;
            LoginDAO loginDAO = new LoginDAO();
            bool loginValido = loginDAO.VerificarLogin("usuarioTeste", "senhaTeste");

            if (loginValido)
            {
                Console.WriteLine("Login válido!");
            }
            else
            {
                Console.WriteLine("Login inválido!");
            }
        }
    }
}
