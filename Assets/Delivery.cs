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

      if(other.tag == "Package")
      {
        Destroy(other.gameObject);
        Debug.Log("Package Delivered");
        hasPackage = true;
      }
      if(other.tag == "Customer" && hasPackage)
      {
        Debug.Log("Customer Delivered");
        hasPackage = false;
      }
   }
}
