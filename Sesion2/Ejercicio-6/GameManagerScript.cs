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
    public List<string> NombresID;
    public List<string> ID;

    public int estado = 1;
    public string CardUp;

    public void ClickOnCard(string Nombre)
    {

        if (estado == 1)
        {
            CardUp = Nombre;
            estado = 2;
        }
        else
        {
            estado = 2;
            if (CardUp == Nombre)
            {
                Debug.Log("Pareja");
            }
            else
            {
                Debug.Log("No Pareja");
            }
            estado = 1;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        NombresID.Add("Reina-1");
        NombresID.Add("Guarida-2");
        NombresID.Add("Asesino-3");
        NombresID.Add("Obispo-4");
        NombresID.Add("Alguacil-5");
        NombresID.Add("Bufon-6");
        NombresID.Add("Contador-7");
        NombresID.Add("Adulador-8");
        NombresID.Add("Baronesa-9");
        NombresID.Add("Cardenal-10");

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
                ID.Add(NombresID[random]);
            }

            ListaCartas.RemoveAt(random);
            NombresID.RemoveAt(random);
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
                newCarta.GetComponent<CardScript>().Name = ID[id];
                i++;
                Cartas.Add(newCarta);
                Baraja.RemoveAt(id);
                ID.RemoveAt(id);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
