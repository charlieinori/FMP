using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelup : MonoBehaviour
{


    void OnTriggerEnter(Collider FallingPoint)
    {
        SceneManager.LoadScene("Scene3");
    }

}
