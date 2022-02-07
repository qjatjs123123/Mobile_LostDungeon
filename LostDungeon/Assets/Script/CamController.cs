using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //키보드, 마우스, 터치를 이벤트로 오브젝트에 보낼 수 있음


public class CamController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Vector3 FirstPoint;
    Vector3 SecondPoint;

    [SerializeField]
    private TPSCharacterController controller;



    public void OnBeginDrag(PointerEventData eventData)
    {
        FirstPoint = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        SecondPoint = eventData.position;
        Vector3 v = new Vector3(FirstPoint.x - SecondPoint.x, FirstPoint.y - SecondPoint.y, FirstPoint.z - SecondPoint.z);
        v.Normalize();
        controller.LookAround(-v);
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
