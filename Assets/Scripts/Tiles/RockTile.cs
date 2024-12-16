using UnityEngine;

public class RockTile : MonoBehaviour
{
    public bool isDug = false;     
    public bool hasGem = false;   
    public bool hasBomb = false;   
    public Sprite dugSprite;       
    public GameObject gemPrefab;   

    private const float GEM_CHANCE = 0.3f; 
    void OnMouseDown()
    {
        if (!isDug && TokenManager.Instance.UseToken())
        {
            isDug = true;
            DigTile();
        }
    }

    void DigTile()
    {
        GetComponent<SpriteRenderer>().sprite = dugSprite;

        
        float chance = Random.value; 
        if (chance <= GEM_CHANCE)
        {
            hasGem = true;
            Debug.Log("Trúng gem!");
            Instantiate(gemPrefab, transform.position, Quaternion.identity);
        }
        else if (hasBomb)
        {
            Debug.Log("Trúng bom!");
            Explode();
        }
        else
        {
            Debug.Log("Ô trống.");
        }
    }

    void Explode()
    {
        Debug.Log("Bom phát nổ! Phạm vi 3x3.");
    }
}
