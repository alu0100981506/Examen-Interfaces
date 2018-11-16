using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoA : MonoBehaviour {

	// Use this for initialization
	void Start () {
       GameController.onCamCol += cambiarColor;
            
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "TipoB")
        {
            Debug.Log("Colision A con B");

            GameController.fColB();

        }


    }

    void cambiarColor(Color col)
    {

        Renderer rend;
        rend = GetComponent<Renderer>();
        rend.material.color = col;

    }

}
