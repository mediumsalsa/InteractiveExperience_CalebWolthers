using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 1f;

    private Rigidbody2D rb;

    private Animator animator;

    public GameManager gameManager;

    public LevelManager levelManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");

        if (hInput != 0 || vInput != 0)
        {
            animator.SetFloat("xInput", hInput);
            animator.SetFloat("yInput", vInput);
            animator.Play("Walk");
        }
        if (hInput == 0 && vInput == 0)
        {
            animator.Play("Idle");
        }

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
        else if (collision.tag == "PortalBack")
        {
            levelManager.LoadScene("GamePlayGrass");
        }
    }


}
