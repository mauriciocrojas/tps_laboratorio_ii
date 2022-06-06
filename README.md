Pokedex App – Instrutivo:

Bienvenido a la Pokedex, una app muy intuitiva para el usuario, la cual tendrá un Login de 
ingreso, donde se podrán llenar los datos a través de los botones Cargar entrenador o Cargar 
Administrador, y en base al tipo de usuario cargado, se mostrará un Menu Principal con 
distintas funcionalidades.
Todos podrán ver la lista de pokemon registrados en la app mediante una lista con los 
nombres de los pokemon, y al hacer click en ellos, se mostrará su descripción en el 
RichTextBox de la derecha. El administrador podrá de manera exclusiva ver a los entrenadores 
registrados en la app y también agregar nuevos pokemon a la pokedex, y compartirá junto a 
los entrenadores, las opciones de ver el usuario logueado en ese momento y la de Lanzar 
ataque según el pokemon seleccionado de la lista.

Aplicación de los temas:

-Se crean dos excepciones (CamposErroneosException, CamposVaciosException) para verificar 
los datos ingresados en el Login.

-Se aplica la interfaz IDatos, la cual tiene el método MostrarDato, el cual será implementado 
en las clases Administrador, Entrenador, y Pokemon.

-Se usa Métodos de extensión en la clase Ataque, con el método LanzarAtaque, el cual
extiende un string (que será el nombre del pokemon de la lista), y lanzará el ataque de mismo.

-Se aplica Test Unitarios para probar dos métodos, uno el método de extensión LanzarAtaque, 
y otro para probar la carga manual de un pokemon ProbarCargaDeDatosManualNuevoPokemon.
 
