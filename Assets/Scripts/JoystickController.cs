using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour,IDragHandler, IEndDragHandler

{
	// StartとUpdateは必要ないので取り除く
	// 中心からの最大距離
	public float maxDistance;

	// クリックを視覚的に表現する
	public Transform joystickHandle;

  // Vector2を引数に取るUnityEventを作成
[System.Serializable]
public class Vector2UnityEvent : UnityEngine.Events.UnityEvent<Vector2> { }

	// ジョイスティックの値をXYと-1～1システムで引数に取るイベント
	public Vector2UnityEvent JoystickOutput;


	// ハンドルのローカル位置の見積もりを計算
	public Vector3 GetPosition(Vector3 userInput)
	{
		Vector3 dir = userInput - transform.position;

		if (Vector3.SqrMagnitude(dir) > maxDistance * maxDistance)
		{
			dir = dir.normalized * maxDistance;
		}

		return dir;
	}

	public void OnDrag(PointerEventData eventData)
    {
		// ここでローカル位置を慎重に設定する
		joystickHandle.localPosition = GetPosition(eventData.position);

		// 入力の割合を0～1のスケールで計算
		Vector2 inputRatio = joystickHandle.localPosition / maxDistance;

		// 値を引数に渡してイベントを送信
		JoystickOutput?.Invoke(inputRatio);

	}


	public void OnEndDrag(PointerEventData eventData)
	{
		// 位置を中心にリセットする
		joystickHandle.localPosition = new Vector3();

	}




}
