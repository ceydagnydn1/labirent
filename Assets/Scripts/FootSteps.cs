using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioClip[] footstepClips;
    public AudioSource audioSource;


    public CharacterController controller;

    public float footstepTheshould;
    public float footstepRate;
    private float lastFootstepTime;

    private void FixedUpdate()
    {
        if (controller.velocity.magnitude > footstepTheshould)
        {
            if (Time.time - lastFootstepTime > footstepRate)
            {
                lastFootstepTime = Time.time;

                audioSource.PlayOneShot(footstepClips[Random.Range(0, footstepClips.Length)]);
            }
        }
    }
}
