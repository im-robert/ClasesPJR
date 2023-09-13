namespace ClasesPJR 
{
   public class program
    {
        static void Main(string[] args)
        {
            var estudiante = new Estudiante();
            {
                estudiante.Matricula = "20220950";

                estudiante.Calificaciones = 90.5;

                estudiante.Curso = "Software2";
            }


            Console.WriteLine(estudiante.presentacion());
        }

       
    }

 }
