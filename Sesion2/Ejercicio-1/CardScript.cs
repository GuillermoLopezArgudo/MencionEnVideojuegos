using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite back;
    SpriteRenderer Carta;

    // Start is called before the first frame update
    void Start()
    {

        Carta = GetComponent<SpriteRenderer>();
        Carta.sprite = back;
        Vector3 pos = new Vector3(-1.0f, 3.0f, 0.0f);
        transform.position = pos;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    