using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activeobject : MonoBehaviour
{
    public GameObject activeGameObject;

    public void DeactivateObject(){

        if(activeGameObject.activeSelf == true)
        {
            activeGameObject.SetActive(false);
        }
        else{

            activeGameObject.SetActive(false);
        }
    }
}
