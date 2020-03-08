using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical : MonoBehaviour
{
   public Material[] materials;
   public int currentMaterial;
   // Start is called before the first frame update
   void Start()
    {
        
    }

   // Update is called once per frame
   public int EnemyHealth = 10;

   void DeductPoints(int DamageAmount)
   {
      EnemyHealth -= DamageAmount;
   }

   void IceHit()
   {
      currentMaterial = 0;
      GetComponent<Renderer>().material = materials[currentMaterial];
   }
   void FireHit()
   {
      currentMaterial = 1;
      GetComponent<Renderer>().material = materials[currentMaterial];
   }

   void Update()
   {
      if (EnemyHealth <= 0)
      {
         Destroy(gameObject);
      }
   }
}
