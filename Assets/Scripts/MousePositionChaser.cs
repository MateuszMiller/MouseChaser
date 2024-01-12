using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePositionChaser : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int delay = 100;
    public GameObject mouseChaser;
    public GameObject mousePosition;
    List<Vector2> mousePositions = new List<Vector2>();

    void Update()
    {
        mousePosition.transform.position = CurrentMousePosition();
        mousePositions.Insert(0, CurrentMousePosition());
        if (mousePositions.Count == delay)
        {
            mousePositions.RemoveAt(delay-1);
        }
        //GetMousePositionOnDelay();
        mouseChaser.transform.position = mousePositions[mousePositions.Count-1];
    }

    Vector2 CurrentMousePosition()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
        //mousePosition.transform.position = mousePos;
    }

    private void MoveTabIndex(Vector2[] tab)
    {
        for(int i = tab.Length-1-1; i > 0; i--)
        {
            //Vector2 temp = tab[tab.Length];
            tab[i] = tab[i - 1];
            
        }
    }
    

    

    
}
