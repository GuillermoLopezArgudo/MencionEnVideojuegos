using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float fuerza = 5;
    Rigidbody2D Player;
    SpriteRenderer Player2;
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
        Player2 = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        if (inputX < 0)
        {
            Player2.flipX = true;
            Player.velocity = (transform.right * inputX * fuerza);
            myAnim.SetFloat("MoveSpeed", Mathf.Abs(inputX));

        }
        else
        {
            Player2.flipX = false;
            Player.velocity = (transform.right * inputX * fuerza);
            myAnim.SetFloat("MoveSpeed", Mathf.Abs(inputX));

        }
        
    }
}
