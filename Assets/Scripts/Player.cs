using UnityEngine;

public class Player : MonoBehaviour
{
    public bl_Joystick joyStick;
    public float moveSpeed = 10;
    public GameObject winText;
    public int winScore = 5;

    int score = 0;
    float hInput, vInput;
    // hInput to store joystick's horizontal movement
    // vinput to store joystick's vertical movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
    }

    private void FixedUpdate()
    {

        hInput = joyStick.Horizontal * moveSpeed;
        vInput = joyStick.Vertical * moveSpeed;

        transform.Translate(hInput, vInput, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Carrot")
        {
            score++;
            Destroy(collision.gameObject);

            if(score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}
