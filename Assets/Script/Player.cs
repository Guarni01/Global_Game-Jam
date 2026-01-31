using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
 
    public float velocita = 5f;    
    public float forzaSalto = 10f;   
    private Rigidbody2D rb;
    private bool aTerra;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimento = 0f;

        // Controllo solo con le frecce
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movimento = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movimento = 1f;
        }

        rb.linearVelocity = new Vector2(movimento * velocita, rb.linearVelocity.y);

        // Salto con Space
        if (Input.GetKeyDown(KeyCode.Space) && aTerra)
        {
            rb.AddForce(new Vector2(0, forzaSalto), ForceMode2D.Impulse);
        }
    }

    // Verifica se il player � a terra
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terreno"))
        {
            aTerra = true;
        }
        if (collision.gameObject.CompareTag("Livello1"))
        {
            transform.position = LevelController.Instance.Lv1.transform.position;
        }
        if (collision.gameObject.CompareTag("Livello2"))
        {
            transform.position = LevelController.Instance.Lv2.transform.position;
        }
        if (collision.gameObject.CompareTag("Livello3"))
        {
            transform.position = LevelController.Instance.Lv3.transform.position;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terreno"))
        {
            aTerra = false;
        }
    }
  
}
