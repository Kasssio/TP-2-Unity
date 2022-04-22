using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{

    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text IngresoUsuario;
    public Text txtMsj;
    public GameObject cartelMsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidarContrasenia()
    {
        contraseniaUsuario = IngresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelMsj.SetActive(true);
            txtMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }

        else
        {
            cartelMsj.SetActive(true);
            txtMsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
