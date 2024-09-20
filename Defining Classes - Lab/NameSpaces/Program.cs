using FirstNameSpace;
FirstNameSpace.FirstClass firstClass = new FirstNameSpace.FirstClass();

SecondClass secondClass = new SecondClass();

FifthClass fifthClass = new FifthClass();

namespace FirstNameSpace 
{

    class FirstClass { }
    class SecondClass { }
}

namespace FirstNameSpace //Същият namespce може да е в друг файл и пак да е достъпен!
{
    class FifthClass { }
}

namespace SecondNameSpace 
{
    class ThirdClass { }
    class FourthClass { }
}
