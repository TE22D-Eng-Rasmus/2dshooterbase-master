using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    // Start is called before the first frame update

     
    static public bool Button2= false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Button2 == true){

            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("Player2");

        foreach(GameObject go in gameObjectArray)
        {
            go.SetActive (false);
        }
        }
    }
}
