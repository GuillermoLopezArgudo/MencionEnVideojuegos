using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAlien : MonoBehaviour
{
    public float velocidad = 0.8f;
    bool boleana = true;
    bool endGame = true;
    GameObject Texto;
    GameObject nave;
    SpaceShipScript scriptNave;

    // Start is called before the first frame update
    void Start()
    {
             
        InvokeRepeating("Move", 0.8f, velocidad);
        Texto = GameObject.FindGameObjectWithTag("Winner");
        Texto.SetActive(false);
        nave = GameObject.FindGameObjectWithTag("Player");
        scriptNave = nave.GetComponent<SpaceShipScript>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Move()
    {
        if (endGame == true)
        {
            if (boleana == true)
            {

                if (transform.position.x < 3)
                {
                    transform.Translate(Vector2.right);
                }
                else
                {
                    transform.Translate(Vector2.down);
                    CancelInvoke();
                    velocidad -= 0.1f;
                    boleana = false;
                    InvokeRepeating("Move", 0.8f, velocidad);
                }
            }
            else if (boleana == false)
            {

                if (transform.position.x > -3)
                {

                    transform.Translate(Vector2.left);

                }
                else
                {
                    transform.Translate(Vector2.down);
                    CancelInvoke();
                    velocidad -= 0.1f;
                    boleana = true;
                    InvokeRepeating("Move", 0.8f, velocidad);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.gameObject.tag == "Bala")
        {
            Destroy(gameObject);
            Texto.SetActive(true);
            scriptNave.SetEnGame();
        }
        else
        {
            endGame = false;

        }

    }
}
