using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
	public float Speed { get { return _speed; } }

	[SerializeField]
	private float _speed = 10f;
	private Transform _chachedTransform;

	void Awake()
	{
		_chachedTransform = transform;
	}

	void FixedUpdate()
	{
		_chachedTransform.localPosition += Vector3.up * _speed;
	}

	public void Pop()
	{
		// TODO play some effects
		Destroy(gameObject);
	}
}
