using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;
    
    public float speed;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        speed = 6;
        angle = -90; // Random.Range(-45, -135);

        SetDirection();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StopMomentum()
    {
        rb.velocity = new Vector2(0f, 0f);
    }

    void SetDirection()
    {
        rb.AddForce(Quaternion.Euler(0, 0, angle) * new Vector3(speed, 0, 0), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player")
        {
            CollisionPlayer(other);
            StopMomentum();
            SetDirection();
        }

        else if (other.gameObject.tag == "Brick")
        {
            CollisionSimpleBrick(other);
        }

        else if (other.gameObject.tag == "Indestructible")
        {
            CollisionIndestructibleBrick(other);
        }
    }

    void CollisionPlayer(Collision2D other)
    {
        // Manage collision with Player
        Vector3 dir = other.transform.position - transform.position;
        dir = other.transform.InverseTransformDirection(dir);
        float angleCollision = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        angle = 180 + angleCollision;
    }

    void CollisionSimpleBrick(Collision2D other)
    {

        other.gameObject.GetComponentInParent<BrickManager>().Break();
    }

    void CollisionIndestructibleBrick(Collision2D other)
    {

    }
}
