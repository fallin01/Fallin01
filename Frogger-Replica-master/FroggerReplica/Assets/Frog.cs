using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
    public AudioClip crash;
    public AudioClip jump;

	void Update () {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
            AudioSource.PlayClipAtPoint(jump, transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
            AudioSource.PlayClipAtPoint(jump, transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
            AudioSource.PlayClipAtPoint(jump, transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
            AudioSource.PlayClipAtPoint(jump, transform.position);
        }

    }

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Debug.Log("WE LOST!");
            AudioSource.PlayClipAtPoint(crash, transform.position);
			Score.CurrentScore = 0;
            SceneManager.LoadScene("EndGame");
            
            
		}
	}
}
