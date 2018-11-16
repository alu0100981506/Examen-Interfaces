using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public delegate void colB();
    public static event colB onColB;

    public delegate void camCol(Color col);
    public static event camCol onCamCol;


    public Color col = Color.cyan;


    void Start () {
        GameController.onColB += fCambCol;
	}


    public static void fColB()
    {
        onColB();
    }


    public void CRosa(){

        col = Color.red;

    }

    public void CAzul()
    {
        col = Color.blue;
    }

    public void CVerde()
    {
        col = Color.green;
    }

    public void CAletorio()
    {
        col = new Color(Random.value, Random.value, Random.value);
    }
	

    void fCambCol()
    {

        onCamCol(col);

    }

}
