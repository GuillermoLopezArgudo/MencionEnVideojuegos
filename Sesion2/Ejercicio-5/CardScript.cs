using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{

    SpriteRenderer Carta;
    public Sprite front;
    public Sprite back;
    public bool bandera = true;
    GameObject GameManager;
    public string Name;


    // Start is called before the first frame update
    void Start()
    {
        Carta = GetComponent<SpriteRenderer>();
        Carta.sprite = back;
       GameManager = GameObject.FindGameObjectWithTag("GameController");
    }

    private void OnMouseDown()
    {
        GameManager.GetComponent<GameManagerScript>().ClickOnCard(Name);

        if (bandera == false)
        {
                
            Carta.sprite = back;
            bandera = true;
        }
        else
        {
            Carta.sprite = front;
            bandera = false;
        }

        
        Debug.Log("CLIC"+ name);
    }
        
    // Update is called once per frame
    void Update()
    {

    }
}
    