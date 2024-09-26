using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{ 
    int miVariable = 0;
    
    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 15;


    private void OnCollisionEnter(Collision infoChoque)
    {
        miVariable = miVariable + 1;


        if (miVariable == primerLogroSaltos || miVariable == segundoLogroSaltos || miVariable == tercerLogroSaltos)
        {
            Debug.Log(gameObject.name + " ha chocado " + miVariable + " veces ") ;
        }

    }
    
}
