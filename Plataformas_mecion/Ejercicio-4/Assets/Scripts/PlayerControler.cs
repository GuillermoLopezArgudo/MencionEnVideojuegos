using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float fuerza = 5;
    Rigidbody2D Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");

        Player.velocity = (transform.right * inputX * fuerza);
    }
}
