using Unity.VisualScripting;
using UnityEngine;

public class Jogador : MonoBehaviour
{

    public SpriteRenderer sprite;
    public Rigidbody2D rb;
    public AudioSource audioSource;
    public LayerMask chaoLayer;
    public float velocidade = 4f;
    public float jumpForce = 10f;

    private bool olhandoParaDireita = true;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float xDeslocamento = horizontal * velocidade * Time.deltaTime;

        transform.position =
            transform.position + new Vector3(xDeslocamento, 0f, 0f);

        RaycastHit2D hit = 
            Physics2D.Raycast(
                transform.position, 
                Vector2.down, 
                1f, 
                chaoLayer
            );

        if (hit == true && Input.GetButtonDown("Jump"))
        {
            Vector2 velocity = rb.linearVelocity;
            velocity.y = 0f;

            rb.linearVelocity = velocity;

            rb.AddForce(Vector2.up * jumpForce);
            audioSource.Play();
        }

        if (olhandoParaDireita == true && horizontal < 0f)
        {
            sprite.flipX = true;
            olhandoParaDireita = false;
        }
        else if (olhandoParaDireita == false && horizontal > 0f)
        {
            sprite.flipX = false;
            olhandoParaDireita = true;
        }
    }

}
