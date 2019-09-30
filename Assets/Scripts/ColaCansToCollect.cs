using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaCansToCollect : MonoBehaviour
{
    public static int objects = 0;


    private void Awake()
    {
        objects++;
    }

    private void OnTriggerStay(Collider other)
    {
        //If "p" is pressed, pick up object and store in Array
        if (Input.GetKey("p"))
        {

            for (int i = 0; i < objects; i++)
            {
                if (Inventory.s1[i] is null)
                {
                    //create array to store gameobject names picked up
                    Inventory.s1[i] = gameObject.tag;

                    break;
                }
            }

            //remove gameobject after its added to array
             // gameObject.SetActive(false);
            Destroy(GameObject.Find(gameObject.name));

            //test
            Debug.Log("\n\n");

            for (int j = 0; j < objects; j++)
            {
                Debug.Log("Array" + j + ": " + Inventory.s1[j]);
            }
            //end test
        }
        }


    private void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

      
        
    }

}






