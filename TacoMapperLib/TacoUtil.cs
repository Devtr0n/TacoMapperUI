
namespace TacoMapperLib
{
    public enum TacoType : byte
    {
        Seafood = 1, Fusion, AlPastor, AlCarbon, Gringo, Dessert, Breakfast
    }

    public enum TacoFillingType : byte
    {
        meat = 1, eggs, veggie, fish, shrimp, bean
    }

    public enum TortillaType : byte
    {
        flour_homemade = 1, flour_non_homemade, yellow_corn, white_corn, hybrid, other
    }

    public enum TortillaShellType : byte
    {
        crispy = 1, soft, hard, puffy
    }

    public enum SalsaType : byte
    {
        fresh = 1, picodegallo, verde, tomatillo, roja, avocado, tacosauce, jarred, other
    }

    public enum TacoToppingsType : byte
    {
        cilantro = 1, whiteonion, tomato, sourcream, lettuce, refriedbeans, shreddedcheese, jalapenos, bacon, chorizo, sausage, guacamole, avacado,  olives, mushroom, corn, greenonion, rice, cabbage, grilledonions
    }

    public enum TacoAvailablilityType : byte
    {
        breakfast = 1, lunch, dinner, twentyfourhour, dessert
    }

    public enum TacoLocationType : byte
    {
        trailer = 1, restaurant, stand, other
    }

    public enum UserType : byte
    {
        regular = 1, business, admin
    }

    public enum Rating : byte
    {
        regular = 1, business, admin
    }

    public class TacoUtil
    {
    }
}
