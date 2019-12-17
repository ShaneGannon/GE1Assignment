using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phyllotaxis : MonoBehaviour
{
    //Instantiate Game Object
    //public GameObject _phyllodot;

    //Utilise 3 variables to control the Phyllotaxis system
    //Require vars for the degree and scale of spiral as well as position
    public float _degree, _scale;
    public int _numberStart;
    private int _number;
    private TrailRenderer _tr;

    //Also include extra public float for Game Object Scale
    public float _GOscale;

    //Phyllotaxis formula returns 2 variables, x and y which will be stored in a vector2
    private Vector2 CalcPhyllotaxis(float degree, float scale, int number)
    {
        //Phyllotaxis variables angle: θ = n * 137.5, radius: r - c * √n
        //Use double instead of float here for highest accuracy, later this is simplified into regular float
        //Degree must also be in radians

        double angle = number * (degree * Mathf.Deg2Rad);

        float r = _scale * Mathf.Sqrt(number);

        //Convert Polar to cartesian co-ordinates using the cos and sin of the angle multiplied by the radius
        //This gives the correct X and Y co-ordinates

        float x = r * (float)System.Math.Cos(angle);
        float y = r * (float)System.Math.Sin(angle);

        Vector2 result = new Vector2(x, y);
        return result;
    }

    //Phylloatixis for each number will be calculated in update function
    //This vector 2 will be used to assign the position 
    private Vector2 position;

    /* void Update ()
     {
         if (Input.GetKey(KeyCode.Space))
         {
             //Assign pos and instantiate GO
             position = CalcPhyllotaxis(_degree, _scale, _number);
             GameObject dotInstance = (GameObject)Instantiate(_phyllodot);
             dotInstance.transform.position = new Vector3(position.x, position.y, 0);
             dotInstance.transform.localScale = new Vector3(_GOscale, _GOscale, _GOscale);
             //Finally increment the counter
             _number++;
         }
     }
     */

    void Awake()
    {
        _tr = GetComponent<TrailRenderer>();
        _number = _numberStart;
        transform.localPosition = CalcPhyllotaxis(_degree, _scale, _number);
    }

    private void FixedUpdate()
    {
        position = CalcPhyllotaxis(_degree, _scale, _number);
        transform.localPosition = new Vector3(position.x, position.y, 0);
        _number++;
    }
}
