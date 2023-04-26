using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class BirdMovment : MonoBehaviour
{
    private CharacterController Controller;
    private Vector3 Velocity;
    private bool Cooldown;

    private GameObject LookAt;
    private int speed;
    public  GameObject Cube1;
    public GameObject Cube2;


    private void Start()
    {
        Controller = gameObject.GetComponent<CharacterController>();
    }

   private void Update()
    {
        #region Movement 
        Velocity.y += -15 * Time.deltaTime;
        if (Input.GetKey("space") && Cooldown == false)
        {
            Cooldown= true;
            Velocity.y = Mathf.Sqrt(60);
            StartCoroutine(CooldownRefresh());
        }

        Controller.Move(Velocity * Time.deltaTime);
        #endregion
        #region Tilting 
        if (Velocity.y > 0)
        {
            LookAt = Cube1;
            speed = 5; 
        }
        else
        {
            LookAt= Cube2;
            speed = 10; 
             
        }
        

        Quaternion LookOnLook = Quaternion.LookRotation(-LookAt.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, LookOnLook, speed * Time.deltaTime);
        #endregion
    }

    private IEnumerator CooldownRefresh()
    {
        yield return new WaitForSeconds(0.3f);
        Cooldown= false;
    }
}  

   