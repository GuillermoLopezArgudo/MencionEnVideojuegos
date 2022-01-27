using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    Rigidbody2D body;
    public int force;
    public int forceTorpedo;
    public GameObject Misil;
    bool boolean = true;
    bool endGame=true;
    GameObject Texto;


    // Start is called before the first frame update
    void Start()
    {
        body=GetComponent<Rigidbody2D>();
        Texto = GameObject.FindGameObjectWithTag("Finish");
        Texto.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (endGame == true) { 
        float moviment = Input.GetAxis("Horizontal");

        body.velocity=transform.right*moviment * force;

        float xPos = Mathf.Clamp(body.position.x, -3.163384f, 3.216491f);   

        transform.position = new Vector2(xPos, body.position.y);


        if (Input.GetButton("Jump") && boolean == true)
        {
            
                GameObject misil = Instantiate(Misil, new Vector2(body.position.x, -3), Quaternion.identity);

                Rigidbody2D BodyMisil = misil.GetComponent<Rigidbody2D>();

                Vector2 direccion = new Vector2(0f, 1f);
                BodyMisil.velocity = direccion * forceTorpedo;

                boolean = false;

        }
        }
  
    }

    public void SetBoolean()
    {
        boolean = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        endGame = false;

        Texto.SetActive(true);

    }
}
