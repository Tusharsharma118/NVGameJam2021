using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_temp : MonoBehaviour
{

    public float _speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down;
        }else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up ;
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
    }
}
