using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class moveCapsule : MonoBehaviour
{


//private CharacterController characterController;
 public Transform target;

 public float t;
public float speed = 5f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       //set position
       //transform.position = target.position;

if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
        }

        //move towards the target using constant speed
       Vector3 a = transform.position;
       Vector3 b = target.position;
       transform.position = Vector3.MoveTowards(a, b, t);

    


    
    
    
    }




}




