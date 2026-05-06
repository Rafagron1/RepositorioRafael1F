using UnityEngine;

public class Movimento : MonoBehaviour
{
    [SerializeField] private float speed;
    private float trueSpeed;
    private void Start()
    {
        transform.position = new Vector2(0f, -3f);
    }
    void Update()
    {
        trueSpeed = speed*Time.deltaTime;
        // Detecta input horizontal ou vertical, que diferente de outros inputs são valores de -1 a 1 (Sendo padrão 0)
        float px = Input.GetAxis("Horizontal") * trueSpeed;
        float py = Input.GetAxis("Vertical") * trueSpeed;
        // Quando input for 1 ou -1 multiplica o valor pela velocidade e da translate nele
        transform.Translate(px, py, 0.0f);
        // limita o objeto dentro da tela, teleportando de volta para o centro ao sair dos limites da tela (Hardcoded)
        if (transform.position.y > 5.5f ||  transform.position.y < -5.5f ||  transform.position.x > 11.5f || transform.position.x <-11.5f)
        {
            transform.position = new Vector2(0f, 0f);
        }
        // Ao gerar um input de "fire1" que é ctrl ou mouse0, causa o objeto a aumentar de escala
        if (Input.GetButton("Fire1"))
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        // Ao soltar o input leva o objeto para escala padrão
        else if (Input.GetButtonUp("Fire1"))
        {
            transform.localScale = new Vector3(1f, 1f,1f);
        }

    }
}
