using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_rotation : MonoBehaviour
{
    void keyPress()
    {
        if (Input.GetKeyDown("u"))
        {
            transform.position = new Vector3(10,0,0);
        }
        if (Input.GetKeyDown("q"))
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,transform.rotation.eulerAngles.z + (-90));
        }

        if (Input.GetKeyDown("e"))
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,transform.rotation.eulerAngles.z + (-90));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyPress();
    }
}
