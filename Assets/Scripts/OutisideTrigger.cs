using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutisideTrigger : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider obj) {

        print("Entered the store: " + obj.gameObject.name);
        
    }
    private void OnTriggerExit(Collider obj) {
        print("Left the store: " + obj.gameObject.name);
    }
}
