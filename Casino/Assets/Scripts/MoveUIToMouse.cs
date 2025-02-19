using UnityEngine;

public class MoveUIToMouse : MonoBehaviour
{
    public RectTransform playerUI; // Referencia al RectTransform del objeto UI
    public float moveSpeed = 5f; // Velocidad de movimiento

    void Update()
    {
        // Obtiene la posición del ratón en pantalla
        Vector3 mousePosition = Input.mousePosition;

        // Mueve el objeto UI hacia la posición del ratón
        playerUI.position = Vector3.Lerp(playerUI.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}
