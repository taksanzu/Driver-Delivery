using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
      if(other.tag == "Package")
      {
        Destroy(other.gameObject);
        Debug.Log("Package Delivered");
      }else if(other.tag == "Customer")
      {
        Debug.Log("Customer Delivered");
      }
   }
}
