using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTool : MonoBehaviour
{// プレイヤーの年齢を表示
	public void PrintPlayerAge()
	{
		Debug.Log(PlayerManager.Instance.playerAge);
	}
	// インスタンスをセットアップ
	public void PrintPlayerName()
	{
		Debug.Log(PlayerManager.Instance.playerName);
	}

	// 起動時のインスタンスの設定
	public void OnEnable()
	{
		PlayerManager.Instance.nameUpdated.AddListener(PrintPlayerName);
	}

	// 停止時のインスタンスの設定
	public void OnDisable()
	{
		PlayerManager.Instance.nameUpdated.RemoveListener(PrintPlayerName);
	}

}
