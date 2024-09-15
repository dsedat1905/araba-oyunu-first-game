using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour
{

private float inputHorizontal;


// private float inputVertical;

private string horizontalAxis = "Horizontal";


// private string verticalAxis = "Vertical";

void Update()
{

transform.Translate(0, 0 ,0 * Time.deltaTime * 1f);

inputHorizontal = SimpleInput.GetAxis(horizontalAxis);
// inputVertical = SimpleInput.GetAxis(verticalAxis);
transform.Rotate(0, inputHorizontal *2f, 0f, Space.Self);

}

}