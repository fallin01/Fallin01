using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject fruitSlicedPrefab;

    public float throwForce = 13f;

    Rigidbody2D rb;
    GameObject slicedFruit;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * throwForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Blade")
        {
            Vector3 direction = (collision.transform.position - transform.position).normalized;
            Quaternion rotation = Quaternion.LookRotation(direction);

            slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
            Destroy(slicedFruit, 5f);
            Destroy(gameObject);
        }
    }
}