
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private bool hasKey = false;
    [SerializeField]
    public float speed = 2f;
    [SerializeField]
    public Rigidbody2D rb;
    private Vector2 playerVelocity;
    [SerializeField]
    public GameObject winScreen;

    
    // Start is called before the first frame update
    void Start()
    {
        winScreen.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void FixedUpdate()
    {
        

        rb.velocity = playerVelocity * speed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasKey && collision.gameObject.name == "Exit")
        {
            winScreen.SetActive(true);
            
            Invoke(nameof(LoadNextScene), 3.0f);
        }
        else if (collision.gameObject.name == "Key")
        {
            hasKey = true;
            GameObject gameObject = collision.gameObject;
            gameObject.SetActive(false);
        }
    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MoveUp()
    {
        playerVelocity.y = speed;
    }

    public void MoveDown()
    {
        playerVelocity.y = -speed;
    }

    public void MoveLeft()
    {
        playerVelocity.x = -speed;
    }

    public void MoveRight()
    {
        playerVelocity.x = speed;
    }

    // Методи для відпускання кнопок
    public void StopMoving()
    {
        playerVelocity = Vector2.zero; // Скидаємо швидкість до нуля
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
