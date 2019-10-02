using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameobj1;
    public GameObject gameobj2;
    public GameObject gameobj3;
    public GameObject gameobj4;
    public GameObject gameobj5;

    [SerializeField]
    private float _speed = 3f;

    [SerializeField]
    private float _rotationSpeed = 120f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Rotate(transform.rotation.x, input * Time.deltaTime * _rotationSpeed, transform.rotation.z);

        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        }

        //Dennis D

        if (Input.GetKey("1"))
        {
            Vector3 position = transform.position;

            for (int j = 0; j < Inventory.s1.Length; j++)
            {
               
                if (gameobj1.tag.Equals(Inventory.s1[j]))
                {
                    GameObject newGO = Instantiate(gameobj1);
                    newGO.transform.position = position;
                    Inventory.s1[j] = null;
                }
            }
        }

        if (Input.GetKey("2"))
        {
            Vector3 position = transform.position;
        
            for (int j = 0; j < Inventory.s1.Length; j++)
            {

                if (gameobj2.tag.Equals(Inventory.s1[j]))
                {
                    GameObject newGO = Instantiate(gameobj2);
                    newGO.transform.position = position;
                    Inventory.s1[j] = null;
                }
            }
        }

        if (Input.GetKey("3"))
        {
            Vector3 position = transform.position;

            for (int j = 0; j < Inventory.s1.Length; j++)
            {

                if (gameobj3.tag.Equals(Inventory.s1[j]))
                {
                    GameObject newGO = Instantiate(gameobj3);
                    newGO.transform.position = position;
                    Inventory.s1[j] = null;
                }
            }
        }

        if (Input.GetKey("4"))
        {
            Vector3 position = transform.position;
       
            for (int j = 0; j < Inventory.s1.Length; j++)
            {

                if (gameobj4.tag.Equals(Inventory.s1[j]))
                {
                    GameObject newGO = Instantiate(gameobj4);
                    newGO.transform.position = position;
                    Inventory.s1[j] = null;
                }
            }
        }

        if (Input.GetKey("5"))
        {
            Vector3 position = transform.position;
     
            for (int j = 0; j < Inventory.s1.Length; j++)
            {

                if (gameobj5.tag.Equals(Inventory.s1[j]))
                {
                    GameObject newGO = Instantiate(gameobj5);
                    newGO.transform.position = position;
                    Inventory.s1[j]= null;
                }
            }
        }



    }

    void CheckIt(string ObjName)
    {
          
       
    }
}

internal class newGo
{
}