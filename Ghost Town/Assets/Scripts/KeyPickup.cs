using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
public GameObject gc;
public void OnTriggerEnter(Collider other)
{
   if(other.tag =="Player"){
    gc.gameObject.GetComponent<GateHandler>().KeyAcquire();
    destroyafteruse();
   }
 }
 private void destroyafteruse(){
    Destroy (gameObject);
 }
}
