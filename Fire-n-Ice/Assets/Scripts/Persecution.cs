using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Persecution : MonoBehaviour
{

    public GameObject wall;
    public float movementSpeed= 10.0f;

    void Update()
    {

        wall.transform.position += wall.transform.forward * Time.deltaTime * movementSpeed;
    }


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "fire" || collisionInfo.collider.tag == "ice")
        {
            
            Destroy(collisionInfo.gameObject);
        }

        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log("wall collided with player");
            SceneManager.LoadScene("Track");
        }
    }
}
