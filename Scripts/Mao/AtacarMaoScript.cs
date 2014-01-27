using UnityEngine;
using System.Collections;

public class AtacarMaoScript : MonoBehaviour {
	private bool seMorreu;
	private Animator _animator;
	private int contador;
	private Vector3 target;
	public GameObject stageController;
	// Use this for initialization
	void Awake () {
		_animator = GetComponent<Animator>();
		contador = 0;

	}

	void Start(){
		stageController = GameObject.Find("Stage1Controller");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(contador == 0){
			_animator.Play( "IDLE" );
		}
		if(contador == 60){
			_animator.Play("Ataque");
			GameObject alt = GameObject.Find("AlturaAlvo");
			GameObject player = GameObject.Find("PlayerPC");
			target = player.transform.position;
			target.y = alt.transform.position.y;

		}
		if (contador >= 60 && contador <= 120)
		{
			if (transform.position.x != target.x)
				transform.Translate((transform.position.x - target.x) * 0.1f, 0, 0);
			if (transform.position.y != target.y - 4.0f)
				transform.Translate(0, (target.y + 4.0f - transform.position.y) * 0.1f, 0);
		}


		if(contador > 120 && contador < 135)
			transform.Translate(0, -20 * Time.deltaTime, 0);

		if(contador >= 135 && seMorreu){
			return;
		}

		if(contador == 135) {

			GameObject player = GameObject.Find("PlayerPC");
			if (player.GetComponent<CharacterController2D>().isGrounded) {
				player.GetComponent<HealthSystem>().Damage(1);
				stageController.SendMessage("AtivaTerremoto", true);
			}
		}

		if (contador == 180)
		{
			GameObject alt = GameObject.Find("AlturaAlvo");
			GameObject player = GameObject.Find("PlayerPC");
			target = player.transform.position;
			target.y = alt.transform.position.y;
			stageController.SendMessage("AtivaTerremoto", false);
		}

		if (contador > 180 && contador < 200)
		{
			if (transform.position.x != target.x)
				transform.Translate((transform.position.x - target.x) * 0.1f, 0, 0);
			if (transform.position.y != target.y - 4.0f)
				transform.Translate(0, (target.y + 4.0f - transform.position.y) * 0.1f, 0);
		}

		if (contador == 201)
			contador = -1;

		contador++;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(contador > 120 && contador < 135 && other.gameObject.name == "Estaca"){
			_animator.Play( "Morrer" );
			seMorreu = true;
		}

	}

	IEnumerator Example() {
		yield return new WaitForSeconds(5);
	}
}
