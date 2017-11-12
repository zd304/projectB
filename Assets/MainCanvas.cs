using UnityEngine;
using System.Collections;

public class MainCanvas : MonoBehaviour
{
	public void SetLayout(int raw, int col, float spaceX, float spaceY)
	{
		mRaw = raw;
		mCol = col;
		mSpaceX = spaceX;
		mSpaceY = spaceY;

		brickContainer.sizeDelta = new Vector2(0.0f, (float)Screen.width);
	}

	public void AddBrick(RectTransform t, int x, int y)
	{
		t.parent = brickContainer;
		t.localScale = Vector3.one;

		float width = Screen.width;
		float height = brickContainer.sizeDelta.y;

		float trimWidth = width - mSpaceX * (float)(mCol + 1);
		float trimHeight = height - mSpaceY * (float)(mRaw + 1);

		float transformWidth = trimWidth / mCol;
		float transformHeight = trimHeight / mRaw;

		t.anchoredPosition = new Vector2(mSpaceX + x * (mSpaceX + transformWidth) + 0.5f * transformWidth, -mSpaceY - y * (mSpaceY + transformHeight) - 0.5f * transformHeight);
		t.sizeDelta = new Vector2(transformWidth, transformHeight);
	}

	public RectTransform brickContainer;
	int mRaw;
	int mCol;
	float mSpaceX;
	float mSpaceY;
}
