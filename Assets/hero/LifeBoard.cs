using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBoard : MonoBehaviour {

    [SerializeField] float lifePoint = 100;
    [SerializeField] float damagePerHit = 10;
    float totalWidth;
    float startPosition;
    float currentWidth;



    // Use this for initialization
    void Start () {


        var rectangle = gameObject.GetComponent<RectTransform>();

        totalWidth = rectangle.rect.width;
        startPosition = transform.localPosition.x - totalWidth / 2;
        currentWidth = totalWidth;
        
    }

    public bool LoseLife() {

        print(currentWidth);
        print(gameObject);

        currentWidth -= damagePerHit / lifePoint * totalWidth;
        var rect = gameObject.GetComponent<RectTransform>();
        print(rect);
        rect.sizeDelta = new Vector2(currentWidth, rect.sizeDelta.y);
        transform.localPosition = new Vector3(startPosition + currentWidth / 2, transform.localPosition.y, transform.localPosition.z);
        return currentWidth <= 0;
    }

}
