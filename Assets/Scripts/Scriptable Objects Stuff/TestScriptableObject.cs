using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Para generarlo tenemos que poner la opcion esta que nos lo agrega como una opcion al menu.
// Filename es el nombre x default del archivo, y menu name si lo quiero colocar en una carpeta x ejemplo.
[CreateAssetMenu(fileName = "TestScriptableObject" , menuName = "ScriptableObjects/TestScriptableObject")]
public class TestScriptableObject : ScriptableObject
{
    // Los scriptable objects son basicamente data containers.
    // Heredan de ScriptableObject
    public string myString;
    public int  myInt;
    public Sprite[] spriteArray;
}


/* INFO IMPORTANTE:
/   La data que usen los scritpable objects en el Editor, se guardan en el asset, 
/   ,pero luego de compilar si modifico un scriptable object, este no queda guardado.

    Por ejemplo son utiles para hacer archivos de config, o templates para pefrabs para evitar que estos carguen mucha data en memoria, ya que el scriptable object
    funciona como una referencia y no como una copia del mismo, alijerando el uso de memoria.
*/
