using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public static int PlayerHealthValue = 100;
	public Text healthText;

	public GameObject healthBar;
	private float healthBarheight;
	private float healthBarCurrentLength;
	private float healthBarlength;

	private bool gameOver = false;
	public int gameOverDelay = 5;
	private int gameOverTimer = 0;


	void awake () 
	{
		
	}




	void Start () 
	{
		healthBarlength = healthBar.transform.localScale.x;
		healthBarheight = healthBar.transform.localScale.y;
		PlayerHealthValue = 100;
	}
	
	// Update is called once per frame
	void Update () 
	{
		HealthUpdate ();
		healthBarUIUpdate ();

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Obsticle") 
		{
			Destroy (this.gameObject);
			SceneManager.LoadScene ("GameOver");
		} 

		else if (other.gameObject.tag == "Enemy") 
		
		{
			Destroy (this.gameObject);
			SceneManager.LoadScene ("GameOver");
		}
	}

	void HealthUpdate ()
	{


		if (PlayerHealthValue >= 1f) 
		{
			healthText.text = PlayerHealthValue.ToString ();
		} 

		else 
		{
			Destroy (this.gameObject);
			SceneManager.LoadScene ("GameOver");
		}

	}


	void healthBarUIUpdate()
	{
		if (PlayerHealthValue >=0)
		{
			healthBarCurrentLength = healthBarlength / 100 * PlayerHealthValue;
			healthBar.gameObject.transform.localScale = new Vector3(healthBarCurrentLength, healthBarheight, 0f);
		}

		healthBar.GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, healthBarCurrentLength);
	}

	void GameOver()
	{
		if (gameOver == true) 
		{
			

			if (gameOverDelay >= gameOverTimer) 
			{
				
			}

		}
	}

}
