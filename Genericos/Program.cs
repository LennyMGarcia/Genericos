using System;
/// <summary>
/// Este es para mostrar lo error de genericos ya que hay que usar mucho casting 
/// para indicar valor y no da error en tiempo de compilacion pero si de ejecucion
/// </summary>
namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se especifica la clase empleado como tipo generico
            //Osea el tipo de dato que va a manejar ese objeto
            //Ayuda a mostrar los errores en tiempo de compilacion y no de ejecucion
            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);

            archivos.Agregar(new DateTime());
            archivos.Agregar(new DateTime());
            archivos.Agregar(new DateTime());
            archivos.Agregar(new DateTime());


            /* archivos.Agregar("Antonio");
             archivos.Agregar("Lennt");
             archivos.Agregar("Rosario");
             //Hay que hacer un casting  para poder leer los archivos que son tipo objects
             //menos cuando es generico*/
            DateTime nombrePersona = archivos.getElemento(2);
            Console.WriteLine(nombrePersona);
        }
    }
    //Con esto se indica que esta clase manejara cualquier tipo de objetos, lo mismo para los metodos y los arrays
    class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {
            datosElementos = new T[z];
        }

        public void Agregar(T obj)
        {
            //EN la posicion i almacena el elemento de tipo objeto
            datosElementos[i] = obj;
            //incrementa para que permita agregar mas elemenots
             i++;
        }
        //devuelve el dato en el array ubicado
        public T getElemento(int i)
        {
            return datosElementos[i];
        }
        //Almacena cualquier tipo de objeto con cualquier tipo de valor ya que todo hereda de objet
        
        private T[] datosElementos;

        private int i  = 0;
    }
    class empleado
    {
        private double salario;
        public empleado(double Salario)
        {
            this.salario = Salario;

        }

        public double getSalario()
        {
            return salario;
        }
        
    }
   
}
