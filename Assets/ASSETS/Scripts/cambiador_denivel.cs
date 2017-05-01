using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiador_denivel : MonoBehaviour {
    public string Escenas;
    public string Escena2;
    
       public void Jugar()
    {
        Application.LoadLevel(Escena2);
    }
    public void Salir ()
    {
        Application.Quit();
               
    }
}

















