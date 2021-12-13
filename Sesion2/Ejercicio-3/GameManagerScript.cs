using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public GameObject Carta;
    public List<GameObject> Cartas = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {





        int i = 1;
        for (var y = 0; y < 2; y++)
        {
            for (var x = -2; x < 3; x++)
            {

                
                GameObject newCarta = Instantiate(Carta, new Vector3(x * 2, (-2 + y * 4), 0), Quaternion.identity);
                newCarta.name = "Carta"+i;

                i++;
                Cartas.Add(newCarta);


            }
        }

        for (int j = 0; j < 10; j++)
        {
            Debug.Log(Cartas[j]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
