using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Player;

    void OnTriggerEnter(Collider FallingPoint)
    {
        Player.transform.position = teleportTarget.transform.position;
    }

}