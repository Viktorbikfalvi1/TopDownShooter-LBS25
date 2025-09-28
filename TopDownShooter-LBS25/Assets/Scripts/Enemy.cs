using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    Rigidbody2D rb;
    Vector2 direction;
   [SerializeField] Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            direction = (player.position - transform.position).normalized;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }
}
