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
      float speed = 30f;
      bulletRigidbody.velocity = transform.forward * speed;
 
     
  }

  public void OnTriggerEnter(Collider other){
      if (other.GetComponent<BulletTarget>() !=null){
          other.gameObject.GetComponent<EnemyHP> ().DoDamage (20);
      } else{
          //hit something else
      }
      Destroy(gameObject);
  }


}
