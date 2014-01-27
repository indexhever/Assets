using UnityEngine;
using System.Collections;

public class PlayerBossFight : MonoBehaviour {
	public Transform camera;
	private Transform cameraTransformOriginal;
	public float counter;

	public Transform player;

	private Rigidbody2D playercontroller;

	private SpriteRenderer playerenderer;

	private bool ativaTerremoto;

	// Use this for initialization
	void Start () {
		playercontroller = player.GetComponent<Rigidbody2D>();
	
		cameraTransformOriginal = camera.GetComponent<Transform>();
		counter = 0;

		playerenderer = player.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(ativaTerremoto){
			if (counter < 20) {
				Vector2 oi = new Vector2 (10, 10);
				playercontroller.AddForce (oi);
			}
			
			float mult = 0.1f;
			Vector3 position = new Vector3(Mathf.Sin (counter) * mult, Mathf.Cos (counter) * mult, 0);
			camera.transform.Translate(	position);
			counter += 1;
			
			playerenderer.color = new Color(Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f));
			
			if (counter > 1024)
				Application.LoadLevel ("Stage1");

		} else {
			playerenderer.color = Color.white;
		}

	}

	void AtivaTerremoto(bool ativa){
		ativaTerremoto = ativa;
	}
}
