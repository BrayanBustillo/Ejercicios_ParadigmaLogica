using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_ParadigmaLogica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--> EJERCICIO 1: Clasificacion por Edad");
            int[] edades = { 12, 17, 25 };
            foreach (int edad in edades)
            {
                Console.WriteLine($"\nEdad: {edad}");
                Console.WriteLine($"¿Es niño? {Niño(edad)}");
                Console.WriteLine($"¿Es adolescente? {Adolescente(edad)}");
                Console.WriteLine($"¿Es adulto? {Adulto(edad)}");
            }

            Console.WriteLine("\n--> EJERCICIO 2: Numeros Primos");
            Console.WriteLine(" ");
            int[] numeros = { 1, 2, 3, 4, 15, 17 };
            foreach (int n in numeros)
            {
                Console.WriteLine($"¿{n} es primo? {NumerosPrimo(n)}");
            }

            Console.WriteLine("\n--> EJERCICIO 3: Acceso por Rol (admin/user)");
            string[] roles = { "admin", "user" };
            foreach (string rol in roles)
            {
                Console.WriteLine($"\nRol: {rol}");
                Console.WriteLine($"¿Puede leer? {PuedeLeer(rol)}");
                Console.WriteLine($"¿Puede escribir? {PuedeEscribir(rol)}");
                Console.WriteLine($"¿Puede eliminar? {PuedeEliminar(rol)}");
            }
        }

        // Ejercicio 1
        static bool Niño(int edad) => edad >= 0 && edad < 13;
        static bool Adolescente(int edad) => edad >= 13 && edad < 18;
        static bool Adulto(int edad) => edad >= 18;

        // Ejercicio 2
        static bool NumerosPrimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        // Ejercicio 3
        static bool PuedeLeer(string rol)
        {
            return rol == "admin" || rol == "user";
        }

        static bool PuedeEscribir(string rol)
        {
            return rol == "admin";
        }

        static bool PuedeEliminar(string rol)
        {
            return rol == "admin";
        }
    }
}
