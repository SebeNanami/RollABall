using System;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
	// �J�����ւ̃A�N�Z�X
	public Camera usedCamera;

	// �X�N���v�g���L���ɂȂ����ۂɖ���Ăяo�����
	public void OnEnable()
	{
		if (!usedCamera)
		{
			usedCamera = Camera.main;
		}
	}

	// ���t���[���Ăяo�����
	public void DrawRay(Vector3 clickPosition)
	{
		// mousePosition���烌�C���쐬
		Ray ray = usedCamera.ScreenPointToRay(clickPosition);

		// Ray�ƈ�v�������`��
		Debug.DrawRay(ray.origin, ray.direction);
	}

	public LayerMask layers;

	public float raycastDistance = 10.0f;

	public int trackedFingerId;


    // �^�b�`�������Ƃ��Ďg��UnityEvent
    [Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3>
    {
        internal void Invoke(Vector2 position)
        {
            throw new NotImplementedException();
        }
    }

    // �g���b�L���O���Ă���w����ʂɐG�ꂽ�Ƃ��ɌĂяo�����
    public Vector3UnityEvent touchDetected;

	// �X�N���v�g���L���ɂȂ����ۂɖ���Ăяo�����
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