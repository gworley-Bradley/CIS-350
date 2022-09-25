using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float jumpForce;
    public ForceMode forceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;


    // Start is called before the first frame update
    void Start()
    {
        //set reference to our rigidbody component
        rb = GetComponent<Rigidbody>();
        //set a reference to our animator component
        playerAnimator = GetComponent<Animator>();

        //start running animation on start
        playerAnimator.SetFloat("Speed_f", 1.0f);

        playerAudio = GetComponent<AudioSource>();

        forceMode = ForceMode.Impulse;
        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {

            rb.AddForce(Vector3.up * jumpForce, forceMode);
            isOnGround = false;

            //set the trigger to play the jump animation
            playerAnimator.SetTrigger("Jump_trig");

            //stop playing dirt particle on jump
            dirtParticle.Stop();

            playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            // play dirt particles
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;

            dirtParticle.Stop();

            playerAudio.PlayOneShot(crashSound, 1.0f);

            //play death animation
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            //play explosion particle
            explosionParticle.Play();
        }
    }
}
