using UnityEngine;

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
        
        float assex = 0f;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
            assex = -1f;
   
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
             rb.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
            assex = 1f;
          
        }
        //if (Input.GetKey(KeyCode.UpArrow) )
        //{

        //    rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        //    rb.linearVelocity = new Vector2(rb.linearVelocity.x, 1);
        //}
        //if (Input.GetKey(KeyCode.DownArrow && &&MaskController.Instance.Mask_3 ))
        //{

        //    rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        //    rb.linearVelocity = new Vector2(rb.linearVelocity.x, -1);

        //}
        rb.linearVelocity = new Vector2(assex * velocita, rb.linearVelocity.y);


        if (Input.GetKeyDown(KeyCode.Space) && aTerra)  //&&MaskController.Instance.Mask_1 )
        {
            rb.AddForce(new Vector2(0, forzaSalto), ForceMode2D.Impulse);
        }
    }


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
