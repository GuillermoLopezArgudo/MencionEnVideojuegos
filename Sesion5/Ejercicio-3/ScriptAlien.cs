using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAlien : MonoBehaviour
{

    bool boleana = true;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Move", 0.8f, 0.8f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Move()
    {
        if (boleana == true)
        {
            if (transform.position.x < 3)
            {
                transform.Translate(Vector2.right);
            }
            else
            {
                boleana = false;
            }
        }
        else if(boleana == false)
        {
            if (transform.position.x > -3)
            {
                transform.Translate(Vector2.left);
            }
            else
            {
                boleana = true;
            }
        }
    }
}
