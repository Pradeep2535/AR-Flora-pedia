using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScreenBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public void MainScreen(){
        SceneManager.LoadScene("MainScene");
    }

    public void ARScene(){
        SceneManager.LoadScene("ARScene");
    }

    public void Quit(){
        Application.Quit();
    }
}
