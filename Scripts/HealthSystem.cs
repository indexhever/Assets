using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {
	
	public float health;

	public int counter;

	public void Damage(float amount) {
		if (health > 0)
			health -= amount;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (health <= 0)
			counter++;

		if (counter == 180){

			transform.gameObject.AddComponent<GameOverScript>();

		}
	}
}
