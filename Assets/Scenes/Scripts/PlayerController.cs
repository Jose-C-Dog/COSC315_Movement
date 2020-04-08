using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int moveSpeed;
    public Rigidbody Player_Cosmos_RB;
    public int jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        Player_Cosmos_RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Player_Cosmos_RB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, Player_Cosmos_RB.velocity.y, Player_Cosmos_RB.velocity.z);

        if (Input.GetButtonDown("Jump"))
        {
            Player_Cosmos_RB.velocity = new Vector3(Player_Cosmos_RB.velocity.x, jumpForce, Player_Cosmos_RB.velocity.z);
        }
    }
}
