using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionCapTrigger : MonoBehaviour
{
    private Animator anim;
    private AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        aud = this.GetComponent<AudioSource>();
        StartAnim();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1)) StartAnim();
    }
    void StartAnim()
    {
        anim.SetTrigger("StartAnim");
        aud.Play();
    }
    
}
