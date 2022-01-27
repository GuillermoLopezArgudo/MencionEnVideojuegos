using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAlien : MonoBehaviour
{

    GameObject Texto;
    GameObject nave;
    GameObject horda;
    SpaceShipScript scriptNave;
    ScriptHorda scriptHorda;


    // Start is called before the first frame update
    void Start()
    {
             
        Texto = GameObject.FindGameObjectWithTag("Winner");
        Texto.SetActive(false);
        nave = GameObject.FindGameObjectWithTag("Player");
        scriptNave = nave.GetComponent<SpaceShipScript>();
        horda = GameObject.FindGameObjectWithTag("Horda");
        scriptHorda = horda.GetComponent<ScriptHorda>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.gameObject.tag == "Bala")
        {
            Destroy(gameObject);
            Texto.SetActive(true);
            scriptNave.SetEndGame();
        }
        else
        {

            scriptHorda.SetEndGame();
        }

    }
}
