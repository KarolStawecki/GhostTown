using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateHandler : MonoBehaviour
{
    public GameObject GateL;
    public GameObject GateR;
    private bool GateCanOpen = false;
    public int keys;

private void OnTriggerEnter(Collider other)
{
    if(keys >= 3 && !GateCanOpen)
    {
GateOpen();
keys = 0;
    }
}
    
public void KeyAcquire()
{
    keys += 1;
}   

public void GateOpen()
{

    GateCanOpen = true;
    Animator anim = GateL.GetComponent<Animator>();
    anim.SetTrigger("Open");
    anim = GateR.GetComponent<Animator>();
    anim.SetTrigger("Open");

}

}


