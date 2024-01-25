using System;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
	// カメラへのアクセス
	public Camera usedCamera;

	// スクリプトが有効になった際に毎回呼び出される
	public void OnEnable()
	{
		if (!usedCamera)
		{
			usedCamera = Camera.main;
		}
	}

	// 毎フレーム呼び出される
	public void DrawRay(Vector3 clickPosition)
	{
		// mousePositionからレイを作成
		Ray ray = usedCamera.ScreenPointToRay(clickPosition);

		// Rayと一致する線を描画
		Debug.DrawRay(ray.origin, ray.direction);
	}

	public LayerMask layers;

	public float raycastDistance = 10.0f;

	public int trackedFingerId;


    // タッチを引数として使うUnityEvent
    [Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3>
    {
        internal void Invoke(Vector2 position)
        {
            throw new NotImplementedException();
        }
    }

    // トラッキングしている指が画面に触れたときに呼び出される
    public Vector3UnityEvent touchDetected;

	// スクリプトが有効になった際に毎回呼び出される
	public void Update()
	{
		int touchCount = Input.touchCount;

		for (int i = 0; i < touchCount; i++)
		{
			if (Input.GetTouch(i).fingerId == trackedFingerId)
			{
				touchDetected.Invoke(Input.GetTouch(i).position);
			}
		}
	}
}

public class UnityEvent<T>
{
}

internal class SerializableAttribute : Attribute
{
}