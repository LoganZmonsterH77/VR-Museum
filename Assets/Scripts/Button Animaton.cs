using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtojnAnimaton : MonoBehaviour
{
    public string triggerName = "NextAnim";
    Animator anim;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    public void Nextanim()
    {
        anim.SetTrigger(triggerName);
    }
}
