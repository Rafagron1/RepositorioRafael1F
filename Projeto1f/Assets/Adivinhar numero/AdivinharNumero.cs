using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class AdivinharNumero : MonoBehaviour
{
    [SerializeField] private int numero;
    private int tentativas;
    [SerializeField] private int dificuldade;
    [SerializeField] private int numeroAleatorio;

    void Start()
    {
        tentativas = 3;
        SelecionaDificuldade();
    }


    void Update()
    {
        PrintaNumero();
    }
    
    void SelecionaDificuldade()
    {
        if (dificuldade <1)
        {
            numeroAleatorio = Random.Range(1, 51);
            if (numeroAleatorio > 40)
            {
                print("O número é menor que: 51 e maior que: " + (numeroAleatorio - Random.Range(1, 11)));
            }
            if (numeroAleatorio < 10)
            {
                print("O número é maior que: 0 e menor que: " + (numeroAleatorio + Random.Range(1, 11)));
            }
            if (numeroAleatorio >= 10 && numeroAleatorio <= 40) print("O número é maior que: " + (numeroAleatorio - Random.Range(1, 11)) + " e menor que: " + (numeroAleatorio + Random.Range(1, 11)));
        }
        if (dificuldade == 1)
        {
            numeroAleatorio = Random.Range(1, 101);
            if (numeroAleatorio > 80)
            {
                print("O número é menor que: 101 e maior que: " + (numeroAleatorio - Random.Range(1, 21)));
            }
            if (numeroAleatorio < 20)
            {
                print("O número é maior que: 0 e menor que: " + (numeroAleatorio + Random.Range(1, 21)));
            }
            if (numeroAleatorio >= 20 && numeroAleatorio <= 80) print("O número é maior que: " + (numeroAleatorio - Random.Range(1, 21)) + " e menor que: " + (numeroAleatorio + Random.Range(1, 21)));
        }
        if (dificuldade > 1) 
        {
            numeroAleatorio = Random.Range(1, 501);
            if (numeroAleatorio > 450)
            {
                print("O número é menor que: 501 e maior que: " +(numeroAleatorio-Random.Range(1, 51)));
            }
            if (numeroAleatorio < 50)
            {
                print("O número é maior que: 0 e menor que: "+ (numeroAleatorio+ Random.Range(1, 51)));
            }
            if (numeroAleatorio >= 50 && numeroAleatorio <= 450) print("O número é maior que: " +(numeroAleatorio- Random.Range(1, 51)) +" e menor que: "+(numeroAleatorio +Random.Range(1, 51)));
        }
    }
    void PrintaNumero()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && tentativas > 0)
        {
            print("Escolhi o numero: " + numero);
            if (numero < numeroAleatorio)
            {
                print("O número que você escolheu é menor do que o número secreto");
                tentativas -= 1;
                print("Você tem: " + tentativas + " restantes");
                print("======================");
            }
            if (numero > numeroAleatorio)
            {
                print("O número que você escolheu é maior do que o número secreto");
                tentativas -= 1;
                print("Você tem: " + tentativas + " restantes");
                print("======================");
            }
            if (numero == numeroAleatorio)
            {
                print("Você acertou o número!");
                tentativas = -1;
            }
        }
        else if (Keyboard.current.eKey.wasPressedThisFrame)print("Você não tem mais tentativas");
    }
}
