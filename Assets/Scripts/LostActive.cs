using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ActivateLostObject;

    public void ActivateLost(){

        ActivateLostObject.SetActive(true);
    }
}
