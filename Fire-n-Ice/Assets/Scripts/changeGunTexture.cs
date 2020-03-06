using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeGunTexture : MonoBehaviour
{
   public Texture[] textures;
   public int currentTexture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
         currentTexture = 0;
         GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
      }
      else if (Input.GetMouseButtonDown(1))
      {
         currentTexture = 1;
         GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
      }
      else if (Input.GetMouseButtonDown(2))
      {
         currentTexture = 2;
         GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
      }
   }
}
