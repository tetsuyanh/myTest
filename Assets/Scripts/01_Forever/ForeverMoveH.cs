using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、移動する（水平）
public class ForeverMoveH : MonoBehaviour
{
	//-------------------------------------
	public float speed = 3; //［速度］
													//-------------------------------------
	void FixedUpdate()
	{
		transform.Translate(speed * Time.deltaTime, 0, 0); // 水平に移動
	}
}
