using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutDownColaCans : MonoBehaviour
{
    public GameObject targetGameObject;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("d"))
        {
            targetGameObject = GameObject.FindGameObjectWithTag("Cola1");
            targetGameObject.SetActive(true);
        }
    }

}
 