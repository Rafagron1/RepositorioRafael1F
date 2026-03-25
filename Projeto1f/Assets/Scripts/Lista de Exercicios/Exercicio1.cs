using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    private int a=1;
    private int b=17;
    private int res;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ex1()
    {
        res = a + b;
        print("Exercício 1\n" + a + " + " + b + " = " + res);
    }
}
