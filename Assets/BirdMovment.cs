using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovment : MonoBehaviour
{
    private CharacterController Controller;
    private Vector3 Velocity;
    private bool Cooldown;

    void Start()
    {
        Controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        #region Movement 
        Velocity.y += -15 * Time.deltaTime;
        if (Input.GetKey(" space ") && Cooldown == false)
        {
            Cooldown= true;
            Velocity.y = Mathf.Sqrt(60);
            StartCoroutine(CooldownRefresh());
        }
        #endregion

    }

    private IEnumerator CooldownRefresh()
    {
        yield return new WaitForSeconds(0.3f);
        Cooldown= false;
    }
}  

   