using UnityEngine;
using System.Collections;

public class BrickTweenRotation : MonoBehaviour
{
	public void OnClickButton()
	{
		if (direction != 0.0f)
			return;
		if (IsFront)
			PlayForward();
		else
			PlayBackward();
	}

	public void PlayForward()
	{
		direction = -1.0f;
	}

	public void PlayBackward()
	{
		direction = 1.0f;
	}

	void Update()
	{
		if (direction == 0.0f)
		{
			return;
		}
		Vector3 angles = front.localEulerAngles;
		angles.y += direction * Time.deltaTime * 500.0f;
		front.localEulerAngles = angles;
		back.localEulerAngles = angles;
		if (!IsFront && direction > 0.0f && front.localEulerAngles.y >= 90.0f)
		{
			IsFront = true;
			front.gameObject.SetActive(true);
			back.gameObject.SetActive(false);
		}
		if (direction > 0.0f && front.localEulerAngles.y >= 180.0f)
		{
			direction = 0.0f;
			front.localEulerAngles = new Vector3(0.0f, 180.0f, 0.0f);
			back.localEulerAngles = new Vector3(0.0f, 180.0f, 0.0f);
		}

		if (IsFront && direction < 0.0f && front.localEulerAngles.y <= 90.0f)
		{
			IsFront = false;
			front.gameObject.SetActive(false);
			back.gameObject.SetActive(true);
		}
		if (direction < 0.0f && front.localEulerAngles.y > 180.0f)
		{
			direction = 0.0f;
			front.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
			back.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
		}
	}

	bool isFront = false;
	public bool IsFront
	{
		set
		{
			isFront = value;
		}
		get
		{
			return isFront;
		}
	}

	float angle;
	float direction = 0.0f;

	public RectTransform mainTransform;
	public RectTransform front;
	public RectTransform back;
}
