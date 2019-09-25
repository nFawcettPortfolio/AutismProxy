using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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

        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        }
  
    }
}
