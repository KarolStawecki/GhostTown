using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
  private Rigidbody bulletRigidbody;
  private void Awake() {
      bulletRigidbody = GetComponent<Rigidbody>();
  }
  private void Start() {
      float speed = 0.5f;
      bulletRigidbody.velocity = transform.forward * speed;
 
     
  }

  public void OnTriggerEnter(Collider other){
      if (other.GetComponent<CharacterStats>() !=null){
          other.gameObject.GetComponent<CharacterStats> ().TakeDamage (10);
      } else{
          //hit something else
      }
      Destroy(gameObject);
  }


}
