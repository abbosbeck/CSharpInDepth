using System.Collections;

namespace Part2
{
    class Generics
    {
        public static ArrayList GenerateNames()
        {
            /*string[] names = new string[5];
            names[0] = "Jon";
            names[1] = "Tom";
            names[2] = "Jerry";*/

            ArrayList names = new ArrayList();
            names.Add("Jon");
            names.Add("Tom");
            names.Add("Jerry");
            names.Add("Mickey");
            names.Add("Minnie");


            return names;
        }
    }
}
