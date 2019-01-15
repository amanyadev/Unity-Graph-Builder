using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{   
    [Range(10,100)] public int resolution = 10;
    
    public Transform pointPrefab;

    void Awake(){
        float step = 2f / resolution;
       	Vector3 scale = Vector3.one *step;
		Vector3 position;
        position.x = 0;
        position.y = 0;
        position.z = 0;
		for (int i = 0; i < resolution; i++) {
			Transform point = Instantiate(pointPrefab);

			position.x = (i + 0.5f) * step - 1f;//adjusting cubes
            position.y = (position.x)*position.x*position.x;
			point.localPosition = position;
			point.localScale = scale;
            point.SetParent(transform);
            
		}
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
