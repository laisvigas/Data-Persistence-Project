using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float initialForce = 500f; 
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (rb != null)
        {
            Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            rb.AddForce(randomDirection * initialForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = GetRandomColor();
        }
    }

    private Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
