using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunDamage : MonoBehaviour
{
   public int DamageAmount = 5;
   public float TargetDistance;
   public float AllowedRange = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
         RaycastHit Shot;
         if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
         {
            TargetDistance = Shot.distance;
            if (TargetDistance < AllowedRange)
            {
               Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
               Shot.transform.SendMessage("IceHit", SendMessageOptions.DontRequireReceiver);
            }
         }
      }
      else if (Input.GetMouseButtonDown(1))
      {
         RaycastHit Shot;
         if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
         {
            TargetDistance = Shot.distance;
            if (TargetDistance < AllowedRange)
            {
               Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
               Shot.transform.SendMessage("FireHit", SendMessageOptions.DontRequireReceiver);
            }
         }
      }
   }
}
