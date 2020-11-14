# AmazingQuotation
Entrance examination ⚡️⚡️⚡️

# Diagrama de clases
![Image of class abstract](https://github.com/zarandonlautaro/AmazingQuotation/blob/master/images/DiagramClass_UML.png)

# Cuestionario
### ¿C# permite herencia múltiple?
No, no permite herencia múltiple, pero permite implementar múltiples interfaces.

### ¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
Utilizaríamos una clase abstracta cúando necesitamos implementar métodos, ya que la interfaz no permite el uso de métodos


#### Ejemplo de clase abstracta
![Image of class abstract](https://github.com/zarandonlautaro/AmazingQuotation/blob/master/images/abstract.png)
#### Ejemplo de interfaz
![Image of class abstract](https://github.com/zarandonlautaro/AmazingQuotation/blob/master/images/interfaz.png)

### ¿Qué implica una relación de Generalización entre dos clases?
Es la relación es una relación is-a entre dos clases, obteniendo así una subclase y dicha subclase se considera especialización de la superclase.

### ¿Qué implica una relación de Implementación entre una clase y una interfaz?
La interfaz exije el "contrato" que debé cumplir la clase. Entonces la implementación es esa relación entre ambas que se debe cumplir.

### ¿Qué diferencia hay entre la relación de Composición y la Agregación?
La principal diferencia es que en la composición para que exista B debe existir A y en la agregación no son dependientes.
Por ejemplo: un edificio, no puede ser edificio sin departamentos. 

### Indique V o F según corresponda. Diferencia entre Asociación y Agregación:

Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
## [V]
Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. 
## [F]
Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 
## [F]

