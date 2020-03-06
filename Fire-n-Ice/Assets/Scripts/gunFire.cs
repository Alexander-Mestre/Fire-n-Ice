using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunFire : MonoBehaviour
{

   // Start is called before the first frame update
   void Start()
    {

   }

    // Update is called once per frame
    void Update()
    {
      AudioSource[] sounds = GetComponents<AudioSource>();
      AudioSource iceSound = sounds[0];
      AudioSource fireSound = sounds[1];
      if (Input.GetMouseButtonDown(0))
      {
         iceSound.Play();
         GetComponent<Animation>().Play("gunShot");
      }
      if (Input.GetMouseButtonDown(1))
      {
         fireSound.Play();
         GetComponent<Animation>().Play("gunShot");
      }
   }
}
