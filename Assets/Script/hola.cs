using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hola : MonoBehaviour
{
    public int edad;
    public Text miTexto;
    // Start is called before the first frame update
    void Start()
    {
        
        if (edad >= 18)
        {
            miTexto.text = "Es mayor de edad";
        }

        else
        {
            miTexto.text = "Es menor de edad";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
