
using System.Runtime.Serialization;

namespace Calculando{

    public class Calculadora{
        protected int serie {
            get{
                return serie;
            }

            set{


                if (value.ToString() == " "){
                    Console.WriteLine("No puedes pasar espacios como nombres para la serie");
                }
                serie = value;
            }
        }

        protected string marca{
            get{
                return marca;
            }

            set{


                if (value.ToString() == " "){
                    Console.WriteLine("No puedes pasar espacios como nombres para la marca");
                }
                marca = value;
            }
        }



        public Calculadora(int serie, string marca){
            this.serie = serie;
            this.marca = marca;
        }

        public double sumar(int num1, int num2){
             try{
                return num1 +num2;

            }catch{

                Console.WriteLine("Insertaste un string o un caracter incorrecto");
                return 0;

            }
        }


        public int restar(int num1, int num2 ){
            try{
                return num1 -num2;

            }catch{

                Console.WriteLine("Insertaste un string o un caracter incorrecto");
                return 0;

            }

            
        }


       
        public double multiplicar(int num1, int num2){
             try{
                return num1 *num2;

            }catch{

                Console.WriteLine("Insertaste un string o un caracter incorrecto");
                return 0;

            }
        }


        public double dividir(int num1, int num2){
             try{
                return num1 /num2;

            }catch{

                Console.WriteLine("Insertaste un 0 o un caracter incorrecto");
                return 0;

            }
        }
        

        
    }


public class calculadraCientifica: Calculadora{


    public calculadraCientifica(int serie, string marca):base(serie,marca){
    }

     public double Potencia(int numeroBase, int exponente){
             try{
                return Math.Pow(numeroBase,exponente);

            }catch{

                Console.WriteLine("Insertaste  un caracter incorrecto");
                return 0;

            }
        }


    public double RaizCuadrada(int numero){
             try{
                return Math.Sqrt(numero);

            }catch{

                Console.WriteLine("Insertaste  un caracter incorrecto");
                return 0;

            }
        }


    
    public double modulo(int numero,int moduloDeNumero){
             try{
                return numero%moduloDeNumero;

            }catch{

                Console.WriteLine("Insertaste  un caracter incorrecto");
                return 0;

            }
        }


    public double Logaritmo(int numero,int numeroBase){
             try{
                return Math.Log(numero, numeroBase);

            }catch{

                Console.WriteLine("Insertaste  un caracter incorrecto");
                return 0;

            }
        }


        


}


}