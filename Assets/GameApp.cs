using UnityEngine;
using System.Collections;

public class GameApp : MonoBehaviour
{
	void Awake()
	{
		mCanvas = Resources.Load<GameObject>("Prefab/Canvas");
		mBrickInst = Resources.Load<GameObject>("Prefab/brick");

		mCanvas = GameObject.Instantiate(mCanvas);

		Canvas canvas = mCanvas.GetComponent<Canvas>();
		canvas.worldCamera = mainCamera;

		int col = 5;
		int raw = 5;
		MainCanvas mc = mCanvas.GetComponent<MainCanvas>();
		mc.SetLayout(raw, col, 8, 8);

		GameObject brick = null;
		for (int i = 0; i < raw; ++i)
		{
			for (int j = 0; j < col; ++j)
			{
				brick = GameObject.Instantiate(mBrickInst);
				RectTransform rc = brick.GetComponent<RectTransform>();
				mc.AddBrick(rc, i, j);
			}
		}
	}

	void Start()
	{
		
	}

	void Update()
	{
		
	}

	public Camera mainCamera;
	GameObject mBrickInst = null;
	GameObject mCanvas = null;
}
