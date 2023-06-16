Notas sobre el tp:
En el caso de las opciones de consola para Resta, Multiplicacion, Division y Suma, dejé las clases y sus métodos unicamente porque es lo mismo que entregué en la tarea anterior, sin embargo la calculadora SOLID lo realiza de una manera más correcta y podría tranquilamente reemplazarse con eso.
Por otro lado pido disculpas si hubo alguna desprolijidad en cuanto al último punto (7), ya que no tiene demasiada lógica. Quise hacerlo algo "interactivo" y no se si se dio bien, al menos los ejercicios pedidos están hechos.


---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Puntos a desarrollar:
8- IL
intermediate language es un lenguaje ensamblador, basado en pilas, ejecutado por una máquina virtual. Tiene dentro suyo Operator Codes que son quienes mandan a hacer instrucciones al cpu básicamente. Durante la compilación de nuestros proyectos de .Net (VBasic,C#,etc) el código es convertido, a través del compilador Roslyn a código IL. Lo que ocurre después, cuando el compilador del CLR RyuJIT toma estos trozos de IL y según sea requerido, se los convierte a bytecode para la arquitectura del CPU que se esté usando y para el HW que se esté usando.

9- VES Virtual Execution System es un componente que genera una capa de abstracción sobre lo que sería el HW físico y nuestro lenguaje intermedio permitiendo, permitiendo así ejecución de codigo ensamblado de manera segura y eficiente.
CTS Common Type System es quien define de forma general los conjuntos comunes de tipos y convenciones que deben ser implementados por los compiladores de lenguajes .NET para poder interactuar con los lenguajes entre sí y sus componentes de la misma plataforma. Estandares generales para que se pueda entender entre uno y otro.
CLS Common Language Specification es un conjunto de reglas que establecen interoperabilidad común entre los lenguajes de .NET. Garantizan que los programas escritos en diferentes lenguajes sean compatibles y puedan interactuar entre sí sin problemas. También es una especificación para los compiladores (RyuJIT y Roslyn, se encarga de que sean compatibles).

10- Assembly es un archivo que contiene un conjunto de tipos y recursos como clases, estructuras, enumeraciones, interfaces, etc que pueden ser referenciados por otros programadores o bibliotecas. Es una unidad lógica y física de código reutilizable. Puede ser tanto un dll como un exe como una biblioteca de clases, tambien puede ser un .cs que es compilado en tiempo de ejecución. También incluye metadatos, versión, entre otros. Además proporcionan un límite de seguridad, una aplicación puede restringir el acceso a un assembly sólo a quienes tienen permiso para usarlo.
Early binding es cuando nosotros generamos código que ya es conocido por el compilador.
El Late binding a diferencia, el compilador no sabe lo que existe porque se modifica en tiempo de ejecución. Hasta que no se ejecuta la línea de código el compilador no se sabe lo que está pasando. La diferencia es que, si no existiese algo dentro de una línea va a explotar en tiempo de ejecución y en el early si no existe algo dentro de un método por ejemplo, el compilador nos avisa.

11 -GIT es un sistema de control de versiones distribuido que proporciona a los desarrolladores la capacidad de trabajar de forma independiente en sus copias locales mientras mantienen un historial completo y facilita la colaboración en equipo mediante operaciones de fusión y ramificación
git fetch le dice a tu git local que recupere la última información de los metadatos del original, aunque no hace ningún merge o transferencia de archivos. Es más bien como comprobar si hay algún cambio disponible. Fetch trae modificaciones pero no hace un merge, queda en la misma línea de tiempo.
git pull hace lo mismo que fetch pero con la diferencia de que si trae (copia) esos cambios del repositorio remoto. Pull sí hace el merge. Fetch queda en la misma línea de tiempo y el pull te actualiza a la última.
git branch permite crear, enumerar y eliminar ramas, así como cambiar su nombre. Pero no permite movernos entre ellas, eso lo hace git checkout
