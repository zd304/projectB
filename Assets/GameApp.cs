using UnityEngine;
using System.Collections;

public class GameApp : MonoBehaviour
{
	void Awake()
	{
		float fov = (float)Screen.width / (float)Screen.height;
		float fHeight = mainCamera.orthographicSize;
		float fWidth = mainCamera.orthographicSize * fov;

		int col = 10;
		int raw = 10;
		float brickSize = 256.0f;

		float gap = (float)Screen.width * 0.02f;
		float w = ((float)Screen.width - (gap * (col + 1))) / col;
		float scale = w / brickSize;

		mBrickInst = Resources.Load<GameObject>("Prefab/brick_front");

	}

	void Start()
	{
		
	}

	void Update()
	{
		
	}

	public Camera mainCamera;
	GameObject mBrickInst = null;
}
