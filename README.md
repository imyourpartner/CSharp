# Microsoft Visual C Sharp

### El espacio de nombres

Los espacios de nombres se comportan como unos agrupadores de clases, como una forma de organizar las clases. 

```c#
namespace EntitiesLayer.Model.DataBaseConexion
{
    public class AdministracionBaseDeDatos
    {
         // Propiedades y metodos de la clase DataBaseConexion
        public void AbrirConexion()
        {
            // Logica AbrirConexion aqui
        }
        public void CerrarConexion()
        {
            // Logica CerrarConexion aqui
        }
        // etc..
    }
}
```

Cuando se crea un programa, se puede tener muchas clases, y éstas pueden estar agrupadas por uno o varios  `namespace` 

```c#
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
        }
    }
}
```

```c#
System.Console.WriteLine("Hello World!");
```

`System` es un espacio de nombres 

`Console` es una clase de ese espacio de nombres. 

En tiempo de ejecución, los valores son pasados al

Método `WriteLine("HelloWorld");` como argumentos.

Ejecucion

```c#
System.Console.WriteLine(Argumento valor); // Envia
```

Definicion

```c#
public static void Write(Parametro valor); // Recibe
```

```
using System.IO;
using System.Text;

namespace System
{        public static class Console
	{
        //
        // Summary:
        //     Writes the specified string value to the standard output stream.
        //
        // Parameters:
        //   value:
        //     The value to write.
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     An I/O error occurred.
        public static void Write(string value);
	}
} 
```

Escribe el valor de cadena especificado, seguido del terminador de línea actual, en el flujo de salida estándar.

La palabra clave `using` se puede usar para que no se necesite el nombre completo

```c#
using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

La palabra clave `namespace` se usa para declarar un ámbito. La capacidad de crear ámbitos en su proyecto le ayuda a organizar código y le permite crear tipos únicos globalmente. [El operador . ](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/member-access-operator)se usa para diferenciar a qué método se llama.

```c#
// using ConsoleApp.DentroDePropioNameSpace;
using ConsoleApp.DentroDePropioNameSpace;
using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Istancias de los Objetos
            Humano EstoEsUnHumano = new Humano();
            ConsoleApp.DentroDePropioNameSpace.Alien EstoEsAlien = new ConsoleApp.DentroDePropioNameSpace.Alien();
            ConsoleApp.DentroDePropioNameSpace.OtraClase EstoEsOtraClase = new ConsoleApp.DentroDePropioNameSpace.OtraClase();

            EstoEsUnHumano.Saludar();
            EstoEsAlien.Saludar();
            EstoEsOtraClase.Despedirse();
        }
    }

    public class Humano
    {
        public void Saludar()
        {
            Console.WriteLine("namespace: ConsoleApp.Humano");
        }
    }

    namespace DentroDePropioNameSpace
    {
        public class Alien
        {
            public void Saludar()
            {
                Console.WriteLine("namespace: ConsoleApp.DentroDePropioNameSpace.Alien");
            }
        }

        public class OtraClase
        {
            public void Despedirse()
            {
                Console.WriteLine("namespace: ConsoleApp.DentroDePropioNameSpace.OtraClase");
            }
        }
    }
}

```

### Clases

```c#
class Program
{

}
```

Un tipo que se define como una [clase](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/class), es un *tipo de referencia*. Al declarar una variable de un tipo de referencia en tiempo de ejecución, esta contendrá el valor [null](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/null) hasta que se cree expresamente una instancia de la clase mediante el operador [new](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/new) o se le asigne un objeto de un tipo compatible que se ha creado en otro lugar, tal y como se muestra en el ejemplo siguiente:

```c#
//Declaring an object of type MyClass.
MyClass mc = new MyClass();

