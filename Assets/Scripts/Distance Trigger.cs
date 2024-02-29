using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DistanceTrigger : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float activationDistance = 3.0f;
    [SerializeField]
    private float resetDelay = 10.0f;
    [SerializeField]
    private string triggerName = "NextAnim";
    [SerializeField]
    private AudioSource audioSource; // Reference to the AudioSource component

    private float timer;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < activationDistance && timer <= 0)
        {
            Activate();
        }

        if (timer > 0) timer -= Time.deltaTime;
    }

    void Activate()
    {
        // Play animation
        anim.SetTrigger(triggerName);

        // Play sound
        if (audioSource != null)
        {
            audioSource.Play();
        }

        timer = resetDelay;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, activationDistance);
    }
}