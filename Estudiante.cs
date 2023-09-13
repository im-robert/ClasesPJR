namespace ClasesPJR
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Matricula { get; set; }

        public double Calificaciones { get; set; }

        public string Curso { get; set; }

        
    public string presentacion()
        {
            return $"Hola!, estudio {Curso}, mi matricula es {Matricula} y tuve una calificacion de {Calificaciones}";
        } 
    }
}