//Declaring another object of the same type, assigning it the value of the first object.
MyClass mc2 = mc;
```

Cuando se crea el objeto, se asigna suficiente memoria en el montón administrado para ese objeto específico y la variable solo contiene una referencia a la ubicación de dicho objeto. Los tipos del montón administrado producen sobrecarga cuando se asignan y cuando los reclama la función de administración de memoria automática de CLR, conocida como *recolección de elementos no utilizados*. En cambio, la recolección de elementos no utilizados también está muy optimizada y no crea problemas de rendimiento en la mayoría de los escenarios. Para obtener más información sobre la recolección de elementos no utilizados, vea [Administración automática de la memoria y recolección de elementos no utilizados](https://docs.microsoft.com/es-es/dotnet/standard/garbage-collection/gc).

## Declarar clases

Las clases se declaran mediante la palabra clave [class](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/class) seguida por un identificador único, como se muestra en el siguiente ejemplo:

```c#
//[Modificador de acceso] - [Clase] - [Identificador]
public class ElNombreDeMiClase
{
   // Propiedades
   // Metodos
}
```

La palabra clave `class` va precedida del nivel de acceso. Como en este caso se usa [public](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/public), cualquier usuario puede crear instancias de esta clase. El nombre de la clase sigue a la palabra clave `class`. El nombre de la clase debe ser un [nombre de identificador](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/inside-a-program/identifier-names) de C# válido. El resto de la definición es el cuerpo de la clase, donde se definen los datos y el comportamiento. Los campos, las propiedades, los métodos y los eventos de una clase se denominan de manera colectiva *miembros de clase*.a Clase Genérica?

Las clases genéricas encapsulan operaciones que no son específicas de un tipo de datos determinado. El uso más común de las clases genéricas es con colecciones como listas vinculadas, tablas hash, pilas, colas y árboles, entre otros. Las operaciones como la adición y eliminación de elementos de la colección se realizan básicamente de la misma manera independientemente del tipo de datos que se almacenan.

El *modelamiento* de una clase genérica compromete la aplicación o seguimiento de un principio básico, el de la **generalización**. Bien, hemos comprendido que las colecciones son un ejemplo fehaciente de esta aplicación. Dicho lo anterior, podemos definir a una clase genérica como un tipo de dato que posee operaciones generalizadas o independientes del tipo de dato a manipular

## Creación de objetos

Aunque a veces se usan indistintamente, una clase y un objeto son cosas diferentes. Una clase define un tipo de objeto, pero no es un objeto en sí. Un objeto es una entidad concreta basada en una clase y, a veces, se conoce como una instancia de una clase.

Los objetos se pueden crear usando la palabra clave [new](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/new), seguida del nombre de la clase en la que se basará el objeto, como en este ejemplo

```c#
Customer object1 = new Customer();
```

Cuando se crea una instancia de una clase, se vuelve a pasar al programador una referencia al objeto. En el ejemplo anterior, `object1` es una referencia a un objeto que se basa en `Customer`. Esta referencia apunta al objeto nuevo, pero no contiene los datos del objeto. De hecho, puede crear una referencia de objeto sin tener que crear ningún objeto:

```c#
Customer object2;
```

No se recomienda crear referencias de objeto como esta, que no hace referencia a ningún objeto, ya que, si se intenta obtener acceso a un objeto a través de este tipo de referencia, se producirá un error en tiempo de ejecución. Pero dicha referencia puede haberse creado para hacer referencia a un objeto, ya sea creando un nuevo objeto o asignándola a un objeto existente, como en el siguiente ejemplo:

```c#
Customer object3 = new Customer();
Customer object4 = object3;
```

Este código crea dos referencias de objeto que hacen referencia al mismo objeto. Por lo tanto, los cambios efectuados en el objeto mediante `object3` se reflejan en los usos posteriores de `object4`. Dado que los objetos basados en clases se tratan por referencia, las clases se denominan "tipos de referencia".

```c#
using System;
namespace ConsoleApp.Notas
{
    public class Persona
    {
        // Propiedades
        public string Nombre { get; }
        public string Apellido { get; }
        public string Edad { get; }

        // Constructor 
        public Persona()
        {
            Nombre = "unknown";
            Apellido = "unknown";
            Edad = "unknown";
        }

