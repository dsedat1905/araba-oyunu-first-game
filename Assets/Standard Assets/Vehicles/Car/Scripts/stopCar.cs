using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class stopCar : MonoBehaviour, IPointerDownHandler
{
	public GameObject car;
   public virtual void OnPointerDown(PointerEventData p)
	{
		car.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
	}
}
