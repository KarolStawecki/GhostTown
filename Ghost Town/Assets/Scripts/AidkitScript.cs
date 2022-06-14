using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidkitScript : MonoBehaviour
{
 private void OnTriggerEnter(Collider other)
 {
   if(other.tag =="Player"){
    other.gameObject.GetComponent<CharacterStats>().Heal(20);
    destroyafteruse();
   }
    }
 
 private void destroyafteruse(){
    Destroy (gameObject);
 }
}
