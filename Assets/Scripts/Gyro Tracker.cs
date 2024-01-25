using UnityEngine;

public class GyroTracker : MonoBehaviour
{
    // ジャイロスコープクラスの参照をキャッシュ
    public Gyroscope gyro;

    // イベントをトリガーするメソッド
    public void OnEnable()
    {
        // デバイスがジャイロをサポートしているか確認
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
    }

    protected void OnGUI()
    {
        if (gyro == null)
        {
            return;
        }

        GUILayout.Label("input.gyro.attitude: " + gyro.attitude);
        GUILayout.Label("input.gyro.userAcceleration: " +
        gyro.userAcceleration);
    }
}

