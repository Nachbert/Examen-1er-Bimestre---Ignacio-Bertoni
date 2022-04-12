using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour

{
    public int campo;
    public int platea;


    // Start is called before the first frame update
    void Start()
    {
        int maxcampo = 20400;
        int maxplatea = 16200;
        int maxpredio = (maxplatea + maxcampo);
        Debug.Log("Sobraron " + (maxpredio - campo + platea));
        Debug.Log("Se vendieron un total de " + (campo + platea));

        if (campo + platea > 18299)
        {
            Debug.Log("El festival fue un éxito!");
        }

        else
        {
            Debug.Log("Debemos mejorar la convocatoria :(");
        }
       
           

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
