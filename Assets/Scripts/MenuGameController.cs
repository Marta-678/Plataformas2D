using UnityEngine;

public class MenuGameController : MonoBehaviour
{
    [SerializeField] private GameObject menuOpen;
    [SerializeField] private GameObject menuClose;


    private bool isMenuOpen = false;      // Para saber si el menú está abierto o cerrado

    void Update()
    {
        // Abre o cierra el menú al presionar la tecla M
        if (Input.GetKeyDown(KeyCode.M))
        {
            menuClose.SetActive(!menuClose.activeSelf);
            menuOpen.SetActive(!menuOpen.activeSelf);

        }

        // Si el menú está abierto y se selecciona un ítem
        
    }

}








// using UnityEngine;

// public class MenuGameController : MonoBehaviour
// {
//     public GameObject menuPanel;           // Panel donde está el menú
//     public Dropdown itemDropdown;         // Dropdown para seleccionar los ítems (si usas botones, usa Button[])
//     public Animator playerAnimator;       // Referencia al Animator del jugador
//     public RuntimeAnimatorController[] animatorControllers; // Array de Animator Controllers

//     private bool isMenuOpen = false;      // Para saber si el menú está abierto o cerrado

//     void Update()
//     {
//         // Abre o cierra el menú al presionar la tecla M
//         if (Input.GetKeyDown(KeyCode.M))
//         {
//             ToggleMenu();
//         }

//         // Si el menú está abierto y se selecciona un ítem
//         if (isMenuOpen && itemDropdown != null)
//         {
//             int selectedIndex = itemDropdown.value;
//             if (selectedIndex >= 0 && selectedIndex < animatorControllers.Length)
//             {
//                 ChangeAnimatorController(selectedIndex);
//             }
//         }
//     }

//     void ToggleMenu()
//     {
//         // Cambia el estado del menú
//         isMenuOpen = !isMenuOpen;
//         menuPanel.SetActive(isMenuOpen);

//         // Si el menú está abierto, llenar el Dropdown con los ítems
//         if (isMenuOpen)
//         {
//             itemDropdown.ClearOptions();
//             List<string> options = new List<string>();

//             // Añadir los nombres de los ítems al Dropdown
//             foreach (var controller in animatorControllers)
//             {
//                 options.Add(controller.name);
//             }

//             itemDropdown.AddOptions(options);
//         }
//     }

//     void ChangeAnimatorController(int index)
//     {
//         // Cambiar el Animator Controller del jugador
//         if (index >= 0 && index < animatorControllers.Length)
//         {
//             playerAnimator.runtimeAnimatorController = animatorControllers[index];
//         }
//     }
// }
