using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public bool locked;
    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;
    public Sprite closeSprite;
    // Start is called before the first frame update
    void Start()
    {
        locked = true;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSprite(Sprite otherSprite)
    {
        spriteRenderer.sprite = otherSprite;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Key"))
        {
            locked = false;
            ChangeSprite(openSprite);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Key"))
        {
            locked = true;
            ChangeSprite(closeSprite);
        }
    }
}
