using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public AudioClip point;

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        AudioSource.PlayClipAtPoint(point, transform.position);
	}

}
