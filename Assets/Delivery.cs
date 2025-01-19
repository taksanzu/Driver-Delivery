using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   private bool hasPackage;

   private void Start()
   {
      hasPackage = false;
   }

   private void OnTriggerEnter2D(Collider2D other)
   {

      if(other.tag == "Package" && !hasPackage)
      {
        Debug.Log("Package Delivered");
        hasPackage = true;
        Destroy(other.gameObject, 0.05f);
      }
      if(other.tag == "Customer" && hasPackage)
      {
        Debug.Log("Customer Delivered");
        hasPackage = false;
      }
   }
}
