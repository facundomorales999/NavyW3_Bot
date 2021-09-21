![UCU](https://github.com/ucudal/PII_Conceptos_De_POO/raw/master/Assets/logo-ucu.png)

# Proyecto 2021 - Primer Entrega
### FIT - Universidad Católica del Uruguay

## Notas-Tercer Entrega

- Recursos extras.

[Refactoring.Guru](https://refactoring.guru/es)

[Curso de Patrones de diseño-MitoCode-Youtube](https://www.youtube.com/watch?v=cwfuydUHZ7o&list=RDCMUC9fAeSPVw7mAAbexCS7gPqw&start_radio=1&rv=cwfuydUHZ7o&t=1&ab_channel=MitoCode)

[Patrones de Diseño, por Luis Fernandez-Youtube](https://www.youtube.com/watch?v=G4mFD16PGMg&ab_channel=DesarrolloWeb.com)

[Principio de sustitución de Liskov](https://es.wikipedia.org/wiki/Principio_de_sustituci%C3%B3n_de_Liskov)

- Los desafíos más difíciles de la entrega.

Esta entrega nos enorgullece totalmente, es una entrega cuyo crecimiento es notorio; tanto en si misma asi como de quien la escribimos.
Una entrega con mas de 300 clases y que cumple casi en su totalidad de los patrones SOLID, haciendo un buen uso de los prncipios Grasp. Dicha impronta nos permite notar como herramientas de digrama se vencen con determinada magnitud de proyecto. Asi como los comentarios clase a clase del codigo, que se encuentran ahora como documento unico en la carpeta docs; creemos tambien que esa forma de escribir sobre los patrones tiene la ventaja de la profundidad con respecto a la anterior manera empleada.

- Lo que aprendimos enfrentándonos al proyecto y no en clase.

Lo que no nos entrega la clase, pero si el proyecto, es la experiencia del desarrollo. "A programar se aprende programando". Exactamente lo mismo sucede con el trabajo en equipo, notamos la importancia de seguir trabajando para mejorar la coordinacion entre pares, y como bases siempre tener en mente; planeacion del proyecto, diagramado de una ruta a seguir, separacion de tareas y cumplimiento de las mismas.

- Sobre lo que no se pudo cumplir.

Existen algunos requerimientos que no fueron cumplidos, sentimos que era mas importante cumplir de forma profunda con los patrones, que continuar con el cumplimiento de requisitos.

Los siguientes requisitos no han sido cumplidos.

No esta implementado el comando de ataque de dos misiles.
No se puede espiar.
No maneja puntajes.
El juego no termina nunca.

Sin embargo ...

No esta implementado el comando de ataque de dos misiles, pero si toda la logica necesaria, bastaria con implementar el AbstractHandler correspondiente.
No se puede espiar, pero bastaria con agregar un eslabon a la cadena AbstractEndPhase que permitiese con el item necesario realizar un ataque espia.
No maneja puntajes, tal vez bastaria con un diccionario <AbstractPlayer, int> que se actualize segun los ataques de los usuarios.
El juego no termina nunca, pero basta con revisar tras cada ataque si el usuario ha perdio y en ese caso retirarlo de la lista de jugadores, en el momento que la lista quede con cantidad inferior a dos de personas la partida ha terminado.

Además estamos cerca de cumplir los siguientes, que no son requisitos.

No se muestra los comandos disponibles, falta agregar un comando "/help" que llame a una cadena, que dado un PlayerState retorne una lista de comandos disponibles.
Falta la implementacion de un comando que permita el cambio entre lenguages, pero esta toda la logica para hacerlo.
No se avisa el evento que se lanza, pero bastaria con enviar un mensaje tomado de una cadena que segun un lenguage revise una carpeta.

- Reflexión final.

Es una entrega que nos complace, tal vez el diagrama necesite una semana mas, tal vez los comentarios de los patrones no son clase a clase,y seguramente falten ambitos de testeo pero en terminos del tiempo que teniamos disponible, es un trabajo excelente que demuestra un conocimiento y uso profundo de los principios y patrones de diseño, y los contenidos dictados en el curso, lo que es en ultima instancia lo que importa. No estoy de acuerdo con que los resultados no importan, los resultados demuestran un camino recorrido.

