using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoC : MonoBehaviour {

	void Start () {
     
        GameController.onColB += aumentar;
	}
	
	void Update () {
		
	}

    void aumentar()
    {
        Vector3 tam = gameObject.transform.localScale + new Vector3(0.2F, 0.2F, 0.2F);
        this.gameObject.transform.localScale = tam;

    }
}
