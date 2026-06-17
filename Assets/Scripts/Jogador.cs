using Unity.VisualScripting;
using UnityEngine;

public class Jogador : MonoBehaviour
{

    public SpriteRenderer sprite;
    public Rigidbody2D rb;
    public AudioSource audioSource;
    public LayerMask chaoLayer;
    public Animator animator;
    public float distaciaColisao = 1f;
    public float velocidade = 4f;
    public float jumpForce = 10f;

    private bool olhandoParaDireita = true;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float xDeslocamento = horizontal * velocidade * Time.deltaTime;

        transform.position =
            transform.position + new Vector3(xDeslocamento, 0f, 0f);

        animator.SetFloat("VelocidadeY", rb.linearVelocity.y);
        animator.SetBool("Correr", horizontal != 0);

        RaycastHit2D noChao = 
            Physics2D.Raycast(
                transform.position, 
                Vector2.down, 
                distaciaColisao, 
                chaoLayer
            );


        if (noChao == true && Input.GetButtonDown("Jump"))
        {
            Vector2 velocity = rb.linearVelocity;
            velocity.y = 0f;

            rb.linearVelocity = velocity;

            float newJumpForce = jumpForce;

            rb.AddForce(Vector2.up * newJumpForce);
            audioSource.Play();

            animator.SetTrigger("Pulo");
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
