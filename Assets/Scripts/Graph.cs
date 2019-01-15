using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{   
    Transform[] points; 
    [Range(10,100)] public int resolution = 10;
    
    public Transform pointPrefab;

    void Start(){
        float step = 2f / resolution;
       	Vector3 scale = Vector3.one *step;
		Vector3 position;
        position.x = 0;
        position.y = 0;
        position.z = 0;
        points = new Transform[resolution];
		for (int i = 0; i < resolution; i++) {
			Transform point = Instantiate(pointPrefab);
            points[i] = point;
			position.x = (i + 0.5f) * step - 1f;//adjusting cubes
         //   position.y = (position.x)*position.x*position.x;
			point.localPosition = position;
			point.localScale = scale;
            point.SetParent(transform);
            
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
