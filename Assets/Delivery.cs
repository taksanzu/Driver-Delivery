using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   [SerializeField] Color32 hasPackageColor = new Color32(0, 255, 0, 255);
   [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

   private bool hasPackage;

   SpriteRenderer spriteRenderer;


   private void Start()
   {
      hasPackage = false;
      spriteRenderer = GetComponent<SpriteRenderer>();
      spriteRenderer.color = noPackageColor;
   
   }

   private void OnTriggerEnter2D(Collider2D other)
   {

      if(other.tag == "Package" && !hasPackage)
      {
        Debug.Log("Package Delivered");
        hasPackage = true;
        Destroy(other.gameObject, 0.05f);
        spriteRenderer.color = hasPackageColor;
      }
      if(other.tag == "Customer" && hasPackage)
      {
        Debug.Log("Customer Delivered");
        hasPackage = false;
         spriteRenderer.color = noPackageColor;
      }
   }
}
