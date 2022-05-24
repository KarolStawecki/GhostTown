using UnityEngine;
using StarterAssets;

public class Interactable : MonoBehaviour
{
   public float radius = 3f;
    bool isFocus = false;
    private StarterAssetsInputs _input;
    

    bool hasInteracted = false;
    Transform player;

    void Start()
    {
        
        _input = GetComponent<StarterAssetsInputs>();
    }

    void Update ()
    {
        if(!hasInteracted && isFocus )
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Debug.Log ("Interact");
                hasInteracted = true;
            }
        }
    }


		public void OnFocused (Transform playerTranfsform)
		{
			isFocus = true;
			player = playerTranfsform;
			hasInteracted = false;
		}

		public void OnDefocused()
		{
			isFocus = false;
			player = null;
			hasInteracted = false;
		}
   void OnDrawGizmosSelected ()
   {
       Gizmos.color = Color.yellow;
       Gizmos.DrawWireSphere(transform.position, radius);
   }
}
