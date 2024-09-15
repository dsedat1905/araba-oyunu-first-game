using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class backCar : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    
	bool isPointerDown = false;
	float carSpeed = 0;

	public virtual void OnPointerUp(PointerEventData p)
	{
		isPointerDown = false;
	}
	
	public virtual void OnPointerDown(PointerEventData p)
	{
		isPointerDown = true;
	}
	
	public float accelarateCarBack()
	{
		if(isPointerDown == true)
	{
		carSpeed -= 1f;
	}
		else
	{
		carSpeed = 0;
	}
		return carSpeed;
	}
}


