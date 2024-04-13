namespace Escolar{
    public class Estudiante{
        public string nombre{get; set;}
        public int edad {get; set;}
        public string carnet{get;set;}

        public bool solvente{get; set;}



    

    public Estudiante(string nombre, int edad, string carnet, bool solvente){
        this.nombre = nombre;
        this.edad = edad;
        this.carnet = carnet;
        this.solvente = solvente;
    }



    public Estudiante(){

    }

    }

}