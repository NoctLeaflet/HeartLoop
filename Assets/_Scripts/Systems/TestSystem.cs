using System;
using Unity.VisualScripting;
using UnityEngine;

public class TestSystem : MonoBehaviour
{
    [SerializeField] private HandView handView;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CardView cardView = CardViewCreator.Instance.CreateCardview(transform.position, Quaternion.identity);    
            StartCoroutine(handView.AddCard(cardView));          
        }
    }
}
