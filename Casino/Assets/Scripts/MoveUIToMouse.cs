using UnityEngine;

public class MoveUIToMouse : MonoBehaviour
{
    public RectTransform playerUI; // Referencia al RectTransform del objeto UI
    public float moveSpeed = 5f; // Velocidad de movimiento

    void Update()
    {
        // Obtiene la posici�n del rat�n en pantalla
        Vector3 mousePosition = Input.mousePosition;

        // Mueve el objeto UI hacia la posici�n del rat�n
        playerUI.position = Vector3.Lerp(playerUI.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}