        // Constructor con argumentos
        public Persona(string NombrePersona, string ApellidoPersona, string EdadPersona)
        {
            Nombre = NombrePersona;
            Apellido = ApellidoPersona;
            Edad = EdadPersona;
        }

    }
    class TestPerson
    {
        static void Main()
        {
            // Instancia de mis objetos
            Persona per1 = new Persona();
            Persona per2 = new Persona("Maria", "Perez", "20");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
// Output:
// unknown
// Sarah Jones
// Sarah Jones
```





**Modificadores de acceso C#**

**Los modificadores de acceso (especificadores de acceso)** describen como el alcance de accesibilidad de un objeto y sus miembros. Todos los tipos de C # y miembros de tipo tienen un nivel de accesibilidad. Podemos controlar el alcance del objeto miembro de una clase utilizando especificadores de acceso. Estamos utilizando modificadores de acceso para proporcionar seguridad de nuestras aplicaciones. Cuando especificamos la accesibilidad de un tipo o miembro, debemos declararlo utilizando cualquiera de los modificadores de acceso proporcionados por el lenguaje CSharp 

- `public ` es el modificador de acceso más común en C#. Se puede acceder desde cualquier lugar, eso significa que no hay restricciones de accesibilidad. El alcance de la accesibilidad es tanto dentro como fuera de clase. Se puede acceder al tipo o miembro mediante cualquier otro código en el mismo conjunto u otro conjunto que lo haga referencia.
- `private` El alcance de la accesibilidad está limitado solo dentro de las clases o estructura en que se declaran. No se puede acceder a los miembros privados fuera de la clase y es el nivel de acceso menos permisivo.
- `protected` El alcance de la accesibilidad está limitado dentro de la clase o estructura y la clase derivada (Heredada) de esta clase.
- `internal` Los modificadores de acceso interno pueden acceder dentro del programa que contiene sus declaraciones y también acceder dentro del mismo nivel de ensamblaje pero no desde otro ensamblado.
- `protected internal`



Los internos protegidos son los mismos niveles de acceso tanto protegidos como internos. Puede acceder a cualquier parte del mismo ensamblado y en la misma clase también a las clases heredadas de la misma clase.



### Clases - Herencia

La herencia, junto con la encapsulación y el polimorfismo, es una de las tres características principales de la programación orientada a objetos. La herencia permite crear clases nuevas que reutilizan, extienden y modifican el comportamiento que se define en otras clases. La clase cuyos miembros se heredan se denomina *clase base* y la clase que hereda esos miembros se denomina *clase derivada*. Una clase derivada solo puede tener una clase base directa, pero la herencia es transitiva. Si ClaseC se deriva de ClaseB y ClaseB se deriva de ClaseA, ClaseC hereda los miembros declarados en ClaseB y ClaseA.

> **Note:** **Los structs no admiten la herencia, pero pueden implementar interfaces. Para más información, vea [Interfaces](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/interfaces/index).** 

Cuando se define una clase para que derive de otra clase, la clase derivada obtiene implícitamente todos los miembros de la clase base, salvo sus constructores y sus finalizadores. La clase derivada puede reutilizar el código de la clase base sin tener que volver a implementarlo. Puede agregar más miembros en la clase derivada. De esta manera, la clase derivada amplía la funcionalidad de la clase base.

El mecanismo de herencia es uno de los pilares fundamentales en los que se basa la programación orientada a objetos. Es un mecanismo que permite definir nuevas clases a partir de otras ya definidas de modo que si en la definición de una clase indicamos que ésta deriva de otra, entonces:

La primera - a la que se le suele llamar clase hija- será tratada por el compilador automáticamente como si su definición incluyese la definición de 

La segunda –a la que se le suele llamar clase padre o clase base. 

Las clases que derivan de otras se definen usando la siguiente sintaxis:

```c#
class <nombreHija> : <nombrePadre>
{
	<miembrosHija>
} 

```

A los miembros definidos en <miembrosHijas> se le añadirán los que hubiésemos definido en la clase padre. Por ejemplo, a partir de la clase Persona puede crearse una clase Trabajador así: