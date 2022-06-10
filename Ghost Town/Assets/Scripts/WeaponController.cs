using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject Miecz;
   public bool CanAttack = true;
   public float AttackCooldown = 1.0f;
   public AudioClip SwordAttackSound;
   public bool isAttacking = false;

   void Update()
   {
    if (Input.GetMouseButtonDown(0))
    {
        if (CanAttack) 
        {
            SwordAttack();
        }
    }
   }

public void SwordAttack()
{ 
CanAttack = false;
Animator anim = Miecz.GetComponent<Animator>();
anim.SetTrigger("Attack");
AudioSource ac = GetComponent<AudioSource>();
ac.PlayOneShot(SwordAttackSound);
isAttacking = true;
StartCoroutine(ResetAttackCooldown());
}

IEnumerator ResetAttackCooldown()
{
    yield return new WaitForSeconds(AttackCooldown);
    CanAttack = true;
    isAttacking = false;
}

}
