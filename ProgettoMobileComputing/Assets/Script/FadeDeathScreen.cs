using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeDeathScreen : MonoBehaviour
{
    public bool fade = false;
	public Image img;
	float speed;


	public void FadeOutImage(float _speed) {
		speed = _speed;
		fade = true;
	}

	void Update() {
		if(fade) {
			img.color = new Color(img.color.r, img.color.b, img.color.g, img.color.a + speed * Time.deltaTime);
		}
	}
}
