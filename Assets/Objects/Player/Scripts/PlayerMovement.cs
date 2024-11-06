using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform trans;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource source;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float runSpeed = 15f;

    [SerializeField] private float jumpForce = 200;

    [SerializeField] private float mouseSesetivity;

    [SerializeField] private AudioClip footsteps_walk;
    [SerializeField] private AudioClip footsteps_run;



    private void Start()
    {
        //InputManager.Instance.GetControls().Movement.Jump.started += _ => Jump();
        //source = GetComponent<AudioSource>();
    }

    public void Update()
    {

        Vector3 move = Move();

        Animate(move);

    }


    private void CmdAnimate(float velocityX, float velocityZ)
    {
    }

    private void Animate(Vector3 move)
    {
        float velocityX = Vector3.Dot(move.normalized, transform.right);
        float velocityZ = Vector3.Dot(move.normalized, transform.forward);

        velocityX *= InputManager.Instance.GetControls().Movement.Run.ReadValue<float>() == 0 ? 1 : 2;
        velocityZ *= InputManager.Instance.GetControls().Movement.Run.ReadValue<float>() == 0 ? 1 : 2;

        animator.SetFloat("VelocityX", velocityX, 0.1f, Time.deltaTime);
        animator.SetFloat("VelocityZ", velocityZ, 0.1f, Time.deltaTime);
    }


    private Vector3 Move()
    {
        float forward = InputManager.Instance.GetControls().Movement.Vertical.ReadValue<float>();
        float right = InputManager.Instance.GetControls().Movement.Horizontal.ReadValue<float>();

        Vector3 move = trans.forward * forward + trans.right * right;

        move.Normalize();

        move *= InputManager.Instance.GetControls().Movement.Run.ReadValue<float>() == 0 ? speed : runSpeed;

        Attack attack = GetComponent<Attack>();
        if (attack != null)
        {
            move *= attack.attackSpeedMultiplier;
        }



        if (!source.isPlaying && !Mathf.Approximately(move.magnitude, 0))
        {
            source.clip = InputManager.Instance.GetControls().Movement.Run.ReadValue<float>() == 0 ? footsteps_walk : footsteps_run;
            source.Play();
        }

        rb.velocity = new(move.x, rb.velocity.y, move.z);
        return move;
    }

}