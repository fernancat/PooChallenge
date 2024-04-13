using Escolar;

List<Estudiante> estudiantes = new List<Estudiante>{
    new Estudiante(),
    new Estudiante(),
    new Estudiante(),
    new Estudiante(),
    new Estudiante()
};



foreach(Estudiante estudiante in estudiantes){
    Console.WriteLine("Nombre del estudiante: ");
    estudiante.nombre = Console.ReadLine();
    Console.WriteLine("Ingrese su edad: ");
    estudiante.edad = int.Parse(Console.ReadLine());
    Console.WriteLine("Carnet del estudiante: ");
    estudiante.carnet = Console.ReadLine();
    Console.WriteLine("El estudiante esta solvente?: ");
    estudiante.solvente = bool.Parse(Console.ReadLine());




}