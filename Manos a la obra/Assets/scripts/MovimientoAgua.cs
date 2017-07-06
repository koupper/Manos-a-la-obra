using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAgua : MonoBehaviour {
    public Transform agua;
    public float maximo;
    public float minimo;
    public float velocidad;
    float actual;
    bool sube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        actual = agua.position.x;

        if (actual <= maximo)
            
        {
            sube = false;
            // agua.position = new Vector3(agua.position.x + 1F, agua.position.y, agua.position.z);
        }
        else if (actual >= minimo)
        {
            sube = true;
            //agua.position = new Vector3(agua.position.x - 1F, agua.position.y, agua.position.z);
        }
        if (sube)
        {
            agua.position = new Vector3(agua.position.x - velocidad, agua.position.y, agua.position.z);
        }
        else
        {
            agua.position = new Vector3(agua.position.x + velocidad, agua.position.y, agua.position.z);
        }
    }
	
}
