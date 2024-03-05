using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 1f;

    private Rigidbody2D rb;

    public GameManager gameManager;

    public LevelManager levelManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(hInput, vInput);
        movement.Normalize();

        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Portal")
        {
            levelManager.LoadScene("GamePlaySand");
        }
        else if (collision.tag == "Portal2")
        {
            levelManager.LoadScene("GameWin");
        }
    }


}
