using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBala : MonoBehaviour
{
    GameObject nave;
    SpaceShipScript scriptNave;

    // Start is called before the first frame update
    void Start()
    {
        nave = GameObject.FindGameObjectWithTag("Player");
        scriptNave = nave.GetComponent<SpaceShipScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        scriptNave.SetBoolean();
        Destroy(gameObject);
    }
}
