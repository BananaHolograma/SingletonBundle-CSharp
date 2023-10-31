<p align="center">
	<img width="256px" src="https://github.com/GodotParadise/SingletonBundle-CSharp/blob/main/icon.jpg" alt="GodotParadiseSingletonBundle-CSharp logo" />
	<h1 align="center">Godot Paradise SingletonBundle-CSharp</h1>
	
[![LastCommit](https://img.shields.io/github/last-commit/GodotParadise/SingletonBundle-CSharp?cacheSeconds=600)](https://github.com/GodotParadise/SingletonBundle-CSharp/commits)
[![Stars](https://img.shields.io/github/stars/godotparadise/SingletonBundle-CSharp)](https://github.com/GodotParadise/SingletonBundle-CSharp/stargazers)
[![Total downloads](https://img.shields.io/github/downloads/GodotParadise/SingletonBundle-CSharp/total.svg?label=Downloads&logo=github&cacheSeconds=600)](https://github.com/GodotParadise/SingletonBundle-CSharp/releases)
[![License](https://img.shields.io/github/license/GodotParadise/SingletonBundle-CSharp?cacheSeconds=2592000)](https://github.com/GodotParadise/SingletonBundle-CSharp/blob/main/LICENSE.md)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat&logo=github)](https://github.com/godotparadise/SingletonBundle-CSharp/pulls)
[![](https://img.shields.io/discord/1167079890391138406.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/XqS7C34x)
</p>

[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/GodotParadise/SingletonBundle-CSharp/blob/main/README.md)

- - -

Este plugin ofrece una colección de singletons que engloban recursos y funcionalidades globales que pueden mejorar la utilidad y accesibilidad de tu juego.
- [Requerimientos](#requerimientos)
- [✨Instalacion](#instalacion)
	- [Automatica (Recomendada)](#automatica-recomendada)
	- [Manual](#manual)
	- [GDScript version](#gdscript-version)
- [Como empezar](#como-empezar)
	- [🧙‍♂️ Vector Wizard](#️-vector-wizard)
		- [Vector2 NormalizeVector(Vector2 value)](#vector2-normalizevectorvector2-value)
		- [Vector2 NormalizeDiagonalVector(Vector2 direction)](#vector2-normalizediagonalvectorvector2-direction)
		- [Vector2 NormalizeDiagonalVector(Vector2 direction)](#vector2-normalizediagonalvectorvector2-direction-1)
		- [Vector2 GenerateRandomDirection()](#vector2-generaterandomdirection)
		- [GenerateRandomAngle(float minAngleRange = 0.0f, float maxAngleRange = 360.0f)](#generaterandomanglefloat-minanglerange--00f-float-maxanglerange--3600f)
		- [GenerateRandomDirectionsOnAngleRange(Vector2 origin, float minAngleRange = 0.0f, float maxAngleRange = 360.0f, int numDirections = 10)](#generaterandomdirectionsonanglerangevector2-origin-float-minanglerange--00f-float-maxanglerange--3600f-int-numdirections--10)
		- [Vector2 TranslateXAxisToVector(float axis)](#vector2-translatexaxistovectorfloat-axis)
		- [float DistanceManhattanV2(Vector2 a, Vector2 b)](#float-distancemanhattanv2vector2-a-vector2-b)
		- [float DistanceChebysevV2(Vector2 a, Vector2 b)](#float-distancechebysevv2vector2-a-vector2-b)
		- [float LengthManhattanV2(Vector2 a)](#float-lengthmanhattanv2vector2-a)
		- [float LengthChebysevV2(Vector2 a, Vector2 b)](#float-lengthchebysevv2vector2-a-vector2-b)
		- [Vector2 ClosestPointOnLineClampedV2(Vector2 a, Vector2 b, Vector2 c)](#vector2-closestpointonlineclampedv2vector2-a-vector2-b-vector2-c)
		- [Vector2 ClosestPointOnLineV2(Vector2 a, Vector2 b, Vector2 c)](#vector2-closestpointonlinev2vector2-a-vector2-b-vector2-c)
		- [float DistanceManhattanV3(Vector3 a, Vector3 b)](#float-distancemanhattanv3vector3-a-vector3-b)
		- [float DistanceChebysevV3(Vector3 a, Vector3 b)](#float-distancechebysevv3vector3-a-vector3-b)
		- [float LengthManhattanV3(Vector3 a)](#float-lengthmanhattanv3vector3-a)
		- [float LengthChebysevV3(Vector3 a, Vector3 b)](#float-lengthchebysevv3vector3-a-vector3-b)
		- [Vector3 ClosestPointOnLineClampedV3(Vector3 a, Vector3 b, Vector3 c)](#vector3-closestpointonlineclampedv3vector3-a-vector3-b-vector3-c)
		- [Vector3 ClosestPointOnLineV3(Vector3 a, Vector3 b, Vector3 c)](#vector3-closestpointonlinev3vector3-a-vector3-b-vector3-c)
		- [float ClosestPointOnLineNormalizedV3(Vector3 a, Vector3 b, Vector3 c)](#float-closestpointonlinenormalizedv3vector3-a-vector3-b-vector3-c)
	- [🕶️ General utilities](#️-general-utilities)
		- [string GenerateRandomString(int length, string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")](#string-generaterandomstringint-length-string-characters--abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz0123456789)
		- [bool IsValidUrl(string url)](#bool-isvalidurlstring-url)
		- [async void StartFrameFreeze(double timeScale, double duration)](#async-void-startframefreezedouble-timescale-double-duration)
	- [⚙️ Environment variables](#️-environment-variables)
		- [Variable tracker](#variable-tracker)
		- [Ejemplo de uso](#ejemplo-de-uso)
		- [Cargando variables de otros archivos](#cargando-variables-de-otros-archivos)
		- [Señales](#señales)
		- [string GetVar(string key)](#string-getvarstring-key)
		- [string GetVarOrNull(string key)](#string-getvarornullstring-key)
		- [void SetVar(string key, string value = "")](#void-setvarstring-key-string-value--)
		- [void RemoveVar(string key)](#void-removevarstring-key)
		- [void CreateEnvironmentFile(string filename = ".env", bool overwrite = false)](#void-createenvironmentfilestring-filename--env-bool-overwrite--false)
		- [LoadEnvFile(filename: String = ".env") -\> void](#loadenvfilefilename-string--env---void)
		- [void FlushEnvironmentVariables(string filename = ".env", Array except = null)](#void-flushenvironmentvariablesstring-filename--env-array-except--null)
		- [void AddVarToFile(string filename, string key, string value = "")](#void-addvartofilestring-filename-string-key-string-value--)
	- [🎬 Scene transitioner](#-scene-transitioner)
		- [Transicionar con una pantalla de carga intermedia](#transicionar-con-una-pantalla-de-carga-intermedia)
		- [GodotParadiseSceneTransicioner](#godotparadisescenetransicioner)
			- [TransitionTo(string scene, string transition, TransitionData data)](#transitiontostring-scene-string-transition-transitiondata-data)
			- [void TransitionToWithLoading(string scene, string loadingScene, TransitionData data)](#void-transitiontowithloadingstring-scene-string-loadingscene-transitiondata-data)
		- [GodotParadiseSceneTransition](#godotparadisescenetransition)
			- [Variables](#variables)
			- [Señales](#señales-1)
	- [🎵 Audio](#-audio)
		- [Variables accessibles](#variables-accessibles)
		- [void ChangeVolume(dynamic bus, float value)](#void-changevolumedynamic-bus-float-value)
		- [float GetActualVolumeDBFromBusName(string name)](#float-getactualvolumedbfrombusnamestring-name)
		- [float GetActualVolumeDBFromBusIndex(int busIndex)](#float-getactualvolumedbfrombusindexint-busindex)
		- [Functional Example:](#functional-example)
- [✌️Eres bienvenido a](#️eres-bienvenido-a)
- [🤝Normas de contribución](#normas-de-contribución)
- [📇Contáctanos](#contáctanos)

# Requerimientos
📢 No ofrecemos soporte para Godot 3+ ya que nos enfocamos en las versiones futuras estables a partir de la versión 4.
* Godot 4+

# ✨Instalacion
## Automatica (Recomendada)
Puedes descargar este plugin desde la [Godot asset library](https://godotengine.org/asset-library/asset/2039) oficial usando la pestaña AssetLib de tu editor Godot. Una vez instalado, estás listo para empezar
## Manual 
Para instalar manualmente el plugin, crea una carpeta **"addons"** en la raíz de tu proyecto Godot y luego descarga el contenido de la carpeta **"addons"** de este repositorio
## GDScript version
Este plugin también ha sido escrito en GDScript, puedes encontrarlo en [SingletonBundle](https://github.com/GodotParadise/SingletonBundle)

# Como empezar
Cada singleton está separado por un nombre de clase que define su utilidad. Estas clases son autocargadas por Godot y añadidas a la escena raíz para que estén disponibles globalmente en todas las escenas de tu proyecto.

## 🧙‍♂️ Vector Wizard
Un conjunto de útiles utilidades vectoriales que probablemente utilices en tu trabajo diario como desarrollador de juegos. Las funciones que están marcadas como `v2` significa que se aplica a `Vector2` y `v3` que se aplica a `Vector3`. Si las funciones v3 **no tienen descripción**, significa que hacen exactamente lo mismo pero aplicado en un espacio tridimensional.

### Vector2 NormalizeVector(Vector2 value)
Normaliza el vector sólo si no está normalizado y también cambia si es un vector diagonal y hace la normalización adecuada. Devuelve el vector

`GodotParadiseVectorWizard.NormalizeVector(Vector2(30, -40)) # returns Vector2(1, -1)`

### Vector2 NormalizeDiagonalVector(Vector2 direction)
Un vector diagonal requiere un tratamiento adicional, que se puede aplicar usando esta función:

`GodotParadiseVectorWizard.NormalizeDiagonalVector(Vector2(-0.7444, 0.7444))`

### Vector2 NormalizeDiagonalVector(Vector2 direction)

Realiza una comprobación básica y devuelve si la dirección pasada como parámetro es diagonal. Esta función es utilizada internamente por la función `normalize_diagonal_vector`.

`GodotParadiseVectorWizard.NormalizeDiagonalVector(Vector2(-0.7444, 0.7444))`

### Vector2 GenerateRandomDirection()
Simple generador aleatorio de dirección `Vector2`, usa esta función si necesitas una dirección aleatoria en algún comportamiento de tu juego. El resultado es normalizado

### GenerateRandomAngle(float minAngleRange = 0.0f, float maxAngleRange = 360.0f)
Genera un ángulo aleatorio entre un rango proporcionado, la unidad está en grados:
```csharp
# Between 90º and 120º
GodotParadiseVectorWizard.generate_random_angle(90, 120) # 117º
```

### GenerateRandomDirectionsOnAngleRange(Vector2 origin, float minAngleRange = 0.0f, float maxAngleRange = 360.0f, int numDirections = 10)
Esta función genera **n** direcciones aleatorias en formato Array[Vector2] a partir de un punto vectorial inicial que define los ángulos mínimo y máximo:

```csharp
# 5 Random directions from Vector down (0, 1) between 90º and 180º
GodotParadiseVectorWizard.GenerateRandomDirectionsOnAngleRange(Vector2.Down, 90.0f, 180.0f, 5)

# 25 random directions from the actual player global position between 0 and 360º
GodotParadiseVectorWizard.GenerateRandomDirectionsOnAngleRange(player.GlobalPosition, 0.0f, 360.0f, 25)
```

### Vector2 TranslateXAxisToVector(float axis)
Traduce un valor decimal que suele venir de obtener el valor del eje con [Input.GetAxis](https://docs.godotengine.org/en/stable/classes/class_input.html#class-input-method-get-axis) en una dirección Vector2
`Vector2 horizontalDirection = GodotParadiseVectorWizard.TranslateXAxisToVector(Input.GetAxis("ui_left", "ui_right"))`

### float DistanceManhattanV2(Vector2 a, Vector2 b)
También conocida como "distancia de ciudad" o "distancia L1". Mide la distancia entre dos puntos como la suma de las diferencias absolutas de sus coordenadas en cada dimensión.

*Ejemplos de dónde puede ser útil:*

**Ruta de un personaje en un laberinto:** En un juego de laberintos, puedes utilizar la distancia Manhattan para calcular la distancia entre la posición actual de un personaje y una posible salida. Esto te ayudará a determinar la dirección en la que debe moverse el personaje para llegar a la salida con el menor número de movimientos, ya que sólo permite movimientos en línea recta, como arriba, abajo, izquierda y derecha.

**Puzzle deslizante:** En los juegos de puzzle en los que debes mover piezas para resolver un puzzle, la distancia Manhattan se utiliza para calcular lo lejos que está una pieza de su posición objetivo. Cuanto más cerca esté una pieza de su posición correcta, más "encajará" en el puzzle.

### float DistanceChebysevV2(Vector2 a, Vector2 b)
También conocida como la "distancia del ajedrez" o "distancia L∞".
Mide la distancia entre dos puntos como la mayor de las diferencias absolutas de sus coordenadas en cada dimensión.

*Ejemplos de dónde puede ser útil:*

**Movimiento de un rey en ajedrez:** En una partida de ajedrez, el rey se mueve en cualquier dirección *(horizontal, vertical o diagonal)*. La distancia de Chebyshev se utiliza para determinar cuántos movimientos necesita el rey para moverse desde su posición actual hasta una casilla objetivo, ya que el rey puede moverse en cualquiera de estas direcciones.

**Movimiento en un juego de estrategia por turnos:** En un juego de estrategia por turnos, como Civilization, en el que las unidades pueden moverse en varias direcciones, la distancia de Chebyshev puede utilizarse para calcular la distancia entre dos lugares del mapa y determinar cuántos turnos se tardaría en ir de uno a otro.

### float LengthManhattanV2(Vector2 a)
La función `LengthManhattanV2` calcula la longitud o magnitud de un vector bidimensional a utilizando la distancia Manhattan. La distancia Manhattan se determina sumando las diferencias absolutas de las coordenadas x e y del vector. El resultado es un valor escalar que representa la distancia total recorrida en términos de movimientos verticales y horizontales, lo que resulta útil en situaciones en las que los movimientos se producen en líneas rectas a lo largo de ejes ortogonales.

### float LengthChebysevV2(Vector2 a, Vector2 b)
La función `LengthChebysevV2` calcula la longitud o magnitud de un vector bidimensional a utilizando la distancia de Chebyshev. La distancia de Chebyshev se determina tomando el máximo de las diferencias absolutas entre las coordenadas x e y del vector. El resultado es un valor escalar que representa la distancia máxima recorrida en términos de movimientos en cualquier dirección, ya sea vertical, horizontal o diagonal. Esta métrica es útil en situaciones en las que pueden producirse movimientos en múltiples direcciones.

### Vector2 ClosestPointOnLineClampedV2(Vector2 a, Vector2 b, Vector2 c)
Esta función está diseñada específicamente para encontrar el punto más cercano en un segmento de línea, asegurando que el resultado se encuentra dentro de los límites del segmento. Resulta especialmente útil en situaciones en las que es esencial restringir el punto más cercano a la línea. 

Por ejemplo, en una aplicación de dibujo, puede emplear esta función para ajustar con precisión un punto a la posición más cercana de una línea al crear dibujos a mano alzada.

### Vector2 ClosestPointOnLineV2(Vector2 a, Vector2 b, Vector2 c)
A diferencia de la función `ClosestPointOnLineClampedV2`, esta variante está pensada para identificar el punto más cercano en un segmento de línea sin imponer ninguna restricción sobre su ubicación dentro o fuera del segmento. Esto la hace versátil en situaciones en las que se necesita encontrar el punto más cercano en una línea pero no se requiere que esté confinado en el segmento. 

Por ejemplo, en una aplicación CAD, puede utilizar esta función para localizar el punto más cercano de una línea de croquis a un punto definido por el usuario.

### float DistanceManhattanV3(Vector3 a, Vector3 b)
### float DistanceChebysevV3(Vector3 a, Vector3 b)
### float LengthManhattanV3(Vector3 a)
### float LengthChebysevV3(Vector3 a, Vector3 b)
### Vector3 ClosestPointOnLineClampedV3(Vector3 a, Vector3 b, Vector3 c)
### Vector3 ClosestPointOnLineV3(Vector3 a, Vector3 b, Vector3 c)
### float ClosestPointOnLineNormalizedV3(Vector3 a, Vector3 b, Vector3 c)

## 🕶️ General utilities
Utilidades que no tienen un lugar en particular y pertenecen a un ámbito mas global.

### string GenerateRandomString(int length, string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
Puede utilizar esta función para generar una cadena aleatoria con una longitud y una lista de caracteres especificadas. Por ejemplo, puede utilizar esta función para crear códigos de invitación para sus salas multijugador:

`string invitationCode = GodotParadiseUtilities.GenerateRandomString(4, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789") # returns YMZ2`

### bool IsValidUrl(string url)
Como la clase String de Godot carece de esta validación puedes usar la siguiente:

`GodotParadiseUtilities.IsValidUrl("https://example.com") # true`

### async void StartFrameFreeze(double timeScale, double duration)
Para conseguir un efecto de cámara lenta puedes utilizar esta función que recibe la escala de tiempo *(como pasa el tiempo fotograma a fotograma)* y la duración de la congelación en segundos.

Aqui puedes ver un ejemplo de como iniciar un frame freeze al personaje saltar:
```csharp
public void handleJump():
	if (Input.IsActionJustPressed("jump")) {
		player.Jump();
		GodotParadiseUtilities.StartFrameFreeze(0.05, 1);
	}
```

`FrameFreezed` se emite cuando se inicia el efecto en caso de que quieras escucharla para realizar otras acciones como disparar animaciones.
 Aqui puedes ver un ejemplo básico:
 ```csharp
public override _Ready():
	GodotParadiseUtilities.StartFrameFreeze += OnFrameFreezed;

private void OnFrameFreezed():
	AnimatedSprite.Play("juicy_hurt")
	 //...
 ```
## ⚙️ Environment variables
Para mantener la seguridad de las variables de entorno, evita codificar información sensible en tu código fuente. Mediante el uso de variables de entorno, puede garantizar que dicha información permanezca protegida.

Las variables de entorno proporcionan un método estandarizado y crucial para gestionar eficazmente la información sensible dentro de sus proyectos de software. Estas variables sirven como un repositorio seguro para almacenar una amplia gama de datos confidenciales, incluyendo pero no limitado a claves API, tokens de acceso, credenciales de bases de datos y ajustes de configuración.

Puede acceder a todas las funciones utilizando la clase `GodotParadiseEnvironment` en cualquier parte de su código. Esta clase proporciona una funcionalidad extra manteniendo la compatibilidad con `OS.GetEnvironment()` y `OS.SetEnvironment()` para la gestión de variables en tiempo de ejecución.
Por defecto, esta clase busca los archivos `.env` en la raíz de tu proyecto `res://` Para modificar esta ruta, puedes usar:

`GodotParadiseEnvironment.EnvironmentFilesPath = "res://project"`

o definir el valor de la ruta en ***Project settings -> GodotEnv -> Root directory:***
![godotenv_settings](https://github.com/GodotParadise/SingletonBundle/blob/main/images/godotenv_settings.png)

### Variable tracker
Por conveniencia de ejecución interna, el plugin rastrea las variables activas sin almacenar sus valores en un array, ya que almacenar contenido sensible en este array puede arriesgar fugas de datos o accesos no autorizados. Este enfoque permite verificar qué variables se han leído y cargado en memoria sin exponer sus valores:

`GodotParadiseEnvironment.EnvironmentVariableTracker # could return ["ADDRESS", "PORT", "SERVER_ID]`

### Ejemplo de uso
```csharp
// .env file
ADDRESS=127.0.0.1
PORT=9492

SERVER_ID=1919

// random_script.cs
GodotParadiseEnvironment.LoadEnvFile(".env")

GodotParadiseEnvironment.GetVar("PORT") // Returns an empty string if does not exists
// or
GodotParadiseEnvironment.GetVarOrNull("PORT") // Returns null instead
```

**Sólo necesitas cargar tus variables de entorno una vez**, y no hay necesidad de cargarlas en cada función `_ready()` de tus nodos. Si tienes variables duplicadas, el valor utilizado será el de la última ocurrencia. Por lo tanto, es importante revisar tus archivos cuidadosamente para evitar sobreescrituras involuntarias.

```dotenv
ADDRESS=127.0.0.1
ADDRESS=192.168.1.55 # Esta será asignada y sobreescribirá a la anterior
```

### Cargando variables de otros archivos
Esta clase soporta la lectura de múltiples archivos de entorno. Para producción, es altamente recomendable abstenerse de incluir el archivo `.env` en su repositorio de código fuente. En su lugar, considere proporcionar en el repositorio un archivo `.env.example` con valores en blanco para las claves utilizadas. Esta estrategia le permite duplicar el archivo e introducir los valores en su entorno local, evitando así la exposición involuntaria de información sensible.
```csharp
// .env.example
ADDRESS=
PORT=
SERVER_NAME=

// random_script.cs
GodotParadiseEnvironment.LoadEnvFile(".env.example")
GodotParadiseEnvironment.LoadEnvFile(".env.dev")
GodotParadiseEnvironment.LoadEnvFile(".env.staging")
// ...
```

### Señales
```csharp
VariableAdded(string key)
VariableRemoved(string key)
VariableReplaced(string key)
EnvFileLoaded(string filename)
```
### string GetVar(string key)
Esta es una alternativa a `OS.GetEnvironment(key)` : 

`GodotParadiseEnvironment.GetVar("SERVER_PORT")`

### string GetVarOrNull(string key)
Obtiene el valor de la variable de entorno por su nombre o nulo si no existe:

`GodotParadiseEnvironment.GetVarOrNull("SERVER_PORT")`

### void SetVar(string key, string value = "")
Define una variable de entorno en tiempo de ejecución, es una alternativa a
 `OS.SetEnvironment(key, value)`:

`GodotParadiseEnvironment.SetVar("API_KEY", "991918291921")`

### void RemoveVar(string key)
Elimina una variable de entorno en teimpo de ejecución:

`GodotParadiseEnvironment.RemoveVar("API_KEY")`

### void CreateEnvironmentFile(string filename = ".env", bool overwrite = false)
Create un archivo de variables de entorno con el nombre especificado. Si ya existe, puede ser sobreescrito de forma opcional
```csharp
GodotParadiseEnvironment.CreateEnvironmentFile(".env")
GodotParadiseEnvironment.AddVarToFile("env", "PORT", 3000)
GodotParadiseEnvironment.AddVarToFile("env", "ENCRYPTION_ALGORITHM", 'SHA256')
```

### LoadEnvFile(filename: String = ".env") -> void
Lee un archivo `.env` y obtiene las variables de entorno para ser accessibles en el código:

`GodotParadiseEnvironment.LoadEnvFile(".env.example")`

### void FlushEnvironmentVariables(string filename = ".env", Array<string> except = null)
Elimina todas las variables actuales. Puedes añadir las claves que no quieres que sean borradas en este proceso como segundo parámetro:

```csharp
GodotParadiseEnvironment.FlushEnvironmentVariables(".env")
GodotParadiseEnvironment.FlushEnvironmentVariables(".env", ["IP_ADDRESS", "COUNTRY"])
```

### void AddVarToFile(string filename, string key, string value = "")
Añade un clave-valor al archivo de variables de entorno y la hace accessible al momento:
```csharp
GodotParadiseEnvironment.AddVarToFile("env", "PORT", 4500)
GodotParadiseEnvironment.AddVarToFile("env", "APP_NAME", 'FightingTournament')
```

## 🎬 Scene transitioner

Este manejador facilita transiciones fluidas entre escenas, ofreciendo la opción de incluir una pantalla de carga, particularmente útil para escenas más grandes.

Se puede acceder al singleton a través de `GodotParadiseSceneTransitioner`. Este gestor utiliza la clase fundacional GodotParadiseSceneTransition para gestionar las transiciones entre escenas.

Para utilizar eficazmente este sistema, es necesario crear las escenas de transición ampliando la clase fundacional `GodotParadiseSceneTransition`.

Estas escenas de transición deben incorporar las señales y parámetros esenciales necesarios para una integración perfecta con el singleton.

El `GodotParadiseSceneTransition` funciona principalmente como un contenedor para gestionar parámetros adicionales y emitir las señales apropiadas. 
Por ejemplo, considere un caso de uso real, como una escena de fundido en la que puede especificar el nombre de la animación para elegir entre distintos tipos de fundidos *(por ejemplo, `fade_in` o `fade_out`)*.

```csharp
// Esta es tu escena de transición

public partial class YourTransitionScene : GodotParadiseSceneTransition {

	public AnimationPlayer animationPlayer;

	public override _Ready() {
		animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		animationPlayer.Play(data["animation"])

		animationPlayer.AnimationFinished += OnAnimationFinished;
	}

	private void OnAnimationFinished(string name) {
		if(AnimationPlayer.GetAnimationList().Contains(name)) {
			EmitSignal(SignalName.FinishedTransition, data);
			QueueFree();
		}
	}
}
```

Esto es un ejemplo de como usar el transicionador, el parámetro `TargetScene` puede ser proporcionado como una `PackedScene` o un `file path` en formato string:
```csharp
PackedScene TargetScene = ResourceLoader.Load<PackedScene>("res://example.tscn") # or raw string "res://example.tscn"
PackedScene yourTransitionScene = ResourceLoader.Load<PackedScene>("res://transitions/fade.tscn")

GodotParadiseSceneTransitioner.TransitionTo(target_scene, yourTransitionScene, new(){{"animation", "fade_in"}})
```
Es importante señalar que la señal `FinishedTransition` debe emitirse manualmente. Esta elección de diseño proporciona flexibilidad para determinar con precisión cuándo una transición se considera completa.

### Transicionar con una pantalla de carga intermedia
Esta clase ofrece una función diseñada para trabajar con una pantalla de carga como transición. Para utilizar esta funcionalidad, tu escena de carga personalizada también debe extender de `GodotParadiseSceneTransition` para recibir datos de progresión. 

***En este caso, la señal `FinishedTransition` se emite después de que el valor de progreso llegue a 1 cuando la carga de la escena se haya completado.***

Esta característica es especialmente beneficiosa para escenas grandes en las que los tiempos de carga pueden ser más largos. Al proporcionar la escena, debe pasarse como una ruta de archivo, ya que nuestra clase aprovecha internamente el [ResourceLoader](https://docs.godotengine.org/en/stable/classes/class_resourceloader.html)

```csharp
PackedScene TargetScene = ResourceLoader.Load<PackedScene>("res://large_scene_example.tscn") # or raw string "res://example.tscn"
PackedScene loadingScene = ResourceLoader.Load<PackedScene>("res://transitions/loading.tscn")

GodotParadiseSceneTransitioner.TransitionToWithLoading(target_scene, loading)
```

En la escena de carga, se obtiene acceso a los datos de progreso y estado de carga recuperados del [ResourceLoader](https://docs.godotengine.org/en/stable/classes/class_resourceloader.html), que se pueden utilizar para mostrar información relevante. A continuación se muestra un ejemplo básico para demostrar esta funcionalidad.
Para asegurar un funcionamiento correcto, es esencial llamar a la función padre `base._Process()`; si no lo haces, la información no se actualizará:

```csharp
// res://transitions/loading.tscn
public partial class YourLoadingTransitionScene : GodotParadiseSceneTransition {
	ProgressBar progressBar;

	public override _Ready() {
		progressBar = GetNode<ProgressBar>("CenterContainer/ProgressBar");
	}

	public override void _Process(double delta) {
		base._Process(delta);
		progressBar.Value = progress[0];
	}
}

```
### GodotParadiseSceneTransicioner
#### TransitionTo(string scene, string transition, TransitionData data)

La función principal responsable de iniciar la transición a la escena de destino es la función `TransitionTo`. Cualquier dato pasado a esta función será accesible dentro de la escena de transición, permitiendo la incorporación de parámetros externos según sea necesario.

Está enfocada a la transición de escenas precargadas.

El parámetro `scene` puede ser proporcionado como `PackedScene` o un `file path` en formato string.

Cabe destacar que la escena de transición se añade al viewport, no al árbol de escenas. Este enfoque garantiza que la transición se ejecute incluso si se liberan nodos del árbol principal.

#### void TransitionToWithLoading(string scene, string loadingScene, TransitionData data)
Se comporta de forma idéntica a `TransitionTo`, pero con una distinción clave: el parámetro de escena debe proporcionarse como una cadena de ruta de archivo. Este requisito se debe a que el transicionador utiliza [ResourceLoader](https://docs.godotengine.org/en/stable/classes/class_resourceloader.html) para cargar la escena.


### GodotParadiseSceneTransition
#### Variables
- public TransitionData Data;
- public Array Progress;
- public ResourceLoader.ThreadLoadStatus LoadStatus

```py
enum  ThreadLoadStatus:

● THREAD_LOAD_INVALID_RESOURCE = 0
#The resource is invalid, or has not been loaded with load_threaded_request().
● THREAD_LOAD_IN_PROGRESS = 1
# The resource is still being loaded.
● THREAD_LOAD_FAILED = 2
# Some error occurred during loading and it failed.
● THREAD_LOAD_LOADED = 3
# The resource was loaded successfully and can be accessed via load_threaded_get().
```
`TransitionData` es una clase customizada que permite transportar parámetros de forma fácil  en las transiciones:

```csharp
public record TransitionData
{
    public string ScenePath { get; set; } = string.Empty;
    public string TargetScene { get; set; } = string.Empty;
    public bool IsLoadingScreen { get; set; } = false;

    public TransitionData(string scenePath, string targetScene, bool isLoadingScreen = false)
    {
        ScenePath = scenePath;
        TargetScene = targetScene;
        IsLoadingScreen = isLoadingScreen;
    }

    public Dictionary ToDictionary()
    {
        return new() {
            { "scenePath", ScenePath },
            { "targetScene", TargetScene },
            { "isLoadingScreen", IsLoadingScreen }
         };
    }
}
```
#### Señales
- *StartedTransition(Dictionary data)*
- *FinishedTransition(Dictionary data, PackedScene nextScene)* `NextScene` solo es proporcionada en `TransitionToWithLoading`

## 🎵 Audio
Varias funciones de ayuda para gestionar los niveles de volumen de varios buses en tu juego.

### Variables accessibles
- public Array<string> AvailableBuses

Aqui está disponible en formato array una lista de los nombres de los buses definidos en tu proyecto

```csharp
GodotParadiseAudioManager.AvailableBuses # returns ["Master", "Music", "SFX"]
```

### void ChangeVolume(dynamic bus, float value)
Cambia el volumen del `BusIndex` seleccionado si existe. Puede recibir el parametro como un string o un indice numerico.

```csharp
GodotParadiseAudioManager.ChangeVolume(1, 0.5f)
# or
GodotParadiseAudioManager.ChangeVolume("Music", 0.5f)
```
### float GetActualVolumeDBFromBusName(string name)
Obtiene el valor actual del bus seleccionado por nombre. Si el bus no existe en proyecto levantará un error y retornará un valor de 0.0

```csharp
GodotParadiseAudioManager.GetActualVolumeDBFromBusName("Music")
```

### float GetActualVolumeDBFromBusIndex(int busIndex)
Obtiene el valor actual del bus seleccionado por indice numerico
```csharp
GodotParadiseAudioManager.GetActualVolumeDBFromBusIndex(1)
# or
GodotParadiseAudioManager.GetActualVolumeDBFromBusIndex(AudioServer.GetBusIndex("Music"))
```

### Functional Example: 
Vamos a demostrar cómo estas funciones pueden ayudarnos en la gestión de audio dentro de nuestro juego:

```csharp
public partial class YourUIScene : Control {
	HSlider Music;
	HSlider SFX;

	public override _Ready() {
		Music = GetNode<HSlider>("Parameters/VBoxContainer/HorizontalContainer/Sliders/Music");

		SFX = GetNode<HSlider>("Parameters/VBoxContainer/HorizontalContainer/Sliders/SFX");

		Music.Value = GodotParadiseAudioManager.GetActualVolumeDBFromBusName("Music")
		SFX.Value = GodotParadiseAudioManager.GetActualVolumeDBFromBusName("SFX")
	}

	private void OnMusicValueChanged(float value) {
		GodotParadiseAudioManager.ChangeVolume("Music", value)
	}

	private void OnMusicValueChanged(float value) {
		GodotParadiseAudioManager.ChangeVolume("SFX", value)
	}
}
```

# ✌️Eres bienvenido a
- [Give feedback](https://github.com/GodotParadise/SingletonBundle-CSharp/pulls)
- [Suggest improvements](https://github.com/GodotParadise/SingletonBundle-CSharp/issues/new?assignees=BananaHolograma&labels=enhancement&template=feature_request.md&title=)
- [Bug report](https://github.com/GodotParadise/SingletonBundle-CSharp/issues/new?assignees=BananaHolograma&labels=bug%2C+task&template=bug_report.md&title=)

GodotParadise esta disponible de forma gratuita.

Si estas agradecido por lo que hacemos, por favor, considera hacer una donación. Desarrollar los plugins y contenidos de GodotParadise requiere una gran cantidad de tiempo y conocimiento, especialmente cuando se trata de Godot. Incluso 1€ es muy apreciado y demuestra que te importa. ¡Muchas Gracias!

- - -
# 🤝Normas de contribución
**¡Gracias por tu interes en GodotParadise!**

Para garantizar un proceso de contribución fluido y colaborativo, revise nuestras [directrices de contribución](https://github.com/godotparadise/SingletonBundle-CSharp/blob/main/CONTRIBUTING.md) antes de empezar. Estas directrices describen las normas y expectativas que mantenemos en este proyecto.

**📓Código de conducta:** En este proyecto nos adherimos estrictamente al [Código de conducta de Godot](https://godotengine.org/code-of-conduct/). Como colaborador, es importante respetar y seguir este código para mantener una comunidad positiva e inclusiva.
- - -


# 📇Contáctanos
Si has construido un proyecto, demo, script o algun otro ejemplo usando nuestros plugins haznoslo saber y podemos publicarlo en este repositorio para ayudarnos a mejorar y saber que lo que hacemos es útil.
