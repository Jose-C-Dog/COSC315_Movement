using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int moveSpeed;
    //public Rigidbody Player_Cosmos_RB;
    public int jumpForce;
    public CharacterController controller;
    private Vector3 moveDirection;
    public float gravityScale;
    
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    
    
    public int maxHygiene;
    public int currentHygiene;
    
    
    public int maxKarma;
    public int currentKarma;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentHygiene = 0;

        
        currentKarma = 50;
        //Player_Cosmos_RB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //This is to begin the damage on collision, it doesnt work yet
        void OnCollisionEnter(Collision collision)
        { 
            if (collision.gameObject.name == "Projectile")
                {
                    TakeDamage(10);
                }
                void TakeDamage(int damage)
                {
                    currentHealth -= damage;
                    healthBar.SetHealth(currentHealth);
                }
        }




        

        /*Player_Cosmos_RB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, Player_Cosmos_RB.velocity.y, Player_Cosmos_RB.velocity.z);

         if (Input.GetButtonDown("Jump"))
         {
             Player_Cosmos_RB.velocity = new Vector3(Player_Cosmos_RB.velocity.x, jumpForce, Player_Cosmos_RB.velocity.z);
         }
         */
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, 0f);

            if (controller.isGrounded)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection.y = jumpForce;
                }
            }

            moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
            controller.Move(moveDirection * Time.deltaTime);
        }
            //controller.Move(moveDirection * Time.deltaTime);
          
    }
}
