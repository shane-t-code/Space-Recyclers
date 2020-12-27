using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
        public HealthBar healthBar;
        public int maxHealth = 100;
        public int currentHealth;
        // Controller
        private Animator anim;
		private CharacterController controller;
		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;

		void Start ()
        {
            // Health
            currentHealth = maxHealth;
            healthBar.SetMaxhealth(maxHealth);
            // Controller
            controller = GetComponent <CharacterController>();
			anim = gameObject.GetComponentInChildren<Animator>();
		}

		void Update ()
        {
        // Health
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //TakeDamage(20);
        //}
        
        // Player Movement
        float turn = Input.GetAxis("Horizontal");

        if (Input.GetKey("w"))
        {
            anim.SetInteger("AnimationPar", 1);
        }
        else if(Input.GetKey("s"))
        {
            transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
        }
        else
        {
				anim.SetInteger ("AnimationPar", 0);
		}

			if(controller.isGrounded)
            {
				moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
			}

			// float turn = Input.GetAxis("Horizontal");
			transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			controller.Move(moveDirection * Time.deltaTime);
			moveDirection.y -= gravity * Time.deltaTime;
		}
    // Take Damage
    void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
