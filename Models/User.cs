namespace c_sharp_intro.Models
{
    // Access Modifier
    //      Public  <-- Accessible by anything outside the namespace
    //      Private  <-- Only accessible within the class itself
    //      Internal  <-- Accessible by anything inside the same namespace *uncommon*
    //      Protected  <-- Only accessible by children that inherit the class *uncommon*

    //      NOTE Default access modifier is Internal
    public class User
    {
        public string Name { get; set; }
        // AccessModifier, DataType, Name { get <-- "anybody can access"; set <-- "anybody can modify"; }
        public int Age { get; private set; }
        // private set <-- Only accessible within this class

        public string HappyBirthday()
        // method signature (access mofidier, return type, name)
        {
            Age++;
            if (Age > 100)
            {
                return "Wow, you sure he's not dead?";
            }
            else
            {
                return "Happy Birthday";
            }
        }

        public void Birthday()
        // NOTE VOID return type means "Nothing to Return"
        {
            Age++;
        }


        public User(string name, int age)
        // NOTE ctor  <-- keyboard shortcut to generate Constructor Template
        // NOTE Equivalent to the Constructor  <-- inside the class, declare a public method with the same name
        {
            Name = name;
            Age = age;
        }
    }
}