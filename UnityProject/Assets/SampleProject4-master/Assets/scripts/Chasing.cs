using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chasing : MonoBehaviour {

	public Transform target;
	public float speed;

	private float health;
	private float maxHealth;
	public GameObject explostion;

	private Text healText;
	private Image healBar;
	
	// Use this for initialization
	void Start () {
		GameManager.Instance.TotalEnemy++;
		GameManager.Instance.ShowInfo();
		health = 100.0f;
		maxHealth = 100.0f;
		healText = transform.FindChild("EnemyCanvas").FindChild("HealthBarText").GetComponent<Text>();
		healBar = transform.FindChild("EnemyCanvas").FindChild("MaxHealthBar").FindChild("HealthBar").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target, Vector3.up);
		transform.position += transform.forward * speed * Time.deltaTime;
		healText.text = health.ToString();
		healBar.fillAmount = health / maxHealth;
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Bullet") {
			Destroy(col.gameObject);

			if(health > 0)
				health -= 10;

			if(health < 1) {
				GameManager.Instance.TotalEnemy--;
				GameManager.Instance.ShowInfo();
				Destroy(this);
				Instantiate(explostion, transform.position, transform.rotation);
				Destroy(gameObject);
			}
		}
	}
}





