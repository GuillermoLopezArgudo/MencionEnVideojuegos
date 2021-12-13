using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public Sprite Carta1;
    public Sprite Carta2;
    public Sprite Carta3;
    public Sprite Carta4;
    public Sprite Carta5;
    public Sprite Carta6;
    public Sprite Carta7;
    public Sprite Carta8;
    public Sprite Carta9;
    public Sprite Carta10;


    public GameObject Carta;
    public List<GameObject> Cartas = new List<GameObject>();
    public List<Sprite> Baraja;
    public List<Sprite> ListaCartas;
    // Start is called before the first frame update
    void Start()
    {


        ListaCartas.Add(Carta1);
        ListaCartas.Add(Carta2);
        ListaCartas.Add(Carta3);
        ListaCartas.Add(Carta4);
        ListaCartas.Add(Carta5);
        ListaCartas.Add(Carta6);
        ListaCartas.Add(Carta7);
        ListaCartas.Add(Carta8);
        ListaCartas.Add(Carta9);
        ListaCartas.Add(Carta10);

        for (int j = 0; j < ListaCartas.Count; j++)
        {
            int random = Random.Range(0, ListaCartas.Count);

            for(int k = 0; k < 2; k++)
            {
                Baraja.Add(ListaCartas[random]);
            }

            ListaCartas.RemoveAt(random);
        }


        int i = 1;
        for (var y = 0; y < 2; y++)
        {
            for (var x = -2; x < 3; x++)
            {

                
                GameObject newCarta = Instantiate(Carta, new Vector3(x * 2, (-2 + y * 4), 0), Quaternion.identity);
                newCarta.name = "Carta"+i;
                int id = Random.Range(0, Baraja.Count);
                newCarta.GetComponent<CardScript>().front = Baraja[id];
                i++;
                Cartas.Add(newCarta);
                Baraja.RemoveAt(id);

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
